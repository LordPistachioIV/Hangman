namespace Hangman
{
    partial class HangmanSingle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lettersInWordLbl = new System.Windows.Forms.Label();
            this.guessWordLbl = new System.Windows.Forms.Label();
            this.guessWordTxt = new System.Windows.Forms.TextBox();
            this.incorrectGuessesLst = new System.Windows.Forms.ListBox();
            this.usedWordsTitleLbl = new System.Windows.Forms.Label();
            this.spacedLabel = new System.Windows.Forms.Label();
            this.guessesLeftLbl = new System.Windows.Forms.Label();
            this.difficultyCancelBtn = new System.Windows.Forms.Button();
            this.difficultyPnl = new System.Windows.Forms.Panel();
            this.musicBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.mediumBtn = new System.Windows.Forms.Button();
            this.easyBtn = new System.Windows.Forms.Button();
            this.selectDifficultyLbl = new System.Windows.Forms.Label();
            this.letterEntryTxt = new System.Windows.Forms.TextBox();
            this.letterEntryLbl = new System.Windows.Forms.Label();
            this.genNewWordBtn = new System.Windows.Forms.Button();
            this.changeDifficultyBtn = new System.Windows.Forms.Button();
            this.hangmanDisplayPic = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.guessWholeWordBtn = new System.Windows.Forms.Button();
            this.guessLetterBtn = new System.Windows.Forms.Button();
            this.music2 = new System.Windows.Forms.Button();
            this.lettersLeftInWordLbl = new System.Windows.Forms.Label();
            this.difficultyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanDisplayPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lettersInWordLbl
            // 
            this.lettersInWordLbl.AutoSize = true;
            this.lettersInWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.lettersInWordLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettersInWordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lettersInWordLbl.Location = new System.Drawing.Point(12, 358);
            this.lettersInWordLbl.Name = "lettersInWordLbl";
            this.lettersInWordLbl.Size = new System.Drawing.Size(56, 37);
            this.lettersInWordLbl.TabIndex = 49;
            this.lettersInWordLbl.Text = "LIW";
            // 
            // guessWordLbl
            // 
            this.guessWordLbl.AutoSize = true;
            this.guessWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.guessWordLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessWordLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessWordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.guessWordLbl.Location = new System.Drawing.Point(320, 68);
            this.guessWordLbl.Name = "guessWordLbl";
            this.guessWordLbl.Size = new System.Drawing.Size(72, 37);
            this.guessWordLbl.TabIndex = 47;
            this.guessWordLbl.Text = "Word:";
            // 
            // guessWordTxt
            // 
            this.guessWordTxt.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessWordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.guessWordTxt.Location = new System.Drawing.Point(409, 69);
            this.guessWordTxt.MaxLength = 20;
            this.guessWordTxt.Name = "guessWordTxt";
            this.guessWordTxt.Size = new System.Drawing.Size(149, 28);
            this.guessWordTxt.TabIndex = 46;
            this.guessWordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessWordTxt_KeyDown);
            // 
            // incorrectGuessesLst
            // 
            this.incorrectGuessesLst.BackColor = System.Drawing.Color.White;
            this.incorrectGuessesLst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incorrectGuessesLst.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectGuessesLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.incorrectGuessesLst.FormattingEnabled = true;
            this.incorrectGuessesLst.ItemHeight = 20;
            this.incorrectGuessesLst.Location = new System.Drawing.Point(409, 175);
            this.incorrectGuessesLst.Name = "incorrectGuessesLst";
            this.incorrectGuessesLst.Size = new System.Drawing.Size(50, 182);
            this.incorrectGuessesLst.TabIndex = 44;
            // 
            // usedWordsTitleLbl
            // 
            this.usedWordsTitleLbl.AutoSize = true;
            this.usedWordsTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.usedWordsTitleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usedWordsTitleLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usedWordsTitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.usedWordsTitleLbl.Location = new System.Drawing.Point(217, 176);
            this.usedWordsTitleLbl.Name = "usedWordsTitleLbl";
            this.usedWordsTitleLbl.Size = new System.Drawing.Size(186, 37);
            this.usedWordsTitleLbl.TabIndex = 43;
            this.usedWordsTitleLbl.Text = "Incorrect guesses:";
            // 
            // spacedLabel
            // 
            this.spacedLabel.AutoSize = true;
            this.spacedLabel.BackColor = System.Drawing.Color.Transparent;
            this.spacedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spacedLabel.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spacedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.spacedLabel.Location = new System.Drawing.Point(46, 294);
            this.spacedLabel.Name = "spacedLabel";
            this.spacedLabel.Size = new System.Drawing.Size(88, 53);
            this.spacedLabel.TabIndex = 42;
            this.spacedLabel.Text = "     ";
            // 
            // guessesLeftLbl
            // 
            this.guessesLeftLbl.AutoSize = true;
            this.guessesLeftLbl.BackColor = System.Drawing.Color.Transparent;
            this.guessesLeftLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessesLeftLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessesLeftLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.guessesLeftLbl.Location = new System.Drawing.Point(264, 123);
            this.guessesLeftLbl.Name = "guessesLeftLbl";
            this.guessesLeftLbl.Size = new System.Drawing.Size(139, 37);
            this.guessesLeftLbl.TabIndex = 41;
            this.guessesLeftLbl.Text = "Guesses left:";
            // 
            // difficultyCancelBtn
            // 
            this.difficultyCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.difficultyCancelBtn.FlatAppearance.BorderSize = 0;
            this.difficultyCancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.difficultyCancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.difficultyCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difficultyCancelBtn.Image = global::Hangman.Properties.Resources.exitBtn2;
            this.difficultyCancelBtn.Location = new System.Drawing.Point(688, 388);
            this.difficultyCancelBtn.Name = "difficultyCancelBtn";
            this.difficultyCancelBtn.Size = new System.Drawing.Size(100, 50);
            this.difficultyCancelBtn.TabIndex = 3;
            this.difficultyCancelBtn.UseVisualStyleBackColor = false;
            this.difficultyCancelBtn.Click += new System.EventHandler(this.difficultyCancelBtn_Click);
            this.difficultyCancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.difficultyCancelBtn_MouseDown);
            this.difficultyCancelBtn.MouseEnter += new System.EventHandler(this.difficultyCancelBtn_MouseEnter);
            this.difficultyCancelBtn.MouseLeave += new System.EventHandler(this.difficultyCancelBtn_MouseLeave);
            this.difficultyCancelBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.difficultyCancelBtn_MouseUp);
            // 
            // difficultyPnl
            // 
            this.difficultyPnl.BackColor = System.Drawing.SystemColors.Control;
            this.difficultyPnl.BackgroundImage = global::Hangman.Properties.Resources.gameBack;
            this.difficultyPnl.Controls.Add(this.musicBtn);
            this.difficultyPnl.Controls.Add(this.hardBtn);
            this.difficultyPnl.Controls.Add(this.mediumBtn);
            this.difficultyPnl.Controls.Add(this.easyBtn);
            this.difficultyPnl.Controls.Add(this.difficultyCancelBtn);
            this.difficultyPnl.Controls.Add(this.selectDifficultyLbl);
            this.difficultyPnl.Location = new System.Drawing.Point(0, 0);
            this.difficultyPnl.Name = "difficultyPnl";
            this.difficultyPnl.Size = new System.Drawing.Size(800, 450);
            this.difficultyPnl.TabIndex = 39;
            this.difficultyPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.difficultyPnl_Paint);
            // 
            // musicBtn
            // 
            this.musicBtn.BackColor = System.Drawing.Color.Transparent;
            this.musicBtn.FlatAppearance.BorderSize = 0;
            this.musicBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.musicBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.musicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicBtn.Image = global::Hangman.Properties.Resources.musicOnBtn;
            this.musicBtn.Location = new System.Drawing.Point(738, 12);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Size = new System.Drawing.Size(50, 50);
            this.musicBtn.TabIndex = 7;
            this.musicBtn.UseVisualStyleBackColor = false;
            this.musicBtn.Click += new System.EventHandler(this.musicBtn_Click);
            this.musicBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.musicBtn_MouseDown);
            this.musicBtn.MouseEnter += new System.EventHandler(this.musicBtn_MouseEnter);
            this.musicBtn.MouseLeave += new System.EventHandler(this.musicBtn_MouseLeave);
            this.musicBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.musicBtn_MouseUp);
            // 
            // hardBtn
            // 
            this.hardBtn.BackColor = System.Drawing.Color.Transparent;
            this.hardBtn.FlatAppearance.BorderSize = 0;
            this.hardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardBtn.Image = global::Hangman.Properties.Resources.hard;
            this.hardBtn.Location = new System.Drawing.Point(327, 245);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(150, 50);
            this.hardBtn.TabIndex = 6;
            this.hardBtn.UseVisualStyleBackColor = false;
            this.hardBtn.Click += new System.EventHandler(this.hardButton_Click);
            this.hardBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hardBtn_MouseDown);
            this.hardBtn.MouseEnter += new System.EventHandler(this.hardBtn_MouseEnter);
            this.hardBtn.MouseLeave += new System.EventHandler(this.hardBtn_MouseLeave);
            this.hardBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hardBtn_MouseUp);
            // 
            // mediumBtn
            // 
            this.mediumBtn.BackColor = System.Drawing.Color.Transparent;
            this.mediumBtn.FlatAppearance.BorderSize = 0;
            this.mediumBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mediumBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mediumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumBtn.Image = global::Hangman.Properties.Resources.medium;
            this.mediumBtn.Location = new System.Drawing.Point(327, 166);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(150, 50);
            this.mediumBtn.TabIndex = 5;
            this.mediumBtn.UseVisualStyleBackColor = false;
            this.mediumBtn.Click += new System.EventHandler(this.mediumBtn_Click);
            this.mediumBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mediumBtn_MouseDown);
            this.mediumBtn.MouseEnter += new System.EventHandler(this.mediumBtn_MouseEnter);
            this.mediumBtn.MouseLeave += new System.EventHandler(this.mediumBtn_MouseLeave);
            this.mediumBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mediumBtn_MouseUp);
            // 
            // easyBtn
            // 
            this.easyBtn.BackColor = System.Drawing.Color.Transparent;
            this.easyBtn.FlatAppearance.BorderSize = 0;
            this.easyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.easyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.easyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyBtn.Image = global::Hangman.Properties.Resources.easy;
            this.easyBtn.Location = new System.Drawing.Point(327, 89);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(150, 50);
            this.easyBtn.TabIndex = 4;
            this.easyBtn.UseVisualStyleBackColor = false;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            this.easyBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.easyBtn_MouseDown);
            this.easyBtn.MouseEnter += new System.EventHandler(this.easyBtn_MouseEnter);
            this.easyBtn.MouseLeave += new System.EventHandler(this.easyBtn_MouseLeave);
            this.easyBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.easyBtn_MouseUp);
            // 
            // selectDifficultyLbl
            // 
            this.selectDifficultyLbl.AutoSize = true;
            this.selectDifficultyLbl.BackColor = System.Drawing.Color.Transparent;
            this.selectDifficultyLbl.Font = new System.Drawing.Font("Freestyle Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDifficultyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.selectDifficultyLbl.Location = new System.Drawing.Point(290, 17);
            this.selectDifficultyLbl.Name = "selectDifficultyLbl";
            this.selectDifficultyLbl.Size = new System.Drawing.Size(226, 35);
            this.selectDifficultyLbl.TabIndex = 0;
            this.selectDifficultyLbl.Text = "SELECT DIFFICULTY:";
            // 
            // letterEntryTxt
            // 
            this.letterEntryTxt.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterEntryTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.letterEntryTxt.Location = new System.Drawing.Point(409, 15);
            this.letterEntryTxt.MaxLength = 1;
            this.letterEntryTxt.Name = "letterEntryTxt";
            this.letterEntryTxt.Size = new System.Drawing.Size(40, 33);
            this.letterEntryTxt.TabIndex = 38;
            this.letterEntryTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.letterEntryTxt_KeyDown);
            // 
            // letterEntryLbl
            // 
            this.letterEntryLbl.AutoSize = true;
            this.letterEntryLbl.BackColor = System.Drawing.Color.Transparent;
            this.letterEntryLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterEntryLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterEntryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.letterEntryLbl.Location = new System.Drawing.Point(320, 16);
            this.letterEntryLbl.Name = "letterEntryLbl";
            this.letterEntryLbl.Size = new System.Drawing.Size(83, 37);
            this.letterEntryLbl.TabIndex = 37;
            this.letterEntryLbl.Text = "Letter:";
            // 
            // genNewWordBtn
            // 
            this.genNewWordBtn.BackColor = System.Drawing.Color.Transparent;
            this.genNewWordBtn.FlatAppearance.BorderSize = 0;
            this.genNewWordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.genNewWordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.genNewWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genNewWordBtn.Image = global::Hangman.Properties.Resources.newWordBtn;
            this.genNewWordBtn.Location = new System.Drawing.Point(376, 377);
            this.genNewWordBtn.Name = "genNewWordBtn";
            this.genNewWordBtn.Size = new System.Drawing.Size(150, 50);
            this.genNewWordBtn.TabIndex = 51;
            this.genNewWordBtn.UseVisualStyleBackColor = false;
            this.genNewWordBtn.Click += new System.EventHandler(this.genNewWordBtn_Click);
            this.genNewWordBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.genNewWordBtn_MouseDown);
            this.genNewWordBtn.MouseEnter += new System.EventHandler(this.genNewWordBtn_MouseEnter);
            this.genNewWordBtn.MouseLeave += new System.EventHandler(this.genNewWordBtn_MouseLeave);
            this.genNewWordBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.genNewWordBtn_MouseUp);
            // 
            // changeDifficultyBtn
            // 
            this.changeDifficultyBtn.BackColor = System.Drawing.Color.Transparent;
            this.changeDifficultyBtn.FlatAppearance.BorderSize = 0;
            this.changeDifficultyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeDifficultyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changeDifficultyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDifficultyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDifficultyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeDifficultyBtn.Image = global::Hangman.Properties.Resources.changeDifficultyBtn;
            this.changeDifficultyBtn.Location = new System.Drawing.Point(532, 374);
            this.changeDifficultyBtn.Name = "changeDifficultyBtn";
            this.changeDifficultyBtn.Size = new System.Drawing.Size(150, 50);
            this.changeDifficultyBtn.TabIndex = 50;
            this.changeDifficultyBtn.UseVisualStyleBackColor = false;
            this.changeDifficultyBtn.Click += new System.EventHandler(this.changeDifficultyBtn_Click);
            this.changeDifficultyBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changeDifficultyBtn_MouseDown);
            this.changeDifficultyBtn.MouseEnter += new System.EventHandler(this.changeDifficultyBtn_MouseEnter);
            this.changeDifficultyBtn.MouseLeave += new System.EventHandler(this.changeDifficultyBtn_MouseLeave);
            this.changeDifficultyBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.changeDifficultyBtn_MouseUp);
            // 
            // hangmanDisplayPic
            // 
            this.hangmanDisplayPic.BackColor = System.Drawing.Color.Transparent;
            this.hangmanDisplayPic.Location = new System.Drawing.Point(5, 5);
            this.hangmanDisplayPic.Name = "hangmanDisplayPic";
            this.hangmanDisplayPic.Size = new System.Drawing.Size(200, 225);
            this.hangmanDisplayPic.TabIndex = 48;
            this.hangmanDisplayPic.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = global::Hangman.Properties.Resources.exitBtn2;
            this.exitBtn.Location = new System.Drawing.Point(688, 376);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 50);
            this.exitBtn.TabIndex = 36;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseDown);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            this.exitBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseUp);
            // 
            // guessWholeWordBtn
            // 
            this.guessWholeWordBtn.BackColor = System.Drawing.Color.Transparent;
            this.guessWholeWordBtn.FlatAppearance.BorderSize = 0;
            this.guessWholeWordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.guessWholeWordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.guessWholeWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessWholeWordBtn.Image = global::Hangman.Properties.Resources.guessWordBtn;
            this.guessWholeWordBtn.Location = new System.Drawing.Point(587, 78);
            this.guessWholeWordBtn.Name = "guessWholeWordBtn";
            this.guessWholeWordBtn.Size = new System.Drawing.Size(100, 25);
            this.guessWholeWordBtn.TabIndex = 45;
            this.guessWholeWordBtn.UseVisualStyleBackColor = false;
            this.guessWholeWordBtn.Click += new System.EventHandler(this.guessWholeWordBtn_Click);
            this.guessWholeWordBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guessWholeWordBtn_MouseDown);
            this.guessWholeWordBtn.MouseEnter += new System.EventHandler(this.guessWholeWordBtn_MouseEnter);
            this.guessWholeWordBtn.MouseLeave += new System.EventHandler(this.guessWholeWordBtn_MouseLeave);
            this.guessWholeWordBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guessWholeWordBtn_MouseUp);
            // 
            // guessLetterBtn
            // 
            this.guessLetterBtn.BackColor = System.Drawing.Color.Transparent;
            this.guessLetterBtn.FlatAppearance.BorderSize = 0;
            this.guessLetterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.guessLetterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.guessLetterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessLetterBtn.Image = global::Hangman.Properties.Resources.guessLetterBtn;
            this.guessLetterBtn.Location = new System.Drawing.Point(587, 26);
            this.guessLetterBtn.Name = "guessLetterBtn";
            this.guessLetterBtn.Size = new System.Drawing.Size(100, 25);
            this.guessLetterBtn.TabIndex = 40;
            this.guessLetterBtn.UseVisualStyleBackColor = false;
            this.guessLetterBtn.Click += new System.EventHandler(this.guessLetterBtn_Click);
            this.guessLetterBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guessLetterBtn_MouseDown);
            this.guessLetterBtn.MouseEnter += new System.EventHandler(this.guessLetterBtn_MouseEnter);
            this.guessLetterBtn.MouseLeave += new System.EventHandler(this.guessLetterBtn_MouseLeave);
            this.guessLetterBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guessLetterBtn_MouseUp);
            // 
            // music2
            // 
            this.music2.BackColor = System.Drawing.Color.Transparent;
            this.music2.FlatAppearance.BorderSize = 0;
            this.music2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.music2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.music2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.music2.Image = global::Hangman.Properties.Resources.musicOnBtn;
            this.music2.Location = new System.Drawing.Point(738, 12);
            this.music2.Name = "music2";
            this.music2.Size = new System.Drawing.Size(50, 50);
            this.music2.TabIndex = 52;
            this.music2.UseVisualStyleBackColor = false;
            this.music2.Click += new System.EventHandler(this.music2_Click);
            this.music2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.music2_MouseDown);
            this.music2.MouseEnter += new System.EventHandler(this.music2_MouseEnter);
            this.music2.MouseLeave += new System.EventHandler(this.music2_MouseLeave);
            this.music2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.music2_MouseUp);
            // 
            // lettersLeftInWordLbl
            // 
            this.lettersLeftInWordLbl.AutoSize = true;
            this.lettersLeftInWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.lettersLeftInWordLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettersLeftInWordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lettersLeftInWordLbl.Location = new System.Drawing.Point(12, 396);
            this.lettersLeftInWordLbl.Name = "lettersLeftInWordLbl";
            this.lettersLeftInWordLbl.Size = new System.Drawing.Size(39, 37);
            this.lettersLeftInWordLbl.TabIndex = 53;
            this.lettersLeftInWordLbl.Text = "LL";
            // 
            // HangmanSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman.Properties.Resources.gameBack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lettersLeftInWordLbl);
            this.Controls.Add(this.music2);
            this.Controls.Add(this.difficultyPnl);
            this.Controls.Add(this.genNewWordBtn);
            this.Controls.Add(this.changeDifficultyBtn);
            this.Controls.Add(this.lettersInWordLbl);
            this.Controls.Add(this.hangmanDisplayPic);
            this.Controls.Add(this.guessWordTxt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.incorrectGuessesLst);
            this.Controls.Add(this.guessWholeWordBtn);
            this.Controls.Add(this.guessWordLbl);
            this.Controls.Add(this.spacedLabel);
            this.Controls.Add(this.usedWordsTitleLbl);
            this.Controls.Add(this.guessesLeftLbl);
            this.Controls.Add(this.guessLetterBtn);
            this.Controls.Add(this.letterEntryTxt);
            this.Controls.Add(this.letterEntryLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HangmanSingle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.HangmanSingle_Load);
            this.difficultyPnl.ResumeLayout(false);
            this.difficultyPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanDisplayPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lettersInWordLbl;
        private System.Windows.Forms.PictureBox hangmanDisplayPic;
        private System.Windows.Forms.Label guessWordLbl;
        private System.Windows.Forms.TextBox guessWordTxt;
        private System.Windows.Forms.Button guessWholeWordBtn;
        private System.Windows.Forms.ListBox incorrectGuessesLst;
        private System.Windows.Forms.Label usedWordsTitleLbl;
        private System.Windows.Forms.Label spacedLabel;
        private System.Windows.Forms.Label guessesLeftLbl;
        private System.Windows.Forms.Button guessLetterBtn;
        private System.Windows.Forms.Button difficultyCancelBtn;
        private System.Windows.Forms.Panel difficultyPnl;
        private System.Windows.Forms.Label selectDifficultyLbl;
        private System.Windows.Forms.TextBox letterEntryTxt;
        private System.Windows.Forms.Label letterEntryLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Button mediumBtn;
        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button changeDifficultyBtn;
        private System.Windows.Forms.Button genNewWordBtn;
        private System.Windows.Forms.Button musicBtn;
        private System.Windows.Forms.Button music2;
        private System.Windows.Forms.Label lettersLeftInWordLbl;
    }
}