using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hangman.Properties;

namespace Hangman
{
    public partial class HangmanMulti : Form
    {
        string word, player1, player2;
        char guess;
        int guessesLeft = 10, correctGuesses = 0, player1Points = 0, player2Points = 0;
        bool isLetterCorrect = false, Catch = false, turn = false, musicEnabled = true;
        SoundPlayer player = new SoundPlayer(Resources.main); //initalise soundplayer with BGM

        /* Run down of what each variable is used for
         * 
         * string word | this will be holding the word of which is entered for anothe person to guess.
         * char guess | this is used when checking the word against what the player has guessed to be in the word
         * int guessesLeft = 10 | this is used for the display of how many guesses are left and the hangman animation
         * also used within loss condtions
         * int correctGuesses = 0 | this is used to compare against "word" and for win condtions
         * int player1Points | this is to hold how many points player one gets for a word depending on its length
         * int player2Points | this is to hold how many points player two gets for a word depending on its length
         * bool isLetterCorrect = false | this is used to check whether the guess made is correct or not
         * bool Catch = false | this is used to catch the process if a null entry has been made
         * bool turn = false | this is the turn counter used to change whos turn it is as the game plays
         */

        public HangmanMulti()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Are you sure you would like to exit this program?", "Exit Program", buttons);
            if (result == DialogResult.OK)
            {
                player.Stop();
                MainMenu openMain = (MainMenu)this.Owner;
                this.Close();
                openMain.Show();
            }
            //exits the program with a confirmation message.
        }

