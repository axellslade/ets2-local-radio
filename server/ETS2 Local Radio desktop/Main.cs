using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Ets2SdkClient;
using ETS2_Local_Radio_server.Logic;
using ETS2_Local_Radio_server.Properties;
using ETS2_Local_Radio_server.UI;
using Gma.System.MouseKeyHook;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Settings = ETS2_Local_Radio_server.Logic.Settings;

namespace ETS2_Local_Radio_server
{
    public partial class Main : Form
    {
        public Ets2SdkTelemetry Telemetry;

        public SimpleHTTPServer MyServer;

        private SimpleJoystick _joystick;
        private Input _input;

        private Firewall _firewall;

        private bool[] previousState;

        public static Coordinates coordinates;

        public static string simulatorNotRunning = "Simulator not yet running";
        public static string simulatorNotDriving = "Simulator running, let's get driving!";
        public static string simulatorRunning = "Simulator running!";

        public static string installOverlay =
            "Do you want to install the in-game overlay?\n(This will overwrite an already existing d3d9.dll, and it may in rare cases cause the game to crash when exiting the game)";

        public static string removeOverlay =
            "Do you want to remove the in-game overlay?\n(This will remove any existing d3d9.dll)";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Log.Clear();
            Settings.Load();

            _input = new Input();
            _input.Subscribe();

            _firewall = new Firewall();
            _firewall.AddException();

            //Load languages to combobox:
            LoadLanguages();

            //Check plugins:
            CheckPlugins();

            comboController.SelectedText = Settings.Controller;

            //Load favourites
            Favourites.Load();

            //Start telemetry grabbing:
            Telemetry = new Ets2SdkTelemetry(250);
            Telemetry.Data += Telemetry_Data;

            if (Telemetry.Error != null)
            {
                MessageBox.Show(
                    "General info:\r\nFailed to open memory map " + Telemetry.Map +
                        " - on some systems you need to run the client (this app) with elevated permissions, because e.g. you're running Steam/ETS2 with elevated permissions as well. .NET reported the following Exception:\r\n" +
                        Telemetry.Error.Message + "\r\n\r\nStacktrace:\r\n" + Telemetry.Error.StackTrace);
            }

            //Open server:
            MyServer = new SimpleHTTPServer(Directory.GetCurrentDirectory() + "\\web", Settings.Port);
            Program.CommandsData = new Commands("None");

            if (AttachJoystick())
            {
                foreach (var item in _joystick.AvailableDevices)
                {
                    comboController.Items.Add(item.InstanceName);
                }
            }
            AttachJoystick();

            currentGameTimer.Start();

            
        }

