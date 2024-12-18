namespace GuessTheNumber
{
    partial class gameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHint = new System.Windows.Forms.TextBox();
            this.lblCountAttempts = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLastAttempts = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.rtbHistoryGame = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCORE";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(254, 36);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter eour number (beetwen 1 and 1000)";
            // 
            // btnGuess
            // 
            this.btnGuess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuess.Location = new System.Drawing.Point(3, 3);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(354, 39);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnHint
            // 
            this.btnHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHint.Location = new System.Drawing.Point(3, 3);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(174, 44);
            this.btnHint.TabIndex = 4;
            this.btnHint.Text = "Show hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelGame.Location = new System.Drawing.Point(183, 3);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(174, 44);
            this.btnCancelGame.TabIndex = 5;
            this.btnCancelGame.Text = "End this game";
            this.btnCancelGame.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "History";
            // 
            // tbHint
            // 
            this.tbHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHint.Enabled = false;
            this.tbHint.Location = new System.Drawing.Point(3, 67);
            this.tbHint.Name = "tbHint";
            this.tbHint.ReadOnly = true;
            this.tbHint.Size = new System.Drawing.Size(354, 20);
            this.tbHint.TabIndex = 9;
            // 
            // lblCountAttempts
            // 
            this.lblCountAttempts.AutoSize = true;
            this.lblCountAttempts.Location = new System.Drawing.Point(3, 0);
            this.lblCountAttempts.Name = "lblCountAttempts";
            this.lblCountAttempts.Size = new System.Drawing.Size(116, 13);
            this.lblCountAttempts.TabIndex = 10;
            this.lblCountAttempts.Text = "Number of attempts left";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.72222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.27778F));
            this.tableLayoutPanel1.Controls.Add(this.tbLastAttempts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCountAttempts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbNum, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(96, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 66);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tbLastAttempts
            // 
            this.tbLastAttempts.Enabled = false;
            this.tbLastAttempts.Location = new System.Drawing.Point(254, 3);
            this.tbLastAttempts.Name = "tbLastAttempts";
            this.tbLastAttempts.ReadOnly = true;
            this.tbLastAttempts.Size = new System.Drawing.Size(100, 20);
            this.tbLastAttempts.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnHint, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelGame, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(96, 285);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(360, 50);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tbHint, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnGuess, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(96, 188);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.3125F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.6875F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(360, 90);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbScore, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 23);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // tbScore
            // 
            this.tbScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbScore.Enabled = false;
            this.tbScore.Location = new System.Drawing.Point(53, 3);
            this.tbScore.Name = "tbScore";
            this.tbScore.ReadOnly = true;
            this.tbScore.Size = new System.Drawing.Size(144, 20);
            this.tbScore.TabIndex = 1;
            // 
            // rtbHistoryGame
            // 
            this.rtbHistoryGame.Enabled = false;
            this.rtbHistoryGame.Location = new System.Drawing.Point(533, 117);
            this.rtbHistoryGame.Name = "rtbHistoryGame";
            this.rtbHistoryGame.ReadOnly = true;
            this.rtbHistoryGame.Size = new System.Drawing.Size(170, 218);
            this.rtbHistoryGame.TabIndex = 15;
            this.rtbHistoryGame.Text = "";
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelGame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbHistoryGame);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "gameForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game \"Guess the number\"";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnCancelGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHint;
        private System.Windows.Forms.Label lblCountAttempts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbLastAttempts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tbScore;
        public System.Windows.Forms.RichTextBox rtbHistoryGame;
    }
}