        private void letterEntryTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                guessLetterBtn_Click(this, new EventArgs());
            }
            //On keypress enter run the "guessLetterBtn" proccess.
        }

        private void MultiPlayer_Load(object sender, EventArgs e)
        {
            guessesLeftLbl.Text = "Guesses left: " + guessesLeft.ToString();//setting up the guesses left display
            if (musicEnabled)
            {
                musicBtn.Image = Resources.musicOnBtn;
            }
            else
            {
                musicBtn.Image = Resources.musicOffBtn;
            }
            playerTurnLbl.Hide();

            player.PlayLooping();

            enterWordLbl.Hide();
            wordEntryTxt.Hide();
            wordOKBtn.Hide();
            wordCancelBtn.Hide();
        }

        private void wordCancelBtn_Click(object sender, EventArgs e)
        {
            player.Stop();
            MainMenu openMain = (MainMenu)this.Owner;
            this.Close();
            openMain.Show();
            //If the user wants to leave then they will go back to the main menu.
        }

        private void wordOKBtn_Click(object sender, EventArgs e)
        {
            if (wordEntryTxt.Text != "") //if word is not blank
            {
                word = wordEntryTxt.Text.ToLower(); //add text box contents to word and make it lower case
                wordEntryPnl.Hide();

                //" " a separate character that is not a space

                spacedLabel.Text = "";

                lettersInWordLbl.Text = "Letters: " + word.Length.ToString();
                lettersLeftInWordLbl.Text = "Letters left: " + word.Length.ToString();
                //setting up display for how many letters are in the word being guessed
                
                foreach(char c in word)
                {
                    spacedLabel.Text = spacedLabel.Text + "-";
                }
                //Setting up the label that will display the correct letters in the word

                guessesLeft = 10;
                guessesLeftLbl.Text = "Guesses left: " + guessesLeft;
                displayHangman();
                incorrectGuessesLst.Items.Clear();

                player1PointsLbl.Text = player1 + "'s points: " + player1Points;
                player2PointsLbl.Text = player2 + "'s points: " + player2Points;
            }
            else //if text box is blank
            {
                MessageBox.Show("Please enter a word!", "Error", MessageBoxButtons.OK); //get user to input string
            }

            if (musicEnabled)
            {
                music2.Image = Resources.musicOnBtn;
            }
            else
            {
                music2.Image = Resources.musicOffBtn;
            }
        }

        private void guessWholeWordBtn_Click(object sender, EventArgs e)
        {
            Catch = false;

            if (guessWordTxt.Text == "")
            {
                Catch = true;
                //catching if the entry is null
            }

            if (Catch == false)
            {
                guessWordTxt.Text = guessWordTxt.Text.ToLower();

                if (guessWordTxt.Text == word)//if the whole word guessed matches the word
                {
                    winCondition();//run win condtion
                    guessWordTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Incorrect guess! Too bad!", "Incorrect guess!", MessageBoxButtons.OK);//display incorrect guess box
                    guessesLeft = guessesLeft - 3;//minus 3 off of the guesses left
                    displayHangman();//update the hangman animation
                    guessesLeftLbl.Text = "Guesses left: " + guessesLeft;//update guesses left display
                    guessWordTxt.Text = "";//clear text box to avoid double enrty
                    
                    if (guessesLeft < 1)//if the amount of guesses left is less than 1
                    {
                        loseCondition();//run loss condtion.
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a word!", "Error", MessageBoxButtons.OK);
                //if a space is entered this will be shown
            }
        }

        private void wordEntryTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wordOKBtn_Click(this, new EventArgs());
            }
            //On keypress enter run the "wordOKBtn_Click" proccess.
        }

        private void nameCancelBtn_Click(object sender, EventArgs e)
        {
            player.Stop();
            MainMenu openMain = (MainMenu)this.Owner;
            this.Close();
            openMain.Show();
            //If the user wants to leave then they will go back to the main menu.
        }

        private void wordOKBtn_MouseDown(object sender, MouseEventArgs e)
        {
            wordOKBtn.Image = Resources.OKDown;
        }

        private void wordOKBtn_MouseEnter(object sender, EventArgs e)
        {
            wordOKBtn.Image = Resources.OKOver;
        }

        private void wordOKBtn_MouseLeave(object sender, EventArgs e)
        {
            wordOKBtn.Image = Resources.OKBtn;
        }

        private void wordOKBtn_MouseUp(object sender, MouseEventArgs e)
        {
            wordOKBtn.Image = Resources.OKBtn;
        }

        private void nameSetBtn_MouseDown(object sender, MouseEventArgs e)
        {
            nameSetBtn.Image = Resources.OKDown;
        }

        private void nameSetBtn_MouseEnter(object sender, EventArgs e)
        {
            nameSetBtn.Image = Resources.OKOver;
        }

        private void nameSetBtn_MouseLeave(object sender, EventArgs e)
        {
            nameSetBtn.Image = Resources.OKBtn;
        }

        private void nameSetBtn_MouseUp(object sender, MouseEventArgs e)
        {
            nameSetBtn.Image = Resources.OKBtn;
        }

        private void wordCancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            wordCancelBtn.Image = Resources.CancelDown;
        }

        private void wordCancelBtn_MouseEnter(object sender, EventArgs e)
        {
            wordCancelBtn.Image = Resources.CancelOver;
        }

        private void wordCancelBtn_MouseLeave(object sender, EventArgs e)
        {
            wordCancelBtn.Image = Resources.CancelBtn;
        }

        private void wordCancelBtn_MouseUp(object sender, MouseEventArgs e)
        {
            wordCancelBtn.Image = Resources.CancelBtn;
        }

        private void nameCancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            nameCancelBtn.Image = Resources.CancelDown;
        }

        private void nameCancelBtn_MouseEnter(object sender, EventArgs e)
        {
            nameCancelBtn.Image = Resources.CancelOver;
        }

        private void nameCancelBtn_MouseLeave(object sender, EventArgs e)
        {
            nameCancelBtn.Image = Resources.CancelBtn;
        }

        private void music2_Click(object sender, EventArgs e)
        {
            if (musicEnabled)
            {
                player.Stop();
                musicEnabled = false;
                music2.Image = Resources.musicOffBtn;
            }
            else
            {
                player.PlayLooping();
                musicEnabled = true;
                music2.Image = Resources.musicOnBtn;
            }
        }

        private void musicBtn_Click(object sender, EventArgs e)
        {
            if (musicEnabled)
            {
                player.Stop();
                musicEnabled = false;
                musicBtn.Image = Resources.musicOffBtn;
            }
            else
            {
                player.PlayLooping();
                musicEnabled = true;
                musicBtn.Image = Resources.musicOnBtn;
            }
        }

        private void musicBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (musicEnabled)
            {
                musicBtn.Image = Resources.musicOnDown;
            }
            else
            {
                musicBtn.Image = Resources.musicOffDown;
            }
        }

        private void musicBtn_MouseEnter(object sender, EventArgs e)
        {
            if (musicEnabled)
            {
                musicBtn.Image = Resources.musicOnOver;
            }
            else
            {
                musicBtn.Image = Resources.musicOffOver;
            }
        }

        private void musicBtn_MouseLeave(object sender, EventArgs e)
        {
            if (musicEnabled)
            {
                musicBtn.Image = Resources.musicOnBtn;
            }
            else
            {
                musicBtn.Image = Resources.musicOffBtn;
            }

        }

        private void musicBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (musicEnabled)
            {
                musicBtn.Image = Resources.musicOnBtn;
            }
            else
            {
                musicBtn.Image = Resources.musicOffBtn;
            }
        }

        private void music2_MouseDown(object sender, MouseEventArgs e)
        {
            if (musicEnabled)
            {
                music2.Image = Resources.musicOnDown;
            }
            else
            {
                music2.Image = Resources.musicOffDown;
            }
        }

        private void music2_MouseEnter(object sender, EventArgs e)
        {
            if (musicEnabled)
            {
                music2.Image = Resources.musicOnOver;
            }
            else
            {
                music2.Image = Resources.musicOffOver;
            }
        }

        private void music2_MouseLeave(object sender, EventArgs e)
        {
            if (musicEnabled)
            {
                music2.Image = Resources.musicOnBtn;
            }
            else
            {
                music2.Image = Resources.musicOffBtn;
            }

        }

        private void music2_MouseUp(object sender, MouseEventArgs e)
        {
            if (musicEnabled)
            {
                music2.Image = Resources.musicOnBtn;
            }
            else
            {
                music2.Image = Resources.musicOffBtn;
            }
        }

        private void guessLetterBtn_MouseDown(object sender, MouseEventArgs e)
        {
            guessLetterBtn.Image = Resources.guessLetterDown;
        }

        private void guessLetterBtn_MouseEnter(object sender, EventArgs e)
        {
            guessLetterBtn.Image = Resources.guessLetterOver;
        }

        private void guessLetterBtn_MouseLeave(object sender, EventArgs e)
        {
            guessLetterBtn.Image = Resources.guessLetterBtn;
        }

        private void guessLetterBtn_MouseUp(object sender, MouseEventArgs e)
        {
            guessLetterBtn.Image = Resources.guessLetterBtn;
        }

        private void guessWholeWordBtn_MouseDown(object sender, MouseEventArgs e)
        {
            guessWholeWordBtn.Image = Resources.guessWordDown;
        }

        private void guessWholeWordBtn_MouseEnter(object sender, EventArgs e)
        {
            guessWholeWordBtn.Image = Resources.guessWordOver;
        }

        private void guessWholeWordBtn_MouseLeave(object sender, EventArgs e)
        {
            guessWholeWordBtn.Image = Resources.guessWordBtn;
        }

        private void guessWholeWordBtn_MouseUp(object sender, MouseEventArgs e)
        {
            guessWholeWordBtn.Image = Resources.guessWordBtn;
        }

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

        private void nameCancelBtn_MouseUp(object sender, MouseEventArgs e)
        {
            nameCancelBtn.Image = Resources.CancelBtn;
        }

        private void guessLetterBtn_Click(object sender, EventArgs e)
        {
            int i, LLIW;
            Catch = false;

            if(letterEntryTxt.Text == "")
            {
                Catch = true;
                //catching if the entry is null
            }

            if (Catch == false)
            {
                letterEntryTxt.Text = letterEntryTxt.Text.ToLower();
                guess = letterEntryTxt.Text[0];
                
                for (i = word.Length - 1; i > -1; i--)
                /* i is equal to the words length minus one for the index (starts with 0) (if 4 letter word total would be 3)
                 * if i is more than -1 (as index starts at 0) then
                 * Change bool to true, incriment correctGuesses by 1
                 * Remove indexed placeholder and then insert the guess
                 * " " spacing
                 */
                {
                    if (word[i] == guess && spacedLabel.Text[i] == '-')
                    {
                        isLetterCorrect = true;
                        correctGuesses++;

                        spacedLabel.Text = spacedLabel.Text.Remove(i, 1);
                        spacedLabel.Text = spacedLabel.Text.Insert(i, guess.ToString());
                    }
                    else if (word[i] == guess && spacedLabel.Text[i] == guess) //if letter has already been guessed
                    {
                        isLetterCorrect = true;
                        //set flag to true to prevent already guessed letters being considered "incorrect"
                    }

                    if (correctGuesses == word.Length)
                    {
                        //run win condition
                        winCondition();
                        i = -1;
                    }
                }

                if (!isLetterCorrect)
                /*
                 * If this bool isn't set to true the guess is wrong
                 * Minus guessesLeft by 1
                 * Amend label for display
                 */
                {
                    guessesLeft--;

                    displayHangman();

                    if (guessesLeft == 0)
                    {
                        //run loss condtion...
                        guessesLeftLbl.Text = "Guesses left: " + guessesLeft.ToString();
                        incorrectGuessesLst.Items.Add(guess.ToString());
                        loseCondition();
                        
                    }
                    else
                    {
                        guessesLeftLbl.Text = "Guesses left: " + guessesLeft.ToString();
                        incorrectGuessesLst.Items.Add(guess.ToString());
                        //switch statement for animation here...
                    }
                }
                isLetterCorrect = false;
                letterEntryTxt.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a character.", "Error", MessageBoxButtons.OK);
                //if a space is entered this will be shown
            }
            LLIW = word.Length - correctGuesses;
            lettersLeftInWordLbl.Text = "Letters Left: " + LLIW;
        }

        private void wordEntryPnl_Paint(object sender, PaintEventArgs e)
        {
            wordEntryPnl.BringToFront();
        }

        private void winCondition()
        {
            player.Stop();
            SoundPlayer winTheme = new SoundPlayer(Resources.win);
            winTheme.Play();

            //Display a message box stating that the player has won and what the word was then run through the cancel 
            //process to take the user to the main menu.
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Congratulations you guessed the word '" + word + "'!\nWould you like to continue playing?", "You won", buttons);
            if (result == DialogResult.OK)
            {
                if (turn == false)
                {
                    player1Points = player1Points + word.Length;
                }
                else if (turn == true)
                {
                    player2Points = player2Points + word.Length;
                }

                wordEntryTxt.Text = "";

                player.PlayLooping();

                wordEntryPnl.Show();
                correctGuesses = 0;
                if (turn == false)
                {
                    playerTurnLbl.Text = player2 + "'s turn to guess";
                    turn = true;
                }
                else if (turn == true)
                {
                    playerTurnLbl.Text = player1 + "'s turn to guess";
                    turn = false;
                }
            }
            if (result == DialogResult.Cancel)
            {
                player.Stop();
                MainMenu openMain = (MainMenu)this.Owner;
                this.Close();
                openMain.Show();
            }
        }

        private void guessWordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guessWholeWordBtn_Click(this, new EventArgs());
            }
            //When the user presses the enter key run the "guessWholeWordBtn_Click" process
        }

        private void nameSetBtn_Click(object sender, EventArgs e)
        {
            player1 = player1NameTxt.Text;
            player2 = player2NameTxt.Text;

            playerTurnLbl.Text = player1 + "'s turn to guess";

            player1NameLbl.Hide();
            player1NameTxt.Hide();
            player2NameLbl.Hide();
            player2NameTxt.Hide();
            nameSetBtn.Hide();
            nameCancelBtn.Hide();

            enterWordLbl.Show();
            wordEntryTxt.Show();
            wordOKBtn.Show();
            wordCancelBtn.Show();
            playerTurnLbl.Show();
        }

        private void loseCondition()
        {
            player.Stop();
            SoundPlayer loseTheme = new SoundPlayer(Resources.lose);
            loseTheme.Play();

            //Display a message box stating that the player has lost  and what the word was then run through the cancel
            // process to take the user to the main menu.
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("You lost, the word was '" + word + "'\nWould you like to continue playing?", "You lost", buttons);
            if (result == DialogResult.OK)
            {
                if (turn == false)
                {
                    player1Points = player1Points - (word.Length / 2);
                }
                else if (turn == true)
                {
                    player2Points = player2Points - (word.Length / 2);
                }
                wordEntryTxt.Text = "";

                player.PlayLooping();

                wordEntryPnl.Show();
                correctGuesses = 0;
                if (turn == false)
                {
                    playerTurnLbl.Text = player2 + "'s turn to guess";
                    turn = true;
                }
                else if (turn == true)
                {
                    playerTurnLbl.Text = player1 + "'s turn to guess";
                    turn = false;
                }
            }
            if (result == DialogResult.Cancel)
            {
                player.Stop();
                MainMenu openMain = (MainMenu)this.Owner;
                this.Close();
                openMain.Show();
            }
        }

        private void displayHangman()
        {
            switch(guessesLeft)
            {
                case 0:
                    hangmanDisplayPic.Image = Resources._10;
                    break;
                case 1:
                    hangmanDisplayPic.Image = Resources._9;
                    break;
                case 2:
                    hangmanDisplayPic.Image = Resources._8;
                    break;
                case 3:
                    hangmanDisplayPic.Image = Resources._7;
                    break;
                case 4:
                    hangmanDisplayPic.Image = Resources._6;
                    break;
                case 5:
                    hangmanDisplayPic.Image = Resources._5;
                    break;
                case 6:
                    hangmanDisplayPic.Image = Resources._4;
                    break;
                case 7:
                    hangmanDisplayPic.Image = Resources._3;
                    break;
                case 8:
                    hangmanDisplayPic.Image = Resources._2;
                    break;
                case 9:
                    hangmanDisplayPic.Image = Resources._1;
                    break;
                case 10:
                    hangmanDisplayPic.Image = Resources._0;
                    break;
            }
            /*
             * This display goes from 10 down to 0.
             * So if there are 10 guesses left then the display will be empty.
             * It will then progress through the animations the lower the guesses left
             */
        }
    }
}
