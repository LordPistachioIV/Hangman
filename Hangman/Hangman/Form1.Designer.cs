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
            this.hangmanLbl = new System.Windows.Forms.Label();
            this.twoPlayerBtn = new System.Windows.Forms.Button();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hangmanLbl
            // 
            this.hangmanLbl.AutoSize = true;
            this.hangmanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangmanLbl.Location = new System.Drawing.Point(259, 80);
            this.hangmanLbl.Name = "hangmanLbl";
            this.hangmanLbl.Size = new System.Drawing.Size(261, 61);
            this.hangmanLbl.TabIndex = 0;
            this.hangmanLbl.Text = "Hangman";
            // 
            // twoPlayerBtn
            // 
            this.twoPlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoPlayerBtn.Location = new System.Drawing.Point(100, 231);
            this.twoPlayerBtn.Name = "twoPlayerBtn";
            this.twoPlayerBtn.Size = new System.Drawing.Size(185, 110);
            this.twoPlayerBtn.TabIndex = 1;
            this.twoPlayerBtn.Text = "Single Player";
            this.twoPlayerBtn.UseVisualStyleBackColor = true;
            this.twoPlayerBtn.Click += new System.EventHandler(this.singlePlayerBtn_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesBtn.Location = new System.Drawing.Point(302, 231);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(185, 110);
            this.rulesBtn.TabIndex = 2;
            this.rulesBtn.Text = "Rules";
            this.rulesBtn.UseVisualStyleBackColor = true;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(504, 231);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(185, 110);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.twoPlayerBtn);
            this.Controls.Add(this.hangmanLbl);
            this.Name = "MainMenu";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hangmanLbl;
        private System.Windows.Forms.Button twoPlayerBtn;
        private System.Windows.Forms.Button rulesBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

