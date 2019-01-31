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
    public partial class HangmanSingle : Form
    {
        string word;
        char guess;
        int guessesLeft = 10, correctGuesses = 0,
            difficultySelected = 0;
        bool isLetterCorrect = false, Catch = false, musicEnabled = true;
        SoundPlayer player = new SoundPlayer(Resources.main); //initalise soundplayer with BGM

        /* Run down of what each variable is used for
        * 
        * string word | this will be holding the word of which is entered for anothe person to guess.
        * char guess | this is used when checking the word against what the player has guessed to be in the word
        * int guessesLeft = 10 | this is used for the display of how many guesses are left and the hangman animation
        * also used within loss condtions
        * int correctGuesses = 0 | this is used to compare against "word" and for win condtions
        * int difficultySelected | changed when difficulty is selected; 1 = easy, 2 = medium, 3 = hard
        * bool isLetterCorrect = false | this is used to check whether the guess made is correct or not
        * bool Catch = false | this is used to catch the process if a null entry has been made
        */

        private void easyBtn_Click(object sender, EventArgs e)
        {
            difficultySelected = 1; //set difficulty to 1 (easy)
            generateWord(); //get new random word
            difficultyPnl.Hide(); //hide panel
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            difficultySelected = 2; //set difficulty to 2 (medium)
            generateWord(); //get new random word
            difficultyPnl.Hide(); //hide panel
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            difficultySelected = 3; //set difficulty to 3 (hard)
            generateWord(); //get new random word
            difficultyPnl.Hide(); //hide panel
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Are you sure you would like to end this game?", "End game", buttons);
            if (result == DialogResult.OK)
            {
                player.Stop();
                MainMenu openMain = (MainMenu)this.Owner;
                this.Close();
                openMain.Show();
            }
            //exits the program with a confirmation message.
        }

        private void difficultyPnl_Paint(object sender, PaintEventArgs e)
        {
            difficultyPnl.BringToFront();
        }

        private void difficultyCancelBtn_Click(object sender, EventArgs e)
        {
            player.Stop();
            MainMenu openMain = (MainMenu)this.Owner;
            this.Close();
            openMain.Show();
            //If the user wants to leave then they will go back to the main menu.
        }

        private void letterEntryTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guessLetterBtn_Click(this, new EventArgs());
            }
            //On keypress enter run the "guessLetterBtn" proccess.
        }

        private void guessLetterBtn_Click(object sender, EventArgs e)
        {
            int i, LLIW;
            Catch = false;

            if (letterEntryTxt.Text == "")
            {
                Catch = true;
                //catching if the entry is null
            }

            if (Catch == false)
            {
                guess = letterEntryTxt.Text.ToUpper()[0];

                for (i = word.Length - 1; i > -1; i--)
                /* i is equal to the words length minus one for the index (starts with 0) (if 4 letter word total would be 3)
                 * if i is more than -1 (as index starts at 0) then
                 * Change bool to true, incriment correctGuesses by 1
                 * Remove indexed placeholder and then insert the guess
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

        private void guessWordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guessWholeWordBtn_Click(this, new EventArgs());
            }
            //When the user presses the enter key run the "guessWholeWordBtn_Click" process
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
                if (guessWordTxt.Text.ToUpper() == word)//if the whole word guessed matches the word
                {
                    winCondition();//run win condtion
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

        public HangmanSingle()
        {
            InitializeComponent();
        }

        private void HangmanSingle_Load(object sender, EventArgs e)
        {
            if (musicEnabled)
            {
                musicBtn.Image = Resources.musicOnBtn;
            }
            else
            {
                musicBtn.Image = Resources.musicOffBtn;
            }
            guessesLeftLbl.Text = "Guesses left: " + guessesLeft.ToString(); //display guesses left

            player.PlayLooping();
        }

        private void generateWord() //word generation
        {
            int lengthMin = 0, lengthMax = 0,
                lengthToCheck = 0;
            //lower and upper length limits; length to check against dictionary strings

            Random RND = new Random(); //used to invoke Random class for generation
            string tempWord; //hold word from dictionary to check against length limits

            switch(difficultySelected) //get difficulty number
            {
                case 1: //if easy
                    lengthMin = 1; //set word length limits
                    lengthMax = 6;
                    break;

                case 2: //if medium
                    lengthMin = 7;
                    lengthMax = 13;
                    break;

                case 3: //if hard
                    lengthMin = 14;
                    lengthMax = 20;
                    break;
            }

            lengthToCheck = RND.Next(lengthMin, lengthMax);
            //the length of the new word is a random number between the lower and upper bounds (set by difficulty)

            int linesToSkip; //lines in dictionary file to skip when searching for a new word
            List<string> wordList = File.ReadAllLines(@"../../words.txt").ToList();
            //add each line of file to list for proper indexing

            do
            {
                linesToSkip = RND.Next(0, wordList.Count());
                //generate random line index to offset when searching through dictionary
                tempWord = wordList.Skip(linesToSkip).First();
                //skip through words at random index

                if(tempWord.Length >= lengthMin && tempWord.Length <= lengthMax)
                {
                    word = tempWord;
                }
            }
            while (word != tempWord); //keep finding new word until it fits in difficulty bounds

            spacedLabel.Text = "";
            
            lettersInWordLbl.Text = "Letters: " + word.Length.ToString();
            lettersLeftInWordLbl.Text = "Letters Left: " + word.Length.ToString();
            //setting up display for how many letters are in the word being guessed
            //" " spacing the word

            foreach (char c in word)
            {
                spacedLabel.Text = spacedLabel.Text + "-";
            }
            //Setting up the label that will display the correct letters in the word

            guessesLeft = 10;
            correctGuesses = 0;
            guessesLeftLbl.Text = "Guesses left: " + guessesLeft.ToString();
            incorrectGuessesLst.Items.Clear();

            if (musicEnabled)
            {
                music2.Image = Resources.musicOnBtn;
            }
            else
            {
                music2.Image = Resources.musicOffBtn;
            }

            displayHangman();
        }

        private void genNewWordBtn_Click(object sender, EventArgs e)
        {
            generateWord();
        }

        private void changeDifficultyBtn_Click(object sender, EventArgs e)
        {
            difficultyPnl.Show();
        }

        private void displayHangman()
        {
            switch (guessesLeft)
            {
                case 0:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._10;
                    break;
                case 1:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._9;
                    break;
                case 2:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._8;
                    break;
                case 3:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._7;
                    break;
                case 4:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._6;
                    break;
                case 5:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._5;
                    break;
                case 6:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._4;
                    break;
                case 7:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._3;
                    break;
                case 8:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._2;
                    break;
                case 9:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._1;
                    break;
                case 10:
                    hangmanDisplayPic.Image = Hangman.Properties.Resources._0;
                    break;
            }
            /*
             * This display goes from 10 down to 0.
             * So if there are 10 guesses left then the display will be empty.
             * It will then progress through the animations the lower the guesses left
             */
        }

        private void winCondition()
        {
            player.Stop();
            SoundPlayer winTheme = new SoundPlayer(Resources.win);
            winTheme.Play();

            MessageBox.Show("Congratulations, you guessed the word '" + word + "'!", "You won", MessageBoxButtons.OK);

            player.PlayLooping();
            generateWord();
            guessesLeft = 10;
            correctGuesses = 0;
            incorrectGuessesLst.Items.Clear();
            displayHangman();

            //difficultyCancelBtn_Click(this, new EventArgs());
            //Display a message box stating that the player has won and what the word was then run through the cancel 
            //process to take the user to the main menu.
        }

        private void loseCondition()
        {
            player.Stop();
            SoundPlayer loseTheme = new SoundPlayer(Resources.lose);
            loseTheme.Play();

            MessageBox.Show("You lost, the word was '" + word + "'", "You lost", MessageBoxButtons.OK);

            player.PlayLooping();

            generateWord(); //generate new word
            guessesLeft = 10; //restore guesses
            correctGuesses = 0; //reset correct guesses
            incorrectGuessesLst.Items.Clear(); //clear guessed letters
            displayHangman(); //reset hangman
            //Display a message box stating that the player has lost and what the word was
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

        private void easyBtn_MouseDown(object sender, MouseEventArgs e)
        {
            easyBtn.Image = Resources.easyDown;
        }

        private void easyBtn_MouseEnter(object sender, EventArgs e)
        {
            easyBtn.Image = Resources.easyOver;
        }

        private void easyBtn_MouseLeave(object sender, EventArgs e)
        {
            easyBtn.Image = Resources.easy;
        }

        private void easyBtn_MouseUp(object sender, MouseEventArgs e)
        {
            easyBtn.Image = Resources.easy;
        }

        private void mediumBtn_MouseDown(object sender, MouseEventArgs e)
        {
            mediumBtn.Image = Resources.mediumDown;
        }

        private void mediumBtn_MouseEnter(object sender, EventArgs e)
        {
            mediumBtn.Image = Resources.mediumOver;
        }

        private void mediumBtn_MouseLeave(object sender, EventArgs e)
        {
            mediumBtn.Image = Resources.medium;
        }

        private void mediumBtn_MouseUp(object sender, MouseEventArgs e)
        {
            mediumBtn.Image = Resources.medium;
        }

        private void hardBtn_MouseDown(object sender, MouseEventArgs e)
        {
            hardBtn.Image = Resources.hardDown;
        }

        private void hardBtn_MouseEnter(object sender, EventArgs e)
        {
            hardBtn.Image = Resources.hardOver;
        }

        private void hardBtn_MouseLeave(object sender, EventArgs e)
        {
            hardBtn.Image = Resources.hard;
        }

        private void hardBtn_MouseUp(object sender, MouseEventArgs e)
        {
            hardBtn.Image = Resources.hard;
        }

        private void difficultyCancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            difficultyCancelBtn.Image = Resources.exitBtn2Down;
        }

        private void difficultyCancelBtn_MouseEnter(object sender, EventArgs e)
        {
            difficultyCancelBtn.Image = Resources.exitBtn2Over;
        }

        private void difficultyCancelBtn_MouseLeave(object sender, EventArgs e)
        {
            difficultyCancelBtn.Image = Resources.exitBtn2;
        }

        private void difficultyCancelBtn_MouseUp(object sender, MouseEventArgs e)
        {
            difficultyCancelBtn.Image = Resources.exitBtn2;
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

        private void changeDifficultyBtn_MouseDown(object sender, MouseEventArgs e)
        {
            changeDifficultyBtn.Image = Resources.changeDifficultyDown;
        }

        private void changeDifficultyBtn_MouseEnter(object sender, EventArgs e)
        {
            changeDifficultyBtn.Image = Resources.changeDifficultyOver;
        }

        private void changeDifficultyBtn_MouseLeave(object sender, EventArgs e)
        {
            changeDifficultyBtn.Image = Resources.changeDifficultyBtn;
        }

        private void changeDifficultyBtn_MouseUp(object sender, MouseEventArgs e)
        {
            changeDifficultyBtn.Image = Resources.changeDifficultyBtn;
        }

        private void genNewWordBtn_MouseDown(object sender, MouseEventArgs e)
        {
            genNewWordBtn.Image = Resources.newWordDown;
        }

        private void genNewWordBtn_MouseEnter(object sender, EventArgs e)
        {
            genNewWordBtn.Image = Resources.newWordOver;
        }

        private void genNewWordBtn_MouseLeave(object sender, EventArgs e)
        {
            genNewWordBtn.Image = Resources.newWordBtn;
        }

        private void genNewWordBtn_MouseUp(object sender, MouseEventArgs e)
        {
            genNewWordBtn.Image = Resources.newWordBtn;
        }
    }
}
