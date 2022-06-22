namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.TileLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lblWinLossDraw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinLossDrawf = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEnemy
            // 
            this.pbEnemy.Image = ((System.Drawing.Image)(resources.GetObject("pbEnemy.Image")));
            this.pbEnemy.Location = new System.Drawing.Point(1132, 239);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(150, 147);
            this.pbEnemy.TabIndex = 0;
            this.pbEnemy.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(513, 239);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(150, 147);
            this.pbPlayer.TabIndex = 1;
            this.pbPlayer.TabStop = false;
            // 
            // TileLabel
            // 
            this.TileLabel.AutoSize = true;
            this.TileLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TileLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TileLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TileLabel.Location = new System.Drawing.Point(462, 8);
            this.TileLabel.Name = "TileLabel";
            this.TileLabel.Size = new System.Drawing.Size(440, 65);
            this.TileLabel.TabIndex = 3;
            this.TileLabel.Text = "Rock Paper Scissors";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(32, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Pink;
            this.button2.Location = new System.Drawing.Point(32, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bank";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Pink;
            this.button3.Location = new System.Drawing.Point(32, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 63);
            this.button3.TabIndex = 6;
            this.button3.Text = "Upgrades";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Pink;
            this.button4.Location = new System.Drawing.Point(32, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 63);
            this.button4.TabIndex = 7;
            this.button4.Text = "New";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Pink;
            this.button6.Location = new System.Drawing.Point(32, 436);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 63);
            this.button6.TabIndex = 8;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(48)))), ((int)(((byte)(255)))));
            this.lblScore.Location = new System.Drawing.Point(288, 95);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(169, 82);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Player     | 0\r\nAI NPC   | 0\r\n";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(529, 436);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 34);
            this.button7.TabIndex = 12;
            this.button7.Text = "Rock";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Rock);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(529, 476);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 13;
            this.button5.Text = "Paper";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Paper);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(529, 516);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 34);
            this.button8.TabIndex = 14;
            this.button8.Text = "Scissors";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Scissors);
            // 
            // lblWinLossDraw
            // 
            this.lblWinLossDraw.AutoSize = true;
            this.lblWinLossDraw.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWinLossDraw.ForeColor = System.Drawing.Color.Lime;
            this.lblWinLossDraw.Location = new System.Drawing.Point(806, 277);
            this.lblWinLossDraw.Name = "lblWinLossDraw";
            this.lblWinLossDraw.Size = new System.Drawing.Size(0, 48);
            this.lblWinLossDraw.TabIndex = 15;
            this.lblWinLossDraw.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 16;
            // 
            // lblWinLossDrawf
            // 
            this.lblWinLossDrawf.AutoSize = true;
            this.lblWinLossDrawf.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWinLossDrawf.ForeColor = System.Drawing.Color.Lime;
            this.lblWinLossDrawf.Location = new System.Drawing.Point(721, 277);
            this.lblWinLossDrawf.Name = "lblWinLossDrawf";
            this.lblWinLossDrawf.Size = new System.Drawing.Size(326, 48);
            this.lblWinLossDrawf.TabIndex = 17;
            this.lblWinLossDrawf.Text = "You Won the Game";
            this.lblWinLossDrawf.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Cyan;
            this.button9.Location = new System.Drawing.Point(790, 349);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(190, 63);
            this.button9.TabIndex = 18;
            this.button9.Text = "Restart";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoney.ForeColor = System.Drawing.Color.Red;
            this.lblMoney.Location = new System.Drawing.Point(1363, 674);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(111, 54);
            this.lblMoney.TabIndex = 19;
            this.lblMoney.Text = "500$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1486, 737);
            this.ControlBox = false;
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.lblWinLossDrawf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWinLossDraw);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TileLabel);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbEnemy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbEnemy;
        private PictureBox pbPlayer;
        private Label TileLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Label lblScore;
        private Button button7;
        private Button button5;
        private Button button8;
        private Label lblWinLossDraw;
        private Label label1;
        private Label lblWinLossDrawf;
        private Button button9;
        private Label lblMoney;
    }
}