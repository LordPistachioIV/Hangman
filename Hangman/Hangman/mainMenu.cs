using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hangman.Properties;

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
            //open into the multiplayer form
        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            rules newRules = new rules();
            newRules.Show(this);
            this.Hide();
            //opens into rules form
        }

        private void onePlayerBtn_Click(object sender, EventArgs e)
        {
            HangmanSingle newSingle = new HangmanSingle();
            newSingle.Show(this);
            this.Hide();
            //open into the singple player form
        }

        ////////////////////
        ///    BUTTON    ///
        ///   GRAPHICS   ///
        ////////////////////

        private void onePlayerBtn_MouseEnter(object sender, EventArgs e)
        {
            onePlayerBtn.Image = Resources.onePlayerOver;
        }

        private void onePlayerBtn_MouseLeave(object sender, EventArgs e)
        {
            onePlayerBtn.Image = Resources.onePlayerBtn;
        }

        private void onePlayerBtn_MouseDown(object sender, MouseEventArgs e)
        {
            onePlayerBtn.Image = Resources.onePlayerDown;
        }

        private void onePlayerBtn_MouseUp(object sender, MouseEventArgs e)
        {
            onePlayerBtn.Image = Resources.onePlayerBtn;
        }

        private void twoPlayerBtn_MouseDown(object sender, MouseEventArgs e)
        {
            twoPlayerBtn.Image = Resources.twoPlayersDown;
        }

        private void twoPlayerBtn_MouseLeave(object sender, EventArgs e)
        {
            twoPlayerBtn.Image = Resources.twoPlayersBtn;
        }

        private void twoPlayerBtn_MouseUp(object sender, MouseEventArgs e)
        {
            twoPlayerBtn.Image = Resources.twoPlayersBtn;
        }

        private void twoPlayerBtn_MouseEnter(object sender, EventArgs e)
        {
            twoPlayerBtn.Image = Resources.twoPlayersOver;
        }

        private void rulesBtn_MouseDown(object sender, MouseEventArgs e)
        {
            rulesBtn.Image = Resources.rulesDown;
        }

        private void rulesBtn_MouseEnter(object sender, EventArgs e)
        {
            rulesBtn.Image = Resources.rulesOver;
        }

        private void rulesBtn_MouseLeave(object sender, EventArgs e)
        {
            rulesBtn.Image = Resources.rulesBtn;
        }

        private void rulesBtn_MouseUp(object sender, MouseEventArgs e)
        {
            rulesBtn.Image = Resources.rulesBtn;
        }

        private void exitBtn_MouseDown(object sender, MouseEventArgs e)
        {
            exitBtn.Image = Resources.exitBtnDown;
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.Image = Resources.exitBtn2Over;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.Image = Resources.exitBtn;
        }

        private void exitBtn_MouseUp(object sender, MouseEventArgs e)
        {
            exitBtn.Image = Resources.exitBtn;
        }
    }
}
