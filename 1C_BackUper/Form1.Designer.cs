namespace _1C_Backuper
{
    partial class backup1c
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBackUpPath = new System.Windows.Forms.TextBox();
            this.btnBackUpPathBrows = new System.Windows.Forms.Button();
            this.fbdBackUp = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd1CBase = new System.Windows.Forms.FolderBrowserDialog();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chbActiv = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstTask = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn7Zip = new System.Windows.Forms.RadioButton();
            this.rbtn1C = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chbKill1C = new System.Windows.Forms.CheckBox();
            this.btn1CPathBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt1CBase = new System.Windows.Forms.TextBox();
            this.txt1CServer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt1CPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt1CUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBasePathBrows = new System.Windows.Forms.Button();
            this.txtBasePath = new System.Windows.Forms.TextBox();
            this.rbtn1CServer = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn1CFile = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txt1CFilePath = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сохранять в :";
            // 
            // txtBackUpPath
            // 
            this.txtBackUpPath.Location = new System.Drawing.Point(84, 6);
            this.txtBackUpPath.Name = "txtBackUpPath";
            this.txtBackUpPath.Size = new System.Drawing.Size(270, 20);
            this.txtBackUpPath.TabIndex = 3;
            // 
            // btnBackUpPathBrows
            // 
            this.btnBackUpPathBrows.Location = new System.Drawing.Point(360, 6);
            this.btnBackUpPathBrows.Name = "btnBackUpPathBrows";
            this.btnBackUpPathBrows.Size = new System.Drawing.Size(31, 20);
            this.btnBackUpPathBrows.TabIndex = 4;
            this.btnBackUpPathBrows.Text = "...";
            this.btnBackUpPathBrows.UseVisualStyleBackColor = true;
            this.btnBackUpPathBrows.Click += new System.EventHandler(this.btnBackUpPathBrows_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(116, 41);
            this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(45, 20);
            this.numHour.TabIndex = 5;
            this.numHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numMin
            // 
            this.numMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numMin.Location = new System.Drawing.Point(198, 41);
            this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(45, 20);
            this.numMin.TabIndex = 6;
            this.numMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(525, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(444, 384);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(12, 384);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(33, 23);
            this.btnAddTask.TabIndex = 10;
            this.btnAddTask.Text = "+";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(51, 385);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(32, 23);
            this.btnRemoveTask.TabIndex = 11;
            this.btnRemoveTask.Text = "-";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Имя задания:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(290, 13);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(328, 20);
            this.txtTaskName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выполнять каждый";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "час.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "мин.";
            // 
            // chbActiv
            // 
            this.chbActiv.AutoSize = true;
            this.chbActiv.Checked = true;
            this.chbActiv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActiv.Location = new System.Drawing.Point(194, 43);
            this.chbActiv.Name = "chbActiv";
            this.chbActiv.Size = new System.Drawing.Size(127, 17);
            this.chbActiv.TabIndex = 17;
            this.chbActiv.Text = "Выполнять задание";
            this.chbActiv.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(547, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // lstTask
            // 
            this.lstTask.FormattingEnabled = true;
            this.lstTask.Location = new System.Drawing.Point(12, 12);
            this.lstTask.Name = "lstTask";
            this.lstTask.Size = new System.Drawing.Size(176, 368);
            this.lstTask.TabIndex = 22;
            this.lstTask.SelectedIndexChanged += new System.EventHandler(this.lstTask_SelectedIndexChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "День",
            "Понедель"});
            this.comboBox1.Location = new System.Drawing.Point(137, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(194, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 282);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnBackUpPathBrows);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBackUpPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn7Zip);
            this.groupBox2.Controls.Add(this.rbtn1C);
            this.groupBox2.Location = new System.Drawing.Point(10, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 73);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Способ резервного копировани";
            // 
            // rbtn7Zip
            // 
            this.rbtn7Zip.AutoSize = true;
            this.rbtn7Zip.Location = new System.Drawing.Point(7, 43);
            this.rbtn7Zip.Name = "rbtn7Zip";
            this.rbtn7Zip.Size = new System.Drawing.Size(49, 17);
            this.rbtn7Zip.TabIndex = 1;
            this.rbtn7Zip.Text = "7 Zip";
            this.rbtn7Zip.UseVisualStyleBackColor = true;
            // 
            // rbtn1C
            // 
            this.rbtn1C.AutoSize = true;
            this.rbtn1C.Checked = true;
            this.rbtn1C.Location = new System.Drawing.Point(7, 20);
            this.rbtn1C.Name = "rbtn1C";
            this.rbtn1C.Size = new System.Drawing.Size(103, 17);
            this.rbtn1C.TabIndex = 0;
            this.rbtn1C.TabStop = true;
            this.rbtn1C.Text = "Средствами 1С";
            this.rbtn1C.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.numHour);
            this.tabPage2.Controls.Add(this.numMin);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расписание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chbKill1C);
            this.tabPage3.Controls.Add(this.btn1CPathBrowse);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txt1CFilePath);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(420, 256);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Средствами 1С";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chbKill1C
            // 
            this.chbKill1C.AutoSize = true;
            this.chbKill1C.Checked = true;
            this.chbKill1C.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbKill1C.Location = new System.Drawing.Point(11, 23);
            this.chbKill1C.Name = "chbKill1C";
            this.chbKill1C.Size = new System.Drawing.Size(252, 17);
            this.chbKill1C.TabIndex = 30;
            this.chbKill1C.Text = "Принудительно завершать все процессы 1С";
            this.chbKill1C.UseVisualStyleBackColor = true;
            // 
            // btn1CPathBrowse
            // 
            this.btn1CPathBrowse.Location = new System.Drawing.Point(381, 46);
            this.btn1CPathBrowse.Name = "btn1CPathBrowse";
            this.btn1CPathBrowse.Size = new System.Drawing.Size(30, 20);
            this.btn1CPathBrowse.TabIndex = 29;
            this.btn1CPathBrowse.Text = "...";
            this.btn1CPathBrowse.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt1CBase);
            this.groupBox1.Controls.Add(this.txt1CServer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt1CPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt1CUser);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBasePathBrows);
            this.groupBox1.Controls.Add(this.txtBasePath);
            this.groupBox1.Controls.Add(this.rbtn1CServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbtn1CFile);
            this.groupBox1.Location = new System.Drawing.Point(8, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 174);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "База данных 1С";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "База:";
            // 
            // txt1CBase
            // 
            this.txt1CBase.Enabled = false;
            this.txt1CBase.Location = new System.Drawing.Point(291, 110);
            this.txt1CBase.Name = "txt1CBase";
            this.txt1CBase.Size = new System.Drawing.Size(108, 20);
            this.txt1CBase.TabIndex = 15;
            // 
            // txt1CServer
            // 
            this.txt1CServer.Enabled = false;
            this.txt1CServer.Location = new System.Drawing.Point(97, 110);
            this.txt1CServer.Name = "txt1CServer";
            this.txt1CServer.Size = new System.Drawing.Size(100, 20);
            this.txt1CServer.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Сервер:";
            // 
            // txt1CPassword
            // 
            this.txt1CPassword.Location = new System.Drawing.Point(291, 141);
            this.txt1CPassword.Name = "txt1CPassword";
            this.txt1CPassword.PasswordChar = '*';
            this.txt1CPassword.Size = new System.Drawing.Size(109, 20);
            this.txt1CPassword.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль:";
            // 
            // txt1CUser
            // 
            this.txt1CUser.Location = new System.Drawing.Point(97, 141);
            this.txt1CUser.Name = "txt1CUser";
            this.txt1CUser.Size = new System.Drawing.Size(100, 20);
            this.txt1CUser.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пользователь:";
            // 
            // btnBasePathBrows
            // 
            this.btnBasePathBrows.Location = new System.Drawing.Point(369, 44);
            this.btnBasePathBrows.Name = "btnBasePathBrows";
            this.btnBasePathBrows.Size = new System.Drawing.Size(31, 20);
            this.btnBasePathBrows.TabIndex = 8;
            this.btnBasePathBrows.Text = "...";
            this.btnBasePathBrows.UseVisualStyleBackColor = true;
            // 
            // txtBasePath
            // 
            this.txtBasePath.Location = new System.Drawing.Point(97, 44);
            this.txtBasePath.Name = "txtBasePath";
            this.txtBasePath.Size = new System.Drawing.Size(270, 20);
            this.txtBasePath.TabIndex = 7;
            // 
            // rbtn1CServer
            // 
            this.rbtn1CServer.AutoSize = true;
            this.rbtn1CServer.Location = new System.Drawing.Point(7, 77);
            this.rbtn1CServer.Name = "rbtn1CServer";
            this.rbtn1CServer.Size = new System.Drawing.Size(84, 17);
            this.rbtn1CServer.TabIndex = 2;
            this.rbtn1CServer.TabStop = true;
            this.rbtn1CServer.Text = "На сервере";
            this.rbtn1CServer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Путь к базе:";
            // 
            // rbtn1CFile
            // 
            this.rbtn1CFile.AutoSize = true;
            this.rbtn1CFile.Location = new System.Drawing.Point(7, 20);
            this.rbtn1CFile.Name = "rbtn1CFile";
            this.rbtn1CFile.Size = new System.Drawing.Size(78, 17);
            this.rbtn1CFile.TabIndex = 0;
            this.rbtn1CFile.TabStop = true;
            this.rbtn1CFile.Text = "Файловая";
            this.rbtn1CFile.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Путь к программе 1С:";
            // 
            // txt1CFilePath
            // 
            this.txt1CFilePath.Location = new System.Drawing.Point(133, 46);
            this.txt1CFilePath.Name = "txt1CFilePath";
            this.txt1CFilePath.Size = new System.Drawing.Size(242, 20);
            this.txt1CFilePath.TabIndex = 28;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(420, 256);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Средствами архиватора";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // backup1c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 415);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lstTask);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chbActiv);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "backup1c";
            this.Text = "1C Backuper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.backup1c_FormClosing);
            this.Load += new System.EventHandler(this.backup1c_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBackUpPath;
        private System.Windows.Forms.Button btnBackUpPathBrows;
        private System.Windows.Forms.FolderBrowserDialog fbdBackUp;
        private System.Windows.Forms.FolderBrowserDialog fbd1CBase;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbActiv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstTask;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn7Zip;
        private System.Windows.Forms.RadioButton rbtn1C;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chbKill1C;
        private System.Windows.Forms.Button btn1CPathBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt1CBase;
        private System.Windows.Forms.TextBox txt1CServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt1CPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt1CUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBasePathBrows;
        private System.Windows.Forms.TextBox txtBasePath;
        private System.Windows.Forms.RadioButton rbtn1CServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn1CFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt1CFilePath;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

