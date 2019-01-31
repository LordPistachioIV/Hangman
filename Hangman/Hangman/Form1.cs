using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Are you sure you would like to exit this program?", "Exit Program", buttons);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
            /*
             * Using a class like feature to setup the options for exiting the program without
             * using another form.
             * Setting the message and title can be removed if needed
             */
        }

        private void singlePlayerBtn_Click(object sender, EventArgs e)
        {
            HangmanMulti newMulti = new HangmanMulti();
            newMulti.Show(this);
            this.Hide();
            //open into the single player form
        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The aim of Hangman is to correctly guess a hidden word by" +
                "\nentering letters." +
                "\n\nIncorrect guesses add parts to the gallows and the hangman." +
                "\n\nYou have 10 attempts to guess the word before you lose." +
                "\n\nYou can also guess the complete word if you think you know it, but" +
                "\nbe careful, as a wrong guess will cost 3 attempts!" +
                "\n\nWhen there are two players, Player 1 can type in the word they want Player 2 to guess.",
                "Rules", MessageBoxButtons.OK);
            //Display rules in a message box as seen here \n making a new line and \n\n to add spacing
        }
    }
}
