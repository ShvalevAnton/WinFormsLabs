namespace BiblWorm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudPeriodUse = new System.Windows.Forms.NumericUpDown();
            this.nudInvNum = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.tbPub = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.cbExistence = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbReturnTime = new System.Windows.Forms.CheckBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.nudPages = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLook = new System.Windows.Forms.Button();
            this.cbSortInvNumber = new System.Windows.Forms.CheckBox();
            this.rtbEnterBooks = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriodUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(297, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(289, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Книги";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 42);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nudPeriodUse, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.nudInvNum, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.nudYear, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPub, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbTitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbExistence, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbReturnTime, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbAutor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudPages, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 321);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // nudPeriodUse
            // 
            this.nudPeriodUse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPeriodUse.Location = new System.Drawing.Point(142, 243);
            this.nudPeriodUse.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudPeriodUse.Name = "nudPeriodUse";
            this.nudPeriodUse.Size = new System.Drawing.Size(133, 20);
            this.nudPeriodUse.TabIndex = 14;
            // 
            // nudInvNum
            // 
            this.nudInvNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInvNum.Location = new System.Drawing.Point(142, 203);
            this.nudInvNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudInvNum.Name = "nudInvNum";
            this.nudInvNum.Size = new System.Drawing.Size(133, 20);
            this.nudInvNum.TabIndex = 13;
            // 
            // nudYear
            // 
            this.nudYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudYear.Location = new System.Drawing.Point(142, 163);
            this.nudYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(133, 20);
            this.nudYear.TabIndex = 12;
            this.nudYear.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // tbPub
            // 
            this.tbPub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPub.Location = new System.Drawing.Point(142, 83);
            this.tbPub.Name = "tbPub";
            this.tbPub.Size = new System.Drawing.Size(133, 20);
            this.tbPub.TabIndex = 10;
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(142, 43);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(133, 20);
            this.tbTitle.TabIndex = 9;
            // 
            // cbExistence
            // 
            this.cbExistence.AutoSize = true;
            this.cbExistence.Location = new System.Drawing.Point(3, 283);
            this.cbExistence.Name = "cbExistence";
            this.cbExistence.Size = new System.Drawing.Size(69, 17);
            this.cbExistence.TabIndex = 4;
            this.cbExistence.Text = "Наличие";
            this.cbExistence.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Издательство";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Страниц";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Год издания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Инвентарный";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Срок пользования";
            // 
            // cbReturnTime
            // 
            this.cbReturnTime.AutoSize = true;
            this.cbReturnTime.Location = new System.Drawing.Point(142, 283);
            this.cbReturnTime.Name = "cbReturnTime";
            this.cbReturnTime.Size = new System.Drawing.Size(132, 17);
            this.cbReturnTime.TabIndex = 7;
            this.cbReturnTime.Text = "Возвращение в срок";
            this.cbReturnTime.UseVisualStyleBackColor = true;
            // 
            // tbAutor
            // 
            this.tbAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAutor.Location = new System.Drawing.Point(142, 3);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(133, 20);
            this.tbAutor.TabIndex = 8;
            // 
            // nudPages
            // 
            this.nudPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPages.Location = new System.Drawing.Point(142, 123);
            this.nudPages.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPages.Name = "nudPages";
            this.nudPages.Size = new System.Drawing.Size(133, 20);
            this.nudPages.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(289, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журналы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(303, 366);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(152, 31);
            this.btnLook.TabIndex = 2;
            this.btnLook.Text = "Посмотреть";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // cbSortInvNumber
            // 
            this.cbSortInvNumber.AutoSize = true;
            this.cbSortInvNumber.Location = new System.Drawing.Point(461, 374);
            this.cbSortInvNumber.Name = "cbSortInvNumber";
            this.cbSortInvNumber.Size = new System.Drawing.Size(181, 17);
            this.cbSortInvNumber.TabIndex = 3;
            this.cbSortInvNumber.Text = "Сортировать по инвентарному";
            this.cbSortInvNumber.UseVisualStyleBackColor = true;
            // 
            // rtbEnterBook
            // 
            this.rtbEnterBooks.Location = new System.Drawing.Point(304, 22);
            this.rtbEnterBooks.Name = "rtbEnterBook";
            this.rtbEnterBooks.Size = new System.Drawing.Size(338, 338);
            this.rtbEnterBooks.TabIndex = 4;
            this.rtbEnterBooks.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.rtbEnterBooks);
            this.Controls.Add(this.cbSortInvNumber);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriodUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown nudPeriodUse;
        private System.Windows.Forms.NumericUpDown nudInvNum;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.TextBox tbPub;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.CheckBox cbExistence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbReturnTime;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.NumericUpDown nudPages;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.CheckBox cbSortInvNumber;
        private System.Windows.Forms.RichTextBox rtbEnterBooks;
    }
}

