using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace ETS2_Local_Radio_server.Logic
{
    class Input
    {
        public IKeyboardMouseEvents GlobalHook;
        private bool[] _joystickPreviousState;

        public void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            GlobalHook = Hook.GlobalEvents();

            GlobalHook.KeyDown += GlobalHookKeyDown;
        }

        public void Unsubscribe()
        {
            GlobalHook.KeyDown -= GlobalHookKeyDown;

            //It is recommened to dispose it
            GlobalHook.Dispose();
        }

        public void GlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Settings.PreviousKey != "" && e.KeyCode == (Keys)Enum.Parse(typeof(Keys), Settings.PreviousKey, true))
                {
                    Console.WriteLine("Fired event PreviousKey");
                    Program.CommandsData = new Commands("Previous");
                }
                if (Settings.NextKey != "" && e.KeyCode == (Keys)Enum.Parse(typeof(Keys), Settings.NextKey, true))
                {
                    Console.WriteLine("Fired event NextKey");
                    Program.CommandsData = new Commands("Next");
                }
                if (Settings.StopKey != "" && e.KeyCode == (Keys)Enum.Parse(typeof(Keys), Settings.StopKey, true))
                {
                    Console.WriteLine("Fired event StopKey");
                    Program.CommandsData = new Commands("Stop");
                }
                if (Settings.VolumeUpKey != "" && e.KeyCode == (Keys)Enum.Parse(typeof(Keys), Settings.VolumeUpKey, true))
                {
                    Console.WriteLine("Fired event VolumeUpKey");
                    Program.CommandsData = new Commands("VolumeUp");
                }
                if (Settings.VolumeDownKey != "" && e.KeyCode == (Keys)Enum.Parse(typeof(Keys), Settings.VolumeDownKey, true))
                {
                    Console.WriteLine("Fired event VolumeDownKey");
                    Program.CommandsData = new Commands("VolumeDown");
                }
                if (Settings.MakeFavouriteKey != "" && e.KeyCode == (Keys)Enum.Parse(typeof(Keys), Settings.MakeFavouriteKey, true))
                {
                    Console.WriteLine("Fired event MakeFavouriteKey");
                    Program.CommandsData = new Commands("MakeFavourite");
                }
                if (Settings.GoToFavouriteKey != "" && e.KeyCode == (Keys)Enum.Parse(typeof(Keys), Settings.GoToFavouriteKey, true))
                {
                    Console.WriteLine("Fired event GoToFavouriteKey");
                    Program.CommandsData = new Commands("GoToFavourite");
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex.ToString());
            }
        }

        public int GlobalHookJoystick(SimpleJoystick joystick)
        {
            if (joystick == null)
            {
                return 0;
            }
            try
            {
                bool[] controllerInput = new bool[joystick.State.GetButtons().Length + 4]; // = joystick.State.GetButtons().Concat(joystick.State.GetPointOfViewControllers()).ToArray();
                joystick.State.GetButtons().CopyTo(controllerInput, 0);
                bool[] povState = new bool[4] { false, false, false, false };

                switch (joystick.State.GetPointOfViewControllers()[0])
                {
                    case 0:
                        povState[0] = true;
                        break;
                    case 9000:
                        povState[1] = true;
                        break;
                    case 18000:
                        povState[2] = true;
                        break;
                    case 27000:
                        povState[3] = true;
                        break;
                    default:
                        break;
                }
                povState.CopyTo(controllerInput, joystick.State.GetButtons().Length);

                for (int i = 0; i < controllerInput.Length; i++)
                {

                    if (controllerInput[i] && controllerInput[i] != _joystickPreviousState[i])
                    {
                        if (Settings.NextButton == i.ToString())
                        {
                            Console.WriteLine("Fired event NextButton");
                            Program.CommandsData = new Commands("Next");
                        }
                        if (Settings.PreviousButton == i.ToString())
                        {
                            Console.WriteLine("Fired event PreviousButton");
                            Program.CommandsData = new Commands("Previous");
                        }
                        if (Settings.StopButton == i.ToString())
                        {
                            Console.WriteLine("Fired event StopButton");
                            Program.CommandsData = new Commands("Stop");
                        }
                        if (Settings.VolumeUpButton == i.ToString())
                        {
                            Console.WriteLine("Fired event VolumeUpButton");
                            Program.CommandsData = new Commands("VolumeUp");
                        }
                        if (Settings.VolumeDownButton == i.ToString())
                        {
                            Console.WriteLine("Fired event VolumeDownButton");
                            Program.CommandsData = new Commands("VolumeDown");
                        }
                        if (Settings.MakeFavouriteButton == i.ToString())
                        {
                            Console.WriteLine("Fired event MakeFavouriteButton");
                            Program.CommandsData = new Commands("MakeFavourite");
                        }
                        if (Settings.GoToFavouriteButton == i.ToString())
                        {
                            Console.WriteLine("Fired event GoToFavouriteButton");
                            Program.CommandsData = new Commands("GoToFavourite");
                        }
                    }
                }
                _joystickPreviousState = controllerInput;
                return controllerInput.Length;
            }
            catch (Exception)
            {
                //Log.Write(ex.ToString());
            }
            return 0;
        }
    }
}
