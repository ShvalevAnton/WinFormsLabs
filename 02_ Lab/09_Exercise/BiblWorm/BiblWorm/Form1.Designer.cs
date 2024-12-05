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
            this.TabControl0 = new System.Windows.Forms.TabControl();
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
            this.btnAddM = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.tbTitleM = new System.Windows.Forms.TextBox();
            this.cbExistenceM = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSub = new System.Windows.Forms.CheckBox();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.nudYearM = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudInvNumM = new System.Windows.Forms.NumericUpDown();
            this.btnLook = new System.Windows.Forms.Button();
            this.cbSortInvNumber = new System.Windows.Forms.CheckBox();
            this.rtbEnterBooks = new System.Windows.Forms.RichTextBox();
            this.TabControl0.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriodUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvNumM)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl0
            // 
            this.TabControl0.Controls.Add(this.tabPage1);
            this.TabControl0.Controls.Add(this.tabPage2);
            this.TabControl0.Dock = System.Windows.Forms.DockStyle.Left;
            this.TabControl0.Location = new System.Drawing.Point(0, 0);
            this.TabControl0.Name = "TabControl0";
            this.TabControl0.SelectedIndex = 0;
            this.TabControl0.Size = new System.Drawing.Size(297, 411);
            this.TabControl0.TabIndex = 0;            
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
            10000,
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
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.btnAddM);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(289, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журналы";
            // 
            // btnAddM
            // 
            this.btnAddM.Location = new System.Drawing.Point(25, 333);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(241, 42);
            this.btnAddM.TabIndex = 4;
            this.btnAddM.Text = "Добавить";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.nudNum, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbTitleM, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbExistenceM, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbSub, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.tbVolume, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudYearM, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.nudInvNumM, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 321);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // nudNum
            // 
            this.nudNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNum.Location = new System.Drawing.Point(142, 43);
            this.nudNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(133, 20);
            this.nudNum.TabIndex = 14;
            // 
            // tbTitleM
            // 
            this.tbTitleM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitleM.Location = new System.Drawing.Point(142, 83);
            this.tbTitleM.Name = "tbTitleM";
            this.tbTitleM.Size = new System.Drawing.Size(133, 20);
            this.tbTitleM.TabIndex = 10;
            // 
            // cbExistenceM
            // 
            this.cbExistenceM.AutoSize = true;
            this.cbExistenceM.Location = new System.Drawing.Point(3, 283);
            this.cbExistenceM.Name = "cbExistenceM";
            this.cbExistenceM.Size = new System.Drawing.Size(69, 17);
            this.cbExistenceM.TabIndex = 4;
            this.cbExistenceM.Text = "Наличие";
            this.cbExistenceM.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 40);
            this.label8.TabIndex = 0;
            this.label8.Text = "Том";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "Номер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Название";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Дата выпуска";
            // 
            // cbSub
            // 
            this.cbSub.AutoSize = true;
            this.cbSub.Location = new System.Drawing.Point(142, 283);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(76, 17);
            this.cbSub.TabIndex = 7;
            this.cbSub.Text = "Подписка";
            this.cbSub.UseVisualStyleBackColor = true;
            // 
            // tbVolume
            // 
            this.tbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVolume.Location = new System.Drawing.Point(142, 3);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(133, 20);
            this.tbVolume.TabIndex = 8;
            // 
            // nudYearM
            // 
            this.nudYearM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudYearM.Location = new System.Drawing.Point(142, 123);
            this.nudYearM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudYearM.Name = "nudYearM";
            this.nudYearM.Size = new System.Drawing.Size(133, 20);
            this.nudYearM.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Инвентарный";
            // 
            // nudInvNumM
            // 
            this.nudInvNumM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInvNumM.Location = new System.Drawing.Point(142, 163);
            this.nudInvNumM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudInvNumM.Name = "nudInvNumM";
            this.nudInvNumM.Size = new System.Drawing.Size(133, 20);
            this.nudInvNumM.TabIndex = 13;
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
            // rtbEnterBooks
            // 
            this.rtbEnterBooks.Location = new System.Drawing.Point(304, 22);
            this.rtbEnterBooks.Name = "rtbEnterBooks";
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
            this.Controls.Add(this.TabControl0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.TabControl0.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriodUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvNumM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl0;
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
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown nudInvNumM;
        private System.Windows.Forms.TextBox tbTitleM;
        private System.Windows.Forms.CheckBox cbExistenceM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbSub;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.NumericUpDown nudYearM;
        private System.Windows.Forms.NumericUpDown nudNum;
    }
}

