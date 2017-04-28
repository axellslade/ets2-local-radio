using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETS2_Local_Radio_server.Logic;

namespace ETS2_Local_Radio_server.UI
{
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void goToFavouriteKeyLabel_Click(object sender, EventArgs e)
        {

        }

        private void SettingsView_Load(object sender, EventArgs e)
        {
            Settings.Load();

            nextKeyTextBox.Text = Settings.NextKey;
            previousKeyTextBox.Text = Settings.PreviousKey;
            stopKeyTextBox.Text = Settings.StopKey;
            volumeUpKeyTextBox.Text = Settings.VolumeUpKey;
            volumeDownKeyTextBox.Text = Settings.VolumeDownKey;
            makeFavouriteKeyTextbox.Text = Settings.MakeFavouriteKey;
            goToFavouriteKeyTextbox.Text = Settings.GoToFavouriteKey;

            nextButtonTextBox.Text = Settings.NextButton;
            previousButtonTextBox.Text = Settings.PreviousButton;
            stopButtonTextBox.Text = Settings.StopButton;
            volumeUpButtonTextBox.Text = Settings.VolumeUpButton;
            volumeDownButtonTextBox.Text = Settings.VolumeDownButton;
            makeFavouriteButtonTextbox.Text = Settings.MakeFavouriteButton;
            goToFavouriteButtonTextbox.Text = Settings.GoToFavouriteButton;

            //Add handlers:
            nextKeyTextBox.KeyDown += keyInput;
            previousKeyTextBox.KeyDown += keyInput;
            stopKeyTextBox.KeyDown += keyInput;
            volumeUpKeyTextBox.KeyDown += keyInput;
            volumeDownKeyTextBox.KeyDown += keyInput;
            makeFavouriteKeyTextbox.KeyDown += keyInput;
            goToFavouriteKeyTextbox.KeyDown += keyInput;

            //Remove key binding:
            nextKeyTextBox.KeyDown += removeBinding;
            previousKeyTextBox.KeyDown += removeBinding;
            stopKeyTextBox.KeyDown += removeBinding;
            volumeUpKeyTextBox.KeyDown += removeBinding;
            volumeDownKeyTextBox.KeyDown += removeBinding;
            makeFavouriteKeyTextbox.KeyDown += removeBinding;
            goToFavouriteKeyTextbox.KeyDown += removeBinding;

            nextButtonTextBox.KeyDown += removeBinding;
            previousButtonTextBox.KeyDown += removeBinding;
            stopButtonTextBox.KeyDown += removeBinding;
            volumeUpButtonTextBox.KeyDown += removeBinding;
            volumeDownButtonTextBox.KeyDown += removeBinding;
            makeFavouriteButtonTextbox.KeyDown += removeBinding;
            goToFavouriteButtonTextbox.KeyDown += removeBinding;
        }

        private void keyInput(object sender, KeyEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            e.Handled = true;
            e.SuppressKeyPress = true;
            txtBox.Text = e.KeyCode.ToString();
        }
        private void removeBinding(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Back)
            {
                TextBox txtBox = (TextBox)sender;
                e.Handled = true;
                e.SuppressKeyPress = true;
                txtBox.Clear();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Settings.NextKey = nextKeyTextBox.Text;
            Settings.PreviousKey = previousKeyTextBox.Text;
            Settings.StopKey = stopKeyTextBox.Text;
            Settings.VolumeUpKey = volumeUpKeyTextBox.Text;
            Settings.VolumeDownKey = volumeDownKeyTextBox.Text;
            Settings.MakeFavouriteKey = makeFavouriteKeyTextbox.Text;
            Settings.GoToFavouriteKey = goToFavouriteKeyTextbox.Text;

            Settings.NextButton = nextButtonTextBox.Text;
            Settings.PreviousButton = previousButtonTextBox.Text;
            Settings.StopButton = stopButtonTextBox.Text;
            Settings.VolumeUpButton = volumeUpButtonTextBox.Text;
            Settings.VolumeDownButton = volumeDownButtonTextBox.Text;
            Settings.MakeFavouriteButton = makeFavouriteButtonTextbox.Text;
            Settings.GoToFavouriteButton = goToFavouriteButtonTextbox.Text;

            Settings.Save();
        }
    }
}
