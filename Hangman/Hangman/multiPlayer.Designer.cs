namespace Hangman
{
    partial class HangmanMulti
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.letterEntryLbl = new System.Windows.Forms.Label();
            this.letterEntryTxt = new System.Windows.Forms.TextBox();
            this.wordEntryPnl = new System.Windows.Forms.Panel();
            this.musicBtn = new System.Windows.Forms.Button();
            this.nameCancelBtn = new System.Windows.Forms.Button();
            this.nameSetBtn = new System.Windows.Forms.Button();
            this.player2NameTxt = new System.Windows.Forms.TextBox();
            this.player1NameTxt = new System.Windows.Forms.TextBox();
            this.player2NameLbl = new System.Windows.Forms.Label();
            this.player1NameLbl = new System.Windows.Forms.Label();
            this.playerTurnLbl = new System.Windows.Forms.Label();
            this.wordCancelBtn = new System.Windows.Forms.Button();
            this.wordOKBtn = new System.Windows.Forms.Button();
            this.wordEntryTxt = new System.Windows.Forms.TextBox();
            this.enterWordLbl = new System.Windows.Forms.Label();
            this.guessLetterBtn = new System.Windows.Forms.Button();
            this.guessesLeftLbl = new System.Windows.Forms.Label();
            this.spacedLabel = new System.Windows.Forms.Label();
            this.usedWordsTitleLbl = new System.Windows.Forms.Label();
            this.incorrectGuessesLst = new System.Windows.Forms.ListBox();
            this.guessWholeWordBtn = new System.Windows.Forms.Button();
            this.guessWordTxt = new System.Windows.Forms.TextBox();
            this.guessWordLbl = new System.Windows.Forms.Label();
            this.hangmanDisplayPic = new System.Windows.Forms.PictureBox();
            this.lettersInWordLbl = new System.Windows.Forms.Label();
            this.player1PointsLbl = new System.Windows.Forms.Label();
            this.player2PointsLbl = new System.Windows.Forms.Label();
            this.music2 = new System.Windows.Forms.Button();
            this.lettersLeftInWordLbl = new System.Windows.Forms.Label();
            this.wordEntryPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanDisplayPic)).BeginInit();
            this.SuspendLayout();
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
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseDown);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            this.exitBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseUp);
            // 
            // letterEntryLbl
            // 
            this.letterEntryLbl.AutoSize = true;
            this.letterEntryLbl.BackColor = System.Drawing.Color.Transparent;
            this.letterEntryLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterEntryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.letterEntryLbl.Location = new System.Drawing.Point(320, 16);
            this.letterEntryLbl.Name = "letterEntryLbl";
            this.letterEntryLbl.Size = new System.Drawing.Size(83, 37);
            this.letterEntryLbl.TabIndex = 1;
            this.letterEntryLbl.Text = "Letter:";
            // 
            // letterEntryTxt
            // 
            this.letterEntryTxt.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterEntryTxt.Location = new System.Drawing.Point(409, 15);
            this.letterEntryTxt.MaxLength = 1;
            this.letterEntryTxt.Name = "letterEntryTxt";
            this.letterEntryTxt.Size = new System.Drawing.Size(40, 33);
            this.letterEntryTxt.TabIndex = 2;
            this.letterEntryTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.letterEntryTxt_KeyDown);
            // 
            // wordEntryPnl
            // 
            this.wordEntryPnl.BackgroundImage = global::Hangman.Properties.Resources.gameBack;
            this.wordEntryPnl.Controls.Add(this.musicBtn);
            this.wordEntryPnl.Controls.Add(this.nameCancelBtn);
            this.wordEntryPnl.Controls.Add(this.nameSetBtn);
            this.wordEntryPnl.Controls.Add(this.player2NameTxt);
            this.wordEntryPnl.Controls.Add(this.player1NameTxt);
            this.wordEntryPnl.Controls.Add(this.player2NameLbl);
            this.wordEntryPnl.Controls.Add(this.player1NameLbl);
            this.wordEntryPnl.Controls.Add(this.playerTurnLbl);
            this.wordEntryPnl.Controls.Add(this.wordCancelBtn);
            this.wordEntryPnl.Controls.Add(this.wordOKBtn);
            this.wordEntryPnl.Controls.Add(this.wordEntryTxt);
            this.wordEntryPnl.Controls.Add(this.enterWordLbl);
            this.wordEntryPnl.Location = new System.Drawing.Point(0, 0);
            this.wordEntryPnl.Name = "wordEntryPnl";
            this.wordEntryPnl.Size = new System.Drawing.Size(800, 450);
            this.wordEntryPnl.TabIndex = 3;
            this.wordEntryPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.wordEntryPnl_Paint);
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
            this.musicBtn.TabIndex = 11;
            this.musicBtn.UseVisualStyleBackColor = false;
            this.musicBtn.Click += new System.EventHandler(this.musicBtn_Click);
            this.musicBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.musicBtn_MouseDown);
            this.musicBtn.MouseEnter += new System.EventHandler(this.musicBtn_MouseEnter);
            this.musicBtn.MouseLeave += new System.EventHandler(this.musicBtn_MouseLeave);
            this.musicBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.musicBtn_MouseUp);
            // 
            // nameCancelBtn
            // 
            this.nameCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.nameCancelBtn.FlatAppearance.BorderSize = 0;
            this.nameCancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nameCancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nameCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameCancelBtn.Image = global::Hangman.Properties.Resources.CancelBtn;
            this.nameCancelBtn.Location = new System.Drawing.Point(497, 245);
            this.nameCancelBtn.Name = "nameCancelBtn";
            this.nameCancelBtn.Size = new System.Drawing.Size(100, 50);
            this.nameCancelBtn.TabIndex = 10;
            this.nameCancelBtn.UseVisualStyleBackColor = false;
            this.nameCancelBtn.Click += new System.EventHandler(this.nameCancelBtn_Click);
            this.nameCancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameCancelBtn_MouseDown);
            this.nameCancelBtn.MouseEnter += new System.EventHandler(this.nameCancelBtn_MouseEnter);
            this.nameCancelBtn.MouseLeave += new System.EventHandler(this.nameCancelBtn_MouseLeave);
            this.nameCancelBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nameCancelBtn_MouseUp);
            // 
            // nameSetBtn
            // 
            this.nameSetBtn.BackColor = System.Drawing.Color.Transparent;
            this.nameSetBtn.FlatAppearance.BorderSize = 0;
            this.nameSetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nameSetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nameSetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameSetBtn.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSetBtn.Image = global::Hangman.Properties.Resources.OKBtn;
            this.nameSetBtn.Location = new System.Drawing.Point(218, 245);
            this.nameSetBtn.Name = "nameSetBtn";
            this.nameSetBtn.Size = new System.Drawing.Size(100, 50);
            this.nameSetBtn.TabIndex = 9;
            this.nameSetBtn.UseVisualStyleBackColor = false;
            this.nameSetBtn.Click += new System.EventHandler(this.nameSetBtn_Click);
            this.nameSetBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameSetBtn_MouseDown);
            this.nameSetBtn.MouseEnter += new System.EventHandler(this.nameSetBtn_MouseEnter);
            this.nameSetBtn.MouseLeave += new System.EventHandler(this.nameSetBtn_MouseLeave);
            this.nameSetBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nameSetBtn_MouseUp);
            // 
            // player2NameTxt
            // 
            this.player2NameTxt.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.player2NameTxt.Location = new System.Drawing.Point(374, 201);
            this.player2NameTxt.Name = "player2NameTxt";
            this.player2NameTxt.Size = new System.Drawing.Size(223, 28);
            this.player2NameTxt.TabIndex = 8;
            this.player2NameTxt.Text = "Player2";
            // 
            // player1NameTxt
            // 
            this.player1NameTxt.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.player1NameTxt.Location = new System.Drawing.Point(374, 149);
            this.player1NameTxt.Name = "player1NameTxt";
            this.player1NameTxt.Size = new System.Drawing.Size(223, 28);
            this.player1NameTxt.TabIndex = 7;
            this.player1NameTxt.Text = "Player1";
            // 
            // player2NameLbl
            // 
            this.player2NameLbl.AutoSize = true;
            this.player2NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.player2NameLbl.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.player2NameLbl.Location = new System.Drawing.Point(213, 209);
            this.player2NameLbl.Name = "player2NameLbl";
            this.player2NameLbl.Size = new System.Drawing.Size(155, 27);
            this.player2NameLbl.TabIndex = 6;
            this.player2NameLbl.Text = "Player 2\'s name:";
            // 
            // player1NameLbl
            // 
            this.player1NameLbl.AutoSize = true;
            this.player1NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.player1NameLbl.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.player1NameLbl.Location = new System.Drawing.Point(213, 157);
            this.player1NameLbl.Name = "player1NameLbl";
            this.player1NameLbl.Size = new System.Drawing.Size(155, 27);
            this.player1NameLbl.TabIndex = 5;
            this.player1NameLbl.Text = "Player 1\'s name:";
            // 
            // playerTurnLbl
            // 
            this.playerTurnLbl.AutoSize = true;
            this.playerTurnLbl.BackColor = System.Drawing.Color.Transparent;
            this.playerTurnLbl.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurnLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.playerTurnLbl.Location = new System.Drawing.Point(10, 21);
            this.playerTurnLbl.Name = "playerTurnLbl";
            this.playerTurnLbl.Size = new System.Drawing.Size(180, 27);
            this.playerTurnLbl.TabIndex = 4;
            this.playerTurnLbl.Text = "Player1\'s go to guess";
            // 
            // wordCancelBtn
            // 
            this.wordCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.wordCancelBtn.FlatAppearance.BorderSize = 0;
            this.wordCancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wordCancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wordCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordCancelBtn.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordCancelBtn.Image = global::Hangman.Properties.Resources.CancelBtn;
            this.wordCancelBtn.Location = new System.Drawing.Point(273, 86);
            this.wordCancelBtn.Name = "wordCancelBtn";
            this.wordCancelBtn.Size = new System.Drawing.Size(95, 50);
            this.wordCancelBtn.TabIndex = 3;
            this.wordCancelBtn.UseVisualStyleBackColor = false;
            this.wordCancelBtn.Click += new System.EventHandler(this.wordCancelBtn_Click);
            this.wordCancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wordCancelBtn_MouseDown);
            this.wordCancelBtn.MouseEnter += new System.EventHandler(this.wordCancelBtn_MouseEnter);
            this.wordCancelBtn.MouseLeave += new System.EventHandler(this.wordCancelBtn_MouseLeave);
            this.wordCancelBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wordCancelBtn_MouseUp);
            // 
            // wordOKBtn
            // 
            this.wordOKBtn.BackColor = System.Drawing.Color.Transparent;
            this.wordOKBtn.FlatAppearance.BorderSize = 0;
            this.wordOKBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wordOKBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wordOKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordOKBtn.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordOKBtn.Image = global::Hangman.Properties.Resources.OKBtn;
            this.wordOKBtn.Location = new System.Drawing.Point(145, 87);
            this.wordOKBtn.Name = "wordOKBtn";
            this.wordOKBtn.Size = new System.Drawing.Size(100, 50);
            this.wordOKBtn.TabIndex = 2;
            this.wordOKBtn.UseVisualStyleBackColor = false;
            this.wordOKBtn.Click += new System.EventHandler(this.wordOKBtn_Click);
            this.wordOKBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wordOKBtn_MouseDown);
            this.wordOKBtn.MouseEnter += new System.EventHandler(this.wordOKBtn_MouseEnter);
            this.wordOKBtn.MouseLeave += new System.EventHandler(this.wordOKBtn_MouseLeave);
            this.wordOKBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wordOKBtn_MouseUp);
            // 
            // wordEntryTxt
            // 
            this.wordEntryTxt.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordEntryTxt.Location = new System.Drawing.Point(211, 47);
            this.wordEntryTxt.MaxLength = 20;
            this.wordEntryTxt.Name = "wordEntryTxt";
            this.wordEntryTxt.PasswordChar = '•';
            this.wordEntryTxt.Size = new System.Drawing.Size(223, 28);
            this.wordEntryTxt.TabIndex = 1;
            this.wordEntryTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordEntryTxt_KeyDown);
            // 
            // enterWordLbl
            // 
            this.enterWordLbl.AutoSize = true;
            this.enterWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.enterWordLbl.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterWordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.enterWordLbl.Location = new System.Drawing.Point(61, 51);
            this.enterWordLbl.Name = "enterWordLbl";
            this.enterWordLbl.Size = new System.Drawing.Size(129, 27);
            this.enterWordLbl.TabIndex = 0;
            this.enterWordLbl.Text = "Enter a word:";
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
            this.guessLetterBtn.TabIndex = 4;
            this.guessLetterBtn.UseVisualStyleBackColor = false;
            this.guessLetterBtn.Click += new System.EventHandler(this.guessLetterBtn_Click);
            this.guessLetterBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guessLetterBtn_MouseDown);
            this.guessLetterBtn.MouseEnter += new System.EventHandler(this.guessLetterBtn_MouseEnter);
            this.guessLetterBtn.MouseLeave += new System.EventHandler(this.guessLetterBtn_MouseLeave);
            this.guessLetterBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guessLetterBtn_MouseUp);
            // 
            // guessesLeftLbl
            // 
            this.guessesLeftLbl.AutoSize = true;
            this.guessesLeftLbl.BackColor = System.Drawing.Color.Transparent;
            this.guessesLeftLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessesLeftLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.guessesLeftLbl.Location = new System.Drawing.Point(264, 123);
            this.guessesLeftLbl.Name = "guessesLeftLbl";
            this.guessesLeftLbl.Size = new System.Drawing.Size(139, 37);
            this.guessesLeftLbl.TabIndex = 6;
            this.guessesLeftLbl.Text = "Guesses left:";
            // 
            // spacedLabel
            // 
            this.spacedLabel.AutoSize = true;
            this.spacedLabel.BackColor = System.Drawing.Color.Transparent;
            this.spacedLabel.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spacedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.spacedLabel.Location = new System.Drawing.Point(46, 294);
            this.spacedLabel.Name = "spacedLabel";
            this.spacedLabel.Size = new System.Drawing.Size(88, 53);
            this.spacedLabel.TabIndex = 28;
            this.spacedLabel.Text = "     ";
            // 
            // usedWordsTitleLbl
            // 
            this.usedWordsTitleLbl.AutoSize = true;
            this.usedWordsTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.usedWordsTitleLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usedWordsTitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.usedWordsTitleLbl.Location = new System.Drawing.Point(217, 176);
            this.usedWordsTitleLbl.Name = "usedWordsTitleLbl";
            this.usedWordsTitleLbl.Size = new System.Drawing.Size(186, 37);
            this.usedWordsTitleLbl.TabIndex = 29;
            this.usedWordsTitleLbl.Text = "Incorrect guesses:";
            // 
            // incorrectGuessesLst
            // 
            this.incorrectGuessesLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.incorrectGuessesLst.FormattingEnabled = true;
            this.incorrectGuessesLst.Location = new System.Drawing.Point(409, 175);
            this.incorrectGuessesLst.Name = "incorrectGuessesLst";
            this.incorrectGuessesLst.Size = new System.Drawing.Size(50, 173);
            this.incorrectGuessesLst.TabIndex = 30;
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
            this.guessWholeWordBtn.TabIndex = 31;
            this.guessWholeWordBtn.UseVisualStyleBackColor = false;
            this.guessWholeWordBtn.Click += new System.EventHandler(this.guessWholeWordBtn_Click);
            this.guessWholeWordBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guessWholeWordBtn_MouseDown);
            this.guessWholeWordBtn.MouseEnter += new System.EventHandler(this.guessWholeWordBtn_MouseEnter);
            this.guessWholeWordBtn.MouseLeave += new System.EventHandler(this.guessWholeWordBtn_MouseLeave);
            this.guessWholeWordBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guessWholeWordBtn_MouseUp);
            // 
            // guessWordTxt
            // 
            this.guessWordTxt.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessWordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.guessWordTxt.Location = new System.Drawing.Point(409, 69);
            this.guessWordTxt.MaxLength = 20;
            this.guessWordTxt.Name = "guessWordTxt";
            this.guessWordTxt.Size = new System.Drawing.Size(149, 28);
            this.guessWordTxt.TabIndex = 32;
            this.guessWordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessWordTxt_KeyDown);
            // 
            // guessWordLbl
            // 
            this.guessWordLbl.AutoSize = true;
            this.guessWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.guessWordLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessWordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.guessWordLbl.Location = new System.Drawing.Point(320, 68);
            this.guessWordLbl.Name = "guessWordLbl";
            this.guessWordLbl.Size = new System.Drawing.Size(72, 37);
            this.guessWordLbl.TabIndex = 33;
            this.guessWordLbl.Text = "Word:";
            // 
            // hangmanDisplayPic
            // 
            this.hangmanDisplayPic.BackColor = System.Drawing.Color.Transparent;
            this.hangmanDisplayPic.Location = new System.Drawing.Point(5, 5);
            this.hangmanDisplayPic.Name = "hangmanDisplayPic";
            this.hangmanDisplayPic.Size = new System.Drawing.Size(200, 225);
            this.hangmanDisplayPic.TabIndex = 34;
            this.hangmanDisplayPic.TabStop = false;
            // 
            // lettersInWordLbl
            // 
            this.lettersInWordLbl.AutoSize = true;
            this.lettersInWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.lettersInWordLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettersInWordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lettersInWordLbl.Location = new System.Drawing.Point(12, 387);
            this.lettersInWordLbl.Name = "lettersInWordLbl";
            this.lettersInWordLbl.Size = new System.Drawing.Size(56, 37);
            this.lettersInWordLbl.TabIndex = 35;
            this.lettersInWordLbl.Text = "LIW";
            // 
            // player1PointsLbl
            // 
            this.player1PointsLbl.AutoSize = true;
            this.player1PointsLbl.BackColor = System.Drawing.Color.Transparent;
            this.player1PointsLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1PointsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.player1PointsLbl.Location = new System.Drawing.Point(483, 229);
            this.player1PointsLbl.Name = "player1PointsLbl";
            this.player1PointsLbl.Size = new System.Drawing.Size(48, 37);
            this.player1PointsLbl.TabIndex = 36;
            this.player1PointsLbl.Text = "p1p";
            // 
            // player2PointsLbl
            // 
            this.player2PointsLbl.AutoSize = true;
            this.player2PointsLbl.BackColor = System.Drawing.Color.Transparent;
            this.player2PointsLbl.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2PointsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.player2PointsLbl.Location = new System.Drawing.Point(483, 281);
            this.player2PointsLbl.Name = "player2PointsLbl";
            this.player2PointsLbl.Size = new System.Drawing.Size(47, 37);
            this.player2PointsLbl.TabIndex = 37;
            this.player2PointsLbl.Text = "p2p";
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
            this.music2.TabIndex = 38;
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
            this.lettersLeftInWordLbl.Location = new System.Drawing.Point(201, 387);
            this.lettersLeftInWordLbl.Name = "lettersLeftInWordLbl";
            this.lettersLeftInWordLbl.Size = new System.Drawing.Size(39, 37);
            this.lettersLeftInWordLbl.TabIndex = 39;
            this.lettersLeftInWordLbl.Text = "LL";
            // 
            // HangmanMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman.Properties.Resources.gameBack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lettersLeftInWordLbl);
            this.Controls.Add(this.music2);
            this.Controls.Add(this.wordEntryPnl);
            this.Controls.Add(this.player2PointsLbl);
            this.Controls.Add(this.player1PointsLbl);
            this.Controls.Add(this.lettersInWordLbl);
            this.Controls.Add(this.hangmanDisplayPic);
            this.Controls.Add(this.guessWordLbl);
            this.Controls.Add(this.guessWordTxt);
            this.Controls.Add(this.guessWholeWordBtn);
            this.Controls.Add(this.incorrectGuessesLst);
            this.Controls.Add(this.usedWordsTitleLbl);
            this.Controls.Add(this.spacedLabel);
            this.Controls.Add(this.guessesLeftLbl);
            this.Controls.Add(this.guessLetterBtn);
            this.Controls.Add(this.letterEntryTxt);
            this.Controls.Add(this.letterEntryLbl);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HangmanMulti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.MultiPlayer_Load);
            this.wordEntryPnl.ResumeLayout(false);
            this.wordEntryPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanDisplayPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label letterEntryLbl;
        private System.Windows.Forms.TextBox letterEntryTxt;
        private System.Windows.Forms.Panel wordEntryPnl;
        private System.Windows.Forms.Label enterWordLbl;
        private System.Windows.Forms.TextBox wordEntryTxt;
        private System.Windows.Forms.Button wordOKBtn;
        private System.Windows.Forms.Button wordCancelBtn;
        private System.Windows.Forms.Button guessLetterBtn;
        private System.Windows.Forms.Label guessesLeftLbl;
        private System.Windows.Forms.Label spacedLabel;
        private System.Windows.Forms.Label usedWordsTitleLbl;
        private System.Windows.Forms.ListBox incorrectGuessesLst;
        private System.Windows.Forms.Button guessWholeWordBtn;
        private System.Windows.Forms.TextBox guessWordTxt;
        private System.Windows.Forms.Label guessWordLbl;
        private System.Windows.Forms.PictureBox hangmanDisplayPic;
        private System.Windows.Forms.Label lettersInWordLbl;
        private System.Windows.Forms.TextBox player2NameTxt;
        private System.Windows.Forms.TextBox player1NameTxt;
        private System.Windows.Forms.Label player2NameLbl;
        private System.Windows.Forms.Label player1NameLbl;
        private System.Windows.Forms.Label playerTurnLbl;
        private System.Windows.Forms.Button nameCancelBtn;
        private System.Windows.Forms.Button nameSetBtn;
        private System.Windows.Forms.Label player1PointsLbl;
        private System.Windows.Forms.Label player2PointsLbl;
        private System.Windows.Forms.Button musicBtn;
        private System.Windows.Forms.Button music2;
        private System.Windows.Forms.Label lettersLeftInWordLbl;
    }
}