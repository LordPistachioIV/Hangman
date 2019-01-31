namespace Hangman
{
    partial class MainMenu
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
            this.twoPlayerBtn = new System.Windows.Forms.Button();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.onePlayerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // twoPlayerBtn
            // 
            this.twoPlayerBtn.BackColor = System.Drawing.Color.Transparent;
            this.twoPlayerBtn.FlatAppearance.BorderSize = 0;
            this.twoPlayerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.twoPlayerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.twoPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoPlayerBtn.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoPlayerBtn.Image = global::Hangman.Properties.Resources.twoPlayersBtn;
            this.twoPlayerBtn.Location = new System.Drawing.Point(538, 272);
            this.twoPlayerBtn.Name = "twoPlayerBtn";
            this.twoPlayerBtn.Size = new System.Drawing.Size(200, 50);
            this.twoPlayerBtn.TabIndex = 1;
            this.twoPlayerBtn.UseVisualStyleBackColor = false;
            this.twoPlayerBtn.Click += new System.EventHandler(this.singlePlayerBtn_Click);
            this.twoPlayerBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.twoPlayerBtn_MouseDown);
            this.twoPlayerBtn.MouseEnter += new System.EventHandler(this.twoPlayerBtn_MouseEnter);
            this.twoPlayerBtn.MouseLeave += new System.EventHandler(this.twoPlayerBtn_MouseLeave);
            this.twoPlayerBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.twoPlayerBtn_MouseUp);
            // 
            // rulesBtn
            // 
            this.rulesBtn.BackColor = System.Drawing.Color.Transparent;
            this.rulesBtn.FlatAppearance.BorderSize = 0;
            this.rulesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rulesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rulesBtn.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesBtn.Image = global::Hangman.Properties.Resources.rulesBtn;
            this.rulesBtn.Location = new System.Drawing.Point(538, 324);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(200, 50);
            this.rulesBtn.TabIndex = 2;
            this.rulesBtn.UseVisualStyleBackColor = false;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            this.rulesBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rulesBtn_MouseDown);
            this.rulesBtn.MouseEnter += new System.EventHandler(this.rulesBtn_MouseEnter);
            this.rulesBtn.MouseLeave += new System.EventHandler(this.rulesBtn_MouseLeave);
            this.rulesBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rulesBtn_MouseUp);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = global::Hangman.Properties.Resources.exitBtn;
            this.exitBtn.Location = new System.Drawing.Point(538, 379);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 50);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseDown);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            this.exitBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseUp);
            // 
            // onePlayerBtn
            // 
            this.onePlayerBtn.BackColor = System.Drawing.Color.Transparent;
            this.onePlayerBtn.FlatAppearance.BorderSize = 0;
            this.onePlayerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.onePlayerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.onePlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onePlayerBtn.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onePlayerBtn.Image = global::Hangman.Properties.Resources.onePlayerBtn;
            this.onePlayerBtn.Location = new System.Drawing.Point(538, 219);
            this.onePlayerBtn.Name = "onePlayerBtn";
            this.onePlayerBtn.Size = new System.Drawing.Size(200, 50);
            this.onePlayerBtn.TabIndex = 4;
            this.onePlayerBtn.UseVisualStyleBackColor = false;
            this.onePlayerBtn.Click += new System.EventHandler(this.onePlayerBtn_Click);
            this.onePlayerBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onePlayerBtn_MouseDown);
            this.onePlayerBtn.MouseEnter += new System.EventHandler(this.onePlayerBtn_MouseEnter);
            this.onePlayerBtn.MouseLeave += new System.EventHandler(this.onePlayerBtn_MouseLeave);
            this.onePlayerBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onePlayerBtn_MouseUp);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman.Properties.Resources.titleScreen;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.onePlayerBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.twoPlayerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button twoPlayerBtn;
        private System.Windows.Forms.Button rulesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button onePlayerBtn;
    }
}

