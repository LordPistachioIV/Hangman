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
    public partial class rules : Form
    {
        public rules()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MainMenu openMain = (MainMenu)this.Owner;
            this.Close();
            openMain.Show();
        }

        ////////////////////
        ///    BUTTON    ///
        ///   GRAPHICS   ///
        ////////////////////

        private void exitBtn_MouseDown(object sender, MouseEventArgs e)
        {
            exitBtn.Image = Resources.exitBtn2Down;
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.Image = Resources.exitBtn2Over;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.Image = Resources.exitBtn2;
        }

        private void exitBtn_MouseUp(object sender, MouseEventArgs e)
        {
            exitBtn.Image = Resources.exitBtn2;
        }
    }
}
