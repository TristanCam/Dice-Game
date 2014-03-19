namespace WindowsGame
{
    partial class Form1
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
            this.lbl_p1Dice1 = new System.Windows.Forms.Label();
            this.lbl_p1Dice2 = new System.Windows.Forms.Label();
            this.lbl_p1Dice3 = new System.Windows.Forms.Label();
            this.lbl_p1Dice4 = new System.Windows.Forms.Label();
            this.lbl_p1Dice5 = new System.Windows.Forms.Label();
            this.btn_p1rolldice = new System.Windows.Forms.Button();
            this.lbl_p1displayResults = new System.Windows.Forms.Label();
            this.lbl_p2displayResults = new System.Windows.Forms.Label();
            this.btn_p2rolldice = new System.Windows.Forms.Button();
            this.lbl_p2Dice5 = new System.Windows.Forms.Label();
            this.lbl_p2Dice4 = new System.Windows.Forms.Label();
            this.lbl_p2Dice3 = new System.Windows.Forms.Label();
            this.lbl_p2Dice2 = new System.Windows.Forms.Label();
            this.lbl_p2Dice1 = new System.Windows.Forms.Label();
            this.lbl_winnerResult = new System.Windows.Forms.Label();
            this.lbl_p1Name = new System.Windows.Forms.Label();
            this.lbl_p2Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_p1Dice1
            // 
            this.lbl_p1Dice1.Image = global::WindowsGame.Properties.Resources.dice_blank;
            this.lbl_p1Dice1.Location = new System.Drawing.Point(12, 145);
            this.lbl_p1Dice1.Name = "lbl_p1Dice1";
            this.lbl_p1Dice1.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1Dice1.TabIndex = 0;
            // 
            // lbl_p1Dice2
            // 
            this.lbl_p1Dice2.Image = global::WindowsGame.Properties.Resources.dice_blank;
            this.lbl_p1Dice2.Location = new System.Drawing.Point(68, 145);
            this.lbl_p1Dice2.Name = "lbl_p1Dice2";
            this.lbl_p1Dice2.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1Dice2.TabIndex = 1;
            // 
            // lbl_p1Dice3
            // 
            this.lbl_p1Dice3.Image = global::WindowsGame.Properties.Resources.dice_blank;
            this.lbl_p1Dice3.Location = new System.Drawing.Point(124, 145);
            this.lbl_p1Dice3.Name = "lbl_p1Dice3";
            this.lbl_p1Dice3.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1Dice3.TabIndex = 2;
            // 
            // lbl_p1Dice4
            // 
            this.lbl_p1Dice4.Image = global::WindowsGame.Properties.Resources.dice_blank;
            this.lbl_p1Dice4.Location = new System.Drawing.Point(180, 145);
            this.lbl_p1Dice4.Name = "lbl_p1Dice4";
            this.lbl_p1Dice4.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1Dice4.TabIndex = 3;
            // 
            // lbl_p1Dice5
            // 
            this.lbl_p1Dice5.Image = global::WindowsGame.Properties.Resources.dice_blank;
            this.lbl_p1Dice5.Location = new System.Drawing.Point(236, 145);
            this.lbl_p1Dice5.Name = "lbl_p1Dice5";
            this.lbl_p1Dice5.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1Dice5.TabIndex = 4;
            // 
            // btn_p1rolldice
            // 
            this.btn_p1rolldice.Location = new System.Drawing.Point(51, 215);
            this.btn_p1rolldice.Name = "btn_p1rolldice";
            this.btn_p1rolldice.Size = new System.Drawing.Size(200, 50);
            this.btn_p1rolldice.TabIndex = 6;
            this.btn_p1rolldice.Text = "Roll Dice";
            this.btn_p1rolldice.UseVisualStyleBackColor = true;
            this.btn_p1rolldice.Click += new System.EventHandler(this.btn_p1rolldice_Click);
            // 
            // lbl_p1displayResults
            // 
            this.lbl_p1displayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1displayResults.Location = new System.Drawing.Point(27, 353);
            this.lbl_p1displayResults.Name = "lbl_p1displayResults";
            this.lbl_p1displayResults.Size = new System.Drawing.Size(250, 50);
            this.lbl_p1displayResults.TabIndex = 7;
            this.lbl_p1displayResults.Text = "Roll the Dice";
            this.lbl_p1displayResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p2displayResults
            // 
            this.lbl_p2displayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2displayResults.Location = new System.Drawing.Point(500, 353);
            this.lbl_p2displayResults.Name = "lbl_p2displayResults";
            this.lbl_p2displayResults.Size = new System.Drawing.Size(250, 50);
            this.lbl_p2displayResults.TabIndex = 14;
            this.lbl_p2displayResults.Text = "Roll the Dice";
            this.lbl_p2displayResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_p2rolldice
            // 
            this.btn_p2rolldice.Location = new System.Drawing.Point(524, 215);
            this.btn_p2rolldice.Name = "btn_p2rolldice";
            this.btn_p2rolldice.Size = new System.Drawing.Size(200, 50);
            this.btn_p2rolldice.TabIndex = 13;
            this.btn_p2rolldice.Text = "Roll Dice";
            this.btn_p2rolldice.UseVisualStyleBackColor = true;
            this.btn_p2rolldice.Click += new System.EventHandler(this.btn_p2rolldice_Click);
            // 
            // lbl_p2Dice5
            // 
            this.lbl_p2Dice5.Image = global::WindowsGame.Properties.Resources.dice_blank;
            this.lbl_p2Dice5.Location = new System.Drawing.Point(709, 145);
            this.lbl_p2Dice5.Name = "lbl_p2Dice5";
            this.lbl_p2Dice5.Size = new System.Drawing.Size(50, 50);
            this.lbl_p2Dice5.TabIndex = 12;
            // 
            // lbl_p2Dice4
            // 
            this.lbl_p2Dice4.Image = global::WindowsGame.Properties.Resources.dice_blank;
            this.lbl_p2Dice4.Location = new System.Drawing.Point(653, 145);
            this.lbl_p2Dice4.Name = "lbl_p2Dice4";
            this.lbl_p2Dice4.Size = new System.Drawing.Size(50, 50);
            this.lbl_p2Dice4.TabIndex = 11;
            // 
            // lbl_p2Dice3
            // 
            this.lbl_p2Dice3.Image = global::WindowsGame.Properties.Resources.dice_blank;
            this.lbl_p2Dice3.Location = new System.Drawing.Point(597, 145);
            this.lbl_p2Dice3.Name = "lbl_p2Dice3";
            this.lbl_p2Dice3.Size = new System.Drawing.Size(50, 50);
            this.lbl_p2Dice3.TabIndex = 10;
            // 
            // lbl_p2Dice2
            // 
            this.lbl_p2Dice2.Image = global::WindowsGame.Properties.Resources.dice_blank;
            this.lbl_p2Dice2.Location = new System.Drawing.Point(541, 145);
            this.lbl_p2Dice2.Name = "lbl_p2Dice2";
            this.lbl_p2Dice2.Size = new System.Drawing.Size(50, 50);
            this.lbl_p2Dice2.TabIndex = 9;
            // 
            // lbl_p2Dice1
            // 
            this.lbl_p2Dice1.Image = global::WindowsGame.Properties.Resources.dice_blank;
            this.lbl_p2Dice1.Location = new System.Drawing.Point(485, 145);
            this.lbl_p2Dice1.Name = "lbl_p2Dice1";
            this.lbl_p2Dice1.Size = new System.Drawing.Size(50, 50);
            this.lbl_p2Dice1.TabIndex = 8;
            // 
            // lbl_winnerResult
            // 
            this.lbl_winnerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winnerResult.Location = new System.Drawing.Point(218, 9);
            this.lbl_winnerResult.Name = "lbl_winnerResult";
            this.lbl_winnerResult.Size = new System.Drawing.Size(350, 50);
            this.lbl_winnerResult.TabIndex = 15;
            this.lbl_winnerResult.Text = "Waiting for Roll";
            this.lbl_winnerResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p1Name
            // 
            this.lbl_p1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1Name.Location = new System.Drawing.Point(12, 83);
            this.lbl_p1Name.Name = "lbl_p1Name";
            this.lbl_p1Name.Size = new System.Drawing.Size(250, 50);
            this.lbl_p1Name.TabIndex = 16;
            // 
            // lbl_p2Name
            // 
            this.lbl_p2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2Name.Location = new System.Drawing.Point(483, 83);
            this.lbl_p2Name.Name = "lbl_p2Name";
            this.lbl_p2Name.Size = new System.Drawing.Size(250, 50);
            this.lbl_p2Name.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lbl_p2Name);
            this.Controls.Add(this.lbl_p1Name);
            this.Controls.Add(this.lbl_winnerResult);
            this.Controls.Add(this.lbl_p2displayResults);
            this.Controls.Add(this.btn_p2rolldice);
            this.Controls.Add(this.lbl_p2Dice5);
            this.Controls.Add(this.lbl_p2Dice4);
            this.Controls.Add(this.lbl_p2Dice3);
            this.Controls.Add(this.lbl_p2Dice2);
            this.Controls.Add(this.lbl_p2Dice1);
            this.Controls.Add(this.lbl_p1displayResults);
            this.Controls.Add(this.btn_p1rolldice);
            this.Controls.Add(this.lbl_p1Dice5);
            this.Controls.Add(this.lbl_p1Dice4);
            this.Controls.Add(this.lbl_p1Dice3);
            this.Controls.Add(this.lbl_p1Dice2);
            this.Controls.Add(this.lbl_p1Dice1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_p1Dice1;
        private System.Windows.Forms.Label lbl_p1Dice2;
        private System.Windows.Forms.Label lbl_p1Dice3;
        private System.Windows.Forms.Label lbl_p1Dice4;
        private System.Windows.Forms.Label lbl_p1Dice5;
        private System.Windows.Forms.Button btn_p1rolldice;
        private System.Windows.Forms.Label lbl_p1displayResults;
        private System.Windows.Forms.Label lbl_p2displayResults;
        private System.Windows.Forms.Button btn_p2rolldice;
        private System.Windows.Forms.Label lbl_p2Dice5;
        private System.Windows.Forms.Label lbl_p2Dice4;
        private System.Windows.Forms.Label lbl_p2Dice3;
        private System.Windows.Forms.Label lbl_p2Dice2;
        private System.Windows.Forms.Label lbl_p2Dice1;
        private System.Windows.Forms.Label lbl_winnerResult;
        private System.Windows.Forms.Label lbl_p1Name;
        private System.Windows.Forms.Label lbl_p2Name;
    }
}