        private void LoadLanguages()
        {
            try
            {
                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\web\\lang"))
                {
                    throw new Exception("\\web\\lang directory not found");
                }
                foreach (string file in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\web\\lang"))
                {
                    if (file.EndsWith(".json"))
                    {
                        comboLang.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
                }
                comboLang.Text = Settings.Language;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void CheckPlugins()
        {
            Plugins plugins = new Plugins();
            installAtsButton.Image = plugins.Check("ats") ? Resources.check : null;
            installEts2Button.Image = plugins.Check("ets2") ? Resources.check : null;
            if (!plugins.Check("ats") && !plugins.Check("ets2"))
            {
                groupInfo.Enabled = false;
                groupSettings.Enabled = false;
            }
            else
            {
                groupInfo.Enabled = true;
                groupSettings.Enabled = true;
            }
        }

        private bool ChooseFolder(string game)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DialogResult result = MessageBox.Show(installOverlay, "ETS2 Local Radio server",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question);

                    if (result != DialogResult.Cancel)
                    {
                        string folder = folderDialog.SelectedPath;
                        Directory.CreateDirectory(folder + @"\bin\win_x86\plugins");
                        Directory.CreateDirectory(folder + @"\bin\win_x64\plugins");

                        File.Copy(Directory.GetCurrentDirectory() + @"\plugins\bin\win_x86\plugins\ets2-telemetry.dll",
                            folder + @"\bin\win_x86\plugins\ets2-telemetry.dll", true);
                        File.Copy(Directory.GetCurrentDirectory() + @"\plugins\bin\win_x64\plugins\ets2-telemetry.dll",
                            folder + @"\bin\win_x64\plugins\ets2-telemetry.dll", true);
                        if (result == DialogResult.Yes)
                        {
                            File.Copy(Directory.GetCurrentDirectory() + @"\plugins\bin\win_x86\d3d9.dll",
                                folder + @"\bin\win_x86\d3d9.dll", true);
                            File.Copy(Directory.GetCurrentDirectory() + @"\plugins\bin\win_x64\d3d9.dll",
                                folder + @"\bin\win_x64\d3d9.dll", true);
                        }

                        if (game == "ets2")
                        {
                            Settings.Ets2Folder = folder;
                        }
                        if (game == "ats")
                        {
                            Settings.AtsFolder = folder;
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool AttachJoystick()
        {
            try
            {
                //Initialise joystick:
                string name = null;
                if (Settings.Controller != null)
                {
                    name = Settings.Controller;
                }
                _joystick = new SimpleJoystick(name);

                //Start joystick input timer:
                joystickTimer.Start();
                return true;
            }
            catch (Exception ex)
            {
                Log.Write(ex.ToString());
                return false;
            }
        }

        private void Telemetry_Data(Ets2Telemetry data, bool updated)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new TelemetryData(Telemetry_Data), new object[2] { data, updated });
                    return;
                }

                Program.Ets2data = data;
                coordinates = new Coordinates(data.Physics.CoordinateX, data.Physics.CoordinateY, data.Physics.CoordinateZ);
                infoView.locationLabel.Text = coordinates.X + "; " + coordinates.Y + "; " + coordinates.Z;

                if (data.Version.Ets2Major == 0)
                {
                    infoView.statusLabel.Text = simulatorNotRunning;
                    infoView.statusLabel.ForeColor = Color.Red;
                }
                else if (data.Time == 0)
                {
                    infoView.statusLabel.Text = simulatorNotDriving;
                    infoView.statusLabel.ForeColor = Color.DarkOrange;
                }
                else
                {
                    infoView.statusLabel.Text = simulatorRunning;
                    infoView.statusLabel.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        private void Main_FormClosing(object sender, EventArgs e)
        {
            try
            {
                //Global keyboard hook logic by https://github.com/gmamaladze/globalmousekeyhook/blob/vNext/Demo/Main.cs
                Settings.Save();
                _input.Unsubscribe();
                MyServer.Stop();
                _firewall.DeleteException();
                joystickTimer.Stop();
                _joystick.Release();
            }
            catch (Exception ex)
            {
                Log.Write(ex.ToString());
            }
            finally
            {
                Application.Exit();
            }
        }

        private void Koenvh_Click(object sender, EventArgs e)
        {
            Process.Start("http://koenvh.nl");
        }

        private void comboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Language language = new Language(comboLang.SelectedItem.ToString());
                dynamic server = language.GetFile();

                groupInfo.Text = (server["info"] ?? groupInfo.Text);
                infoView.gameInfo.Text = (server["game"] ?? infoView.gameInfo.Text);
                infoView.statusInfo.Text = (server["status"] ?? infoView.statusInfo.Text);
                simulatorNotRunning = (server["simulator-not-running"] ?? simulatorNotRunning);
                simulatorNotDriving = (server["simulator-not-driving"] ?? simulatorNotDriving);
                simulatorRunning = (server["simulator-running"] ?? simulatorRunning);
                infoView.coordinatesInfo.Text = (server["coordinates"] ?? infoView.coordinatesInfo.Text);
                infoView.URLInfo.Text = (server["url"] ?? infoView.URLInfo.Text);
                infoView.URLLabel.Text = (server["open-local-radio"] ?? infoView.URLLabel.Text);
                groupSettings.Text = (server["settings"] ?? groupSettings.Text);
                settingsView.keyLabel.Text = (server["keyboard"] ?? settingsView.keyLabel.Text);
                settingsView.buttonLabel.Text = (server["controller"] ?? settingsView.buttonLabel.Text);
                settingsView.nextKeyLabel.Text = (server["next-station-key"] ?? settingsView.nextKeyLabel.Text);
                settingsView.previousKeyLabel.Text = (server["previous-station-key"] ?? settingsView.previousKeyLabel.Text);
                settingsView.stopKeyLabel.Text = (server["stop-playback-key"] ?? settingsView.stopKeyLabel.Text);
                settingsView.volumeUpKeyLabel.Text = (server["volume-up-key"] ?? settingsView.volumeUpKeyLabel.Text);
                settingsView.volumeDownKeyLabel.Text = (server["volume-down-key"] ?? settingsView.volumeDownKeyLabel.Text);
                settingsView.makeFavouriteKeyLabel.Text = (server["make-favourite-key"] ?? settingsView.makeFavouriteKeyLabel.Text);
                settingsView.goToFavouriteKeyLabel.Text = (server["go-to-favourite-key"] ?? settingsView.goToFavouriteKeyLabel.Text);
                settingsView.saveButton.Text = (server["save"] ?? settingsView.saveButton.Text);
                groupController.Text = (server["controller"] ?? groupController.Text);
                groupInstall.Text = (server["install"] ?? groupInstall.Text);
                installAtsButton.Text = (server["install-plugin-ats"] ?? installAtsButton.Text);
                installEts2Button.Text = (server["install-plugin-ets2"] ?? installEts2Button.Text);
                removePluginButton.Text = (server["remove-plugin"] ?? removePluginButton.Text);
                installOverlay = (server["install-overlay"] ?? installOverlay);
                removeOverlay = (server["remove-overlay"] ?? removeOverlay);
                folderDialog.Description = (server["ets2-folder-dialog"] ?? folderDialog.Description);
                Station.NowPlaying = (server["now-playing"] ?? Station.NowPlaying);

                Settings.Language = comboLang.SelectedItem.ToString();

                Program.CommandsData = new Commands("Language");
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void joystickTimer_Tick(object sender, EventArgs e)
        {
            var length = _input.GlobalHookJoystick(_joystick);

            for (var i = 0; i < length; i++)
            {
                if (settingsView.nextButtonTextBox.Focused)
                {
                    settingsView.nextButtonTextBox.Text = i.ToString();
                }
                if (settingsView.previousButtonTextBox.Focused)
                {
                    settingsView.previousButtonTextBox.Text = i.ToString();
                }
                if (settingsView.stopButtonTextBox.Focused)
                {
                    settingsView.stopButtonTextBox.Text = i.ToString();
                }
                if (settingsView.volumeUpButtonTextBox.Focused)
                {
                    settingsView.volumeUpButtonTextBox.Text = i.ToString();
                }
                if (settingsView.volumeDownButtonTextBox.Focused)
                {
                    settingsView.volumeDownButtonTextBox.Text = i.ToString();
                }
                if (settingsView.makeFavouriteButtonTextbox.Focused)
                {
                    settingsView.makeFavouriteButtonTextbox.Text = i.ToString();
                }
                if (settingsView.goToFavouriteButtonTextbox.Focused)
                {
                    settingsView.goToFavouriteButtonTextbox.Text = i.ToString();
                }
            }
        }

        private void currentGameTimer_Tick(object sender, EventArgs e)
        {
            if (Program.Game != "ets2")
            {
                if (Process.GetProcessesByName("eurotrucks2").Length > 0)
                {
                    Program.Game = "ets2";
                    infoView.gameLabel.Text = "Euro Truck Simulator 2";
                    Program.CommandsData = new Commands("Game");
                }
            }
            if (Program.Game != "ats")
            {
                if (Process.GetProcessesByName("amtrucks").Length > 0)
                {
                    Program.Game = "ats";
                    infoView.gameLabel.Text = "American Truck Simulator";
                    Program.CommandsData = new Commands("Game");
                }
            }
        }

        private void installAtsButton_Click(object sender, EventArgs e)
        {
            if (ChooseFolder("ats"))
            {
                installAtsButton.Image = Resources.check;
                groupInfo.Enabled = true;
                groupSettings.Enabled = true;
            }
        }

        private void installEts2Button_Click(object sender, EventArgs e)
        {
            if (ChooseFolder("ets2"))
            {
                installEts2Button.Image = Resources.check;
                groupInfo.Enabled = true;
                groupSettings.Enabled = true;
            }
        }

        private void comboController_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Controller = comboController.SelectedItem.ToString();

            AttachJoystick();
        }

        private void removePluginButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(removeOverlay, "ETS2 Local Radio server",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (result != DialogResult.Cancel)
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        var folder = folderDialog.SelectedPath;
                        File.Delete(folder + @"\bin\win_x86\plugins\ets2-telemetry.dll");
                        File.Delete(folder + @"\bin\win_x64\plugins\ets2-telemetry.dll");

                        if (result == DialogResult.Yes)
                        {
                            File.Delete(folder + @"\bin\win_x86\d3d9.dll");
                            File.Delete(folder + @"\bin\win_x64\d3d9.dll");
                        }
                    }
                }
                CheckPlugins();
            }
            catch (Exception ex)
            {
                Log.Write(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }
}
