namespace HangMan
{
    partial class HangManApp
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInDesc = new System.Windows.Forms.Label();
            this.lblWtg = new System.Windows.Forms.Label();
            this.lblTheWord = new System.Windows.Forms.Label();
            this.lblGuessTitle = new System.Windows.Forms.Label();
            this.lblWrongTitle = new System.Windows.Forms.Label();
            this.lblGuessesLeft = new System.Windows.Forms.Label();
            this.lblGuessedLetters = new System.Windows.Forms.Label();
            this.picDead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDead)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(327, 93);
            this.txtInput.MaxLength = 1;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(70, 30);
            this.txtInput.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(159, 147);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(218, 38);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check Letter";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(218, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Hang Man";
            // 
            // lblInDesc
            // 
            this.lblInDesc.AutoSize = true;
            this.lblInDesc.Location = new System.Drawing.Point(111, 98);
            this.lblInDesc.Name = "lblInDesc";
            this.lblInDesc.Size = new System.Drawing.Size(210, 25);
            this.lblInDesc.TabIndex = 3;
            this.lblInDesc.Text = "Enter letter in the word:";
            // 
            // lblWtg
            // 
            this.lblWtg.Location = new System.Drawing.Point(111, 249);
            this.lblWtg.Name = "lblWtg";
            this.lblWtg.Size = new System.Drawing.Size(88, 53);
            this.lblWtg.TabIndex = 4;
            this.lblWtg.Text = "Word to guess";
            this.lblWtg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTheWord
            // 
            this.lblTheWord.AutoSize = true;
            this.lblTheWord.Location = new System.Drawing.Point(251, 263);
            this.lblTheWord.Name = "lblTheWord";
            this.lblTheWord.Size = new System.Drawing.Size(0, 25);
            this.lblTheWord.TabIndex = 5;
            this.lblTheWord.Visible = false;
            // 
            // lblGuessTitle
            // 
            this.lblGuessTitle.AutoSize = true;
            this.lblGuessTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessTitle.Location = new System.Drawing.Point(58, 366);
            this.lblGuessTitle.Name = "lblGuessTitle";
            this.lblGuessTitle.Size = new System.Drawing.Size(166, 25);
            this.lblGuessTitle.TabIndex = 6;
            this.lblGuessTitle.Text = "Letters guessed";
            // 
            // lblWrongTitle
            // 
            this.lblWrongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongTitle.Location = new System.Drawing.Point(334, 357);
            this.lblWrongTitle.Name = "lblWrongTitle";
            this.lblWrongTitle.Size = new System.Drawing.Size(139, 54);
            this.lblWrongTitle.TabIndex = 7;
            this.lblWrongTitle.Text = "Wrong guesses left";
            this.lblWrongTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGuessesLeft
            // 
            this.lblGuessesLeft.AutoSize = true;
            this.lblGuessesLeft.Location = new System.Drawing.Point(392, 422);
            this.lblGuessesLeft.Name = "lblGuessesLeft";
            this.lblGuessesLeft.Size = new System.Drawing.Size(23, 25);
            this.lblGuessesLeft.TabIndex = 8;
            this.lblGuessesLeft.Text = "6";
            this.lblGuessesLeft.Visible = false;
            // 
            // lblGuessedLetters
            // 
            this.lblGuessedLetters.AutoSize = true;
            this.lblGuessedLetters.Location = new System.Drawing.Point(58, 422);
            this.lblGuessedLetters.Name = "lblGuessedLetters";
            this.lblGuessedLetters.Size = new System.Drawing.Size(0, 25);
            this.lblGuessedLetters.TabIndex = 9;
            this.lblGuessedLetters.Visible = false;
            // 
            // picDead
            // 
            this.picDead.Image = global::HangMan.Properties.Resources.deadface;
            this.picDead.Location = new System.Drawing.Point(339, 333);
            this.picDead.Name = "picDead";
            this.picDead.Size = new System.Drawing.Size(152, 135);
            this.picDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDead.TabIndex = 10;
            this.picDead.TabStop = false;
            this.picDead.Visible = false;
            // 
            // HangManApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(511, 480);
            this.Controls.Add(this.picDead);
            this.Controls.Add(this.lblGuessedLetters);
            this.Controls.Add(this.lblGuessesLeft);
            this.Controls.Add(this.lblWrongTitle);
            this.Controls.Add(this.lblGuessTitle);
            this.Controls.Add(this.lblTheWord);
            this.Controls.Add(this.lblWtg);
            this.Controls.Add(this.lblInDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HangManApp";
            this.Text = "Hang Man";
            ((System.ComponentModel.ISupportInitialize)(this.picDead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInDesc;
        private System.Windows.Forms.Label lblWtg;
        private System.Windows.Forms.Label lblTheWord;
        private System.Windows.Forms.Label lblGuessTitle;
        private System.Windows.Forms.Label lblWrongTitle;
        private System.Windows.Forms.Label lblGuessesLeft;
        private System.Windows.Forms.Label lblGuessedLetters;
        private System.Windows.Forms.PictureBox picDead;
    }
}

