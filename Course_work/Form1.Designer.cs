namespace Course_work
{
	partial class Main_form
	{
		/// <summary>
		/// Обязательная переменная конструктора.
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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
			this.Data_Person = new System.Windows.Forms.DataGridView();
			this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Midname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Documents = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateOfEmployment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Actuality = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.DateOfDismissal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.info1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.courseworkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.course_workDataSet = new Course_work.Course_workDataSet();
			this.SaveButton = new System.Windows.Forms.Button();
			this.Delete_button = new System.Windows.Forms.Button();
			this.Search_button = new System.Windows.Forms.Button();
			this.SearchBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Actcb = new System.Windows.Forms.CheckBox();
			this.Poscb = new System.Windows.Forms.CheckBox();
			this.LNcb = new System.Windows.Forms.CheckBox();
			this.Fired = new System.Windows.Forms.CheckBox();
			this.info1TableAdapter = new Course_work.Course_workDataSetTableAdapters.Info1TableAdapter();
			this.off = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.add_button = new System.Windows.Forms.Button();
			this.DOD = new System.Windows.Forms.TextBox();
			this.DOB = new System.Windows.Forms.TextBox();
			this.DOE = new System.Windows.Forms.TextBox();
			this.OK_button = new System.Windows.Forms.Button();
			this.Cancel_button = new System.Windows.Forms.Button();
			this.edit_button = new System.Windows.Forms.Button();
			this.Reas = new System.Windows.Forms.TextBox();
			this.pos = new System.Windows.Forms.TextBox();
			this.Pasp = new System.Windows.Forms.TextBox();
			this.MN = new System.Windows.Forms.TextBox();
			this.N = new System.Windows.Forms.TextBox();
			this.LN = new System.Windows.Forms.TextBox();
			this.Act = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.selected_button = new System.Windows.Forms.Button();
			this.Find = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.Data_Person)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.info1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.courseworkDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Find)).BeginInit();
			this.SuspendLayout();
			// 
			// Data_Person
			// 
			this.Data_Person.AllowUserToAddRows = false;
			this.Data_Person.AutoGenerateColumns = false;
			this.Data_Person.BackgroundColor = System.Drawing.SystemColors.Control;
			this.Data_Person.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Data_Person.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.Data_Person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Data_Person.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Lastname,
            this.Name_,
            this.Midname,
            this.DateOfBirth,
            this.Documents,
            this.DateOfEmployment,
            this.Position,
            this.Actuality,
            this.DateOfDismissal,
            this.Reason});
			this.Data_Person.DataSource = this.info1BindingSource;
			this.Data_Person.Location = new System.Drawing.Point(13, 78);
			this.Data_Person.Margin = new System.Windows.Forms.Padding(4);
			this.Data_Person.Name = "Data_Person";
			this.Data_Person.Size = new System.Drawing.Size(1527, 185);
			this.Data_Person.TabIndex = 3;
			this.Data_Person.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.Data_Person.SelectionChanged += new System.EventHandler(this.Data_Person_SelectionChanged);
			// 
			// Index
			// 
			this.Index.DataPropertyName = "Index";
			this.Index.HeaderText = "Код";
			this.Index.Name = "Index";
			// 
			// Lastname
			// 
			this.Lastname.DataPropertyName = "Lastname";
			this.Lastname.HeaderText = "Фамилия";
			this.Lastname.Name = "Lastname";
			// 
			// Name_
			// 
			this.Name_.DataPropertyName = "Name_";
			this.Name_.HeaderText = "Имя";
			this.Name_.Name = "Name_";
			// 
			// Midname
			// 
			this.Midname.DataPropertyName = "Midname";
			this.Midname.HeaderText = "Отчество";
			this.Midname.Name = "Midname";
			// 
			// DateOfBirth
			// 
			this.DateOfBirth.DataPropertyName = "DateOfBirth";
			this.DateOfBirth.HeaderText = "Дата рождения";
			this.DateOfBirth.Name = "DateOfBirth";
			// 
			// Documents
			// 
			this.Documents.DataPropertyName = "Documents";
			this.Documents.HeaderText = "Паспорт";
			this.Documents.Name = "Documents";
			// 
			// DateOfEmployment
			// 
			this.DateOfEmployment.DataPropertyName = "DateOfEmployment";
			this.DateOfEmployment.HeaderText = "Дата принятия на работу";
			this.DateOfEmployment.Name = "DateOfEmployment";
			// 
			// Position
			// 
			this.Position.DataPropertyName = "Position";
			this.Position.HeaderText = "Должность";
			this.Position.Name = "Position";
			// 
			// Actuality
			// 
			this.Actuality.DataPropertyName = "Actuality";
			this.Actuality.HeaderText = "Не уволен(а)";
			this.Actuality.Name = "Actuality";
			// 
			// DateOfDismissal
			// 
			this.DateOfDismissal.DataPropertyName = "DateOfDismassal";
			this.DateOfDismissal.HeaderText = "Дата увольнения";
			this.DateOfDismissal.Name = "DateOfDismissal";
			// 
			// Reason
			// 
			this.Reason.DataPropertyName = "Reason";
			this.Reason.HeaderText = "Причина увольнения";
			this.Reason.Name = "Reason";
			// 
			// info1BindingSource
			// 
			this.info1BindingSource.DataMember = "Info1";
			this.info1BindingSource.DataSource = this.courseworkDataSetBindingSource;
			// 
			// courseworkDataSetBindingSource
			// 
			this.courseworkDataSetBindingSource.DataSource = this.course_workDataSet;
			this.courseworkDataSetBindingSource.Position = 0;
			// 
			// course_workDataSet
			// 
			this.course_workDataSet.DataSetName = "Course_workDataSet";
			this.course_workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// SaveButton
			// 
			this.SaveButton.BackColor = System.Drawing.Color.LightGreen;
			this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SaveButton.Location = new System.Drawing.Point(1192, 488);
			this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(323, 38);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.UseVisualStyleBackColor = false;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// Delete_button
			// 
			this.Delete_button.BackColor = System.Drawing.Color.Tomato;
			this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Delete_button.Location = new System.Drawing.Point(1192, 442);
			this.Delete_button.Margin = new System.Windows.Forms.Padding(4);
			this.Delete_button.Name = "Delete_button";
			this.Delete_button.Size = new System.Drawing.Size(323, 38);
			this.Delete_button.TabIndex = 6;
			this.Delete_button.Text = "Удалить";
			this.Delete_button.UseVisualStyleBackColor = false;
			this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
			// 
			// Search_button
			// 
			this.Search_button.Location = new System.Drawing.Point(664, 42);
			this.Search_button.Margin = new System.Windows.Forms.Padding(4);
			this.Search_button.Name = "Search_button";
			this.Search_button.Size = new System.Drawing.Size(256, 28);
			this.Search_button.TabIndex = 12;
			this.Search_button.Text = "Найти";
			this.Search_button.UseVisualStyleBackColor = true;
			this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
			// 
			// SearchBox
			// 
			this.SearchBox.Location = new System.Drawing.Point(16, 42);
			this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(497, 22);
			this.SearchBox.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(218, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "Осуществить поиск запсиси по:";
			// 
			// Actcb
			// 
			this.Actcb.AutoSize = true;
			this.Actcb.Location = new System.Drawing.Point(523, 11);
			this.Actcb.Margin = new System.Windows.Forms.Padding(4);
			this.Actcb.Name = "Actcb";
			this.Actcb.Size = new System.Drawing.Size(217, 21);
			this.Actcb.TabIndex = 9;
			this.Actcb.Text = "Действительность договора";
			this.Actcb.UseVisualStyleBackColor = true;
			this.Actcb.CheckedChanged += new System.EventHandler(this.Actcb_CheckedChanged);
			// 
			// Poscb
			// 
			this.Poscb.AutoSize = true;
			this.Poscb.Location = new System.Drawing.Point(392, 11);
			this.Poscb.Margin = new System.Windows.Forms.Padding(4);
			this.Poscb.Name = "Poscb";
			this.Poscb.Size = new System.Drawing.Size(103, 21);
			this.Poscb.TabIndex = 8;
			this.Poscb.Text = "Должность";
			this.Poscb.UseVisualStyleBackColor = true;
			this.Poscb.CheckedChanged += new System.EventHandler(this.Poscb_CheckedChanged);
			// 
			// LNcb
			// 
			this.LNcb.AutoSize = true;
			this.LNcb.Location = new System.Drawing.Point(276, 11);
			this.LNcb.Margin = new System.Windows.Forms.Padding(4);
			this.LNcb.Name = "LNcb";
			this.LNcb.Size = new System.Drawing.Size(92, 21);
			this.LNcb.TabIndex = 7;
			this.LNcb.Text = "Фамилия";
			this.LNcb.UseVisualStyleBackColor = true;
			this.LNcb.CheckedChanged += new System.EventHandler(this.LNcb_CheckedChanged);
			// 
			// Fired
			// 
			this.Fired.AutoSize = true;
			this.Fired.Location = new System.Drawing.Point(523, 42);
			this.Fired.Margin = new System.Windows.Forms.Padding(4);
			this.Fired.Name = "Fired";
			this.Fired.Size = new System.Drawing.Size(116, 21);
			this.Fired.TabIndex = 13;
			this.Fired.Text = "Не уволен(а)";
			this.Fired.UseVisualStyleBackColor = true;
			// 
			// info1TableAdapter
			// 
			this.info1TableAdapter.ClearBeforeFill = true;
			// 
			// off
			// 
			this.off.Location = new System.Drawing.Point(791, 7);
			this.off.Margin = new System.Windows.Forms.Padding(4);
			this.off.Name = "off";
			this.off.Size = new System.Drawing.Size(129, 28);
			this.off.TabIndex = 14;
			this.off.Text = "Сбросить";
			this.off.UseVisualStyleBackColor = true;
			this.off.Click += new System.EventHandler(this.off_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox2.Controls.Add(this.add_button);
			this.groupBox2.Controls.Add(this.DOD);
			this.groupBox2.Controls.Add(this.DOB);
			this.groupBox2.Controls.Add(this.DOE);
			this.groupBox2.Controls.Add(this.OK_button);
			this.groupBox2.Controls.Add(this.Cancel_button);
			this.groupBox2.Controls.Add(this.edit_button);
			this.groupBox2.Controls.Add(this.Reas);
			this.groupBox2.Controls.Add(this.pos);
			this.groupBox2.Controls.Add(this.Pasp);
			this.groupBox2.Controls.Add(this.MN);
			this.groupBox2.Controls.Add(this.N);
			this.groupBox2.Controls.Add(this.LN);
			this.groupBox2.Controls.Add(this.Act);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Location = new System.Drawing.Point(16, 292);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(1147, 242);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Информация о сотруднике";
			// 
			// add_button
			// 
			this.add_button.BackgroundImage = global::Course_work.Properties.Resources.add;
			this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.add_button.Location = new System.Drawing.Point(1105, 202);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(35, 35);
			this.add_button.TabIndex = 39;
			this.add_button.UseVisualStyleBackColor = true;
			this.add_button.Click += new System.EventHandler(this.add_button_Click);
			// 
			// DOD
			// 
			this.DOD.Location = new System.Drawing.Point(15, 158);
			this.DOD.Margin = new System.Windows.Forms.Padding(4);
			this.DOD.Name = "DOD";
			this.DOD.Size = new System.Drawing.Size(193, 22);
			this.DOD.TabIndex = 38;
			// 
			// DOB
			// 
			this.DOB.Location = new System.Drawing.Point(624, 49);
			this.DOB.Margin = new System.Windows.Forms.Padding(4);
			this.DOB.Name = "DOB";
			this.DOB.Size = new System.Drawing.Size(193, 22);
			this.DOB.TabIndex = 37;
			// 
			// DOE
			// 
			this.DOE.Location = new System.Drawing.Point(15, 99);
			this.DOE.Margin = new System.Windows.Forms.Padding(4);
			this.DOE.Name = "DOE";
			this.DOE.Size = new System.Drawing.Size(193, 22);
			this.DOE.TabIndex = 36;
			// 
			// OK_button
			// 
			this.OK_button.BackgroundImage = global::Course_work.Properties.Resources.ok1;
			this.OK_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.OK_button.Location = new System.Drawing.Point(1023, 202);
			this.OK_button.Name = "OK_button";
			this.OK_button.Size = new System.Drawing.Size(35, 35);
			this.OK_button.TabIndex = 35;
			this.OK_button.UseVisualStyleBackColor = true;
			this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
			// 
			// Cancel_button
			// 
			this.Cancel_button.BackgroundImage = global::Course_work.Properties.Resources.cancel1;
			this.Cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Cancel_button.Location = new System.Drawing.Point(1064, 202);
			this.Cancel_button.Name = "Cancel_button";
			this.Cancel_button.Size = new System.Drawing.Size(35, 35);
			this.Cancel_button.TabIndex = 34;
			this.Cancel_button.UseVisualStyleBackColor = true;
			this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
			// 
			// edit_button
			// 
			this.edit_button.BackgroundImage = global::Course_work.Properties.Resources.edit2;
			this.edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.edit_button.Location = new System.Drawing.Point(982, 202);
			this.edit_button.Name = "edit_button";
			this.edit_button.Size = new System.Drawing.Size(35, 35);
			this.edit_button.TabIndex = 33;
			this.edit_button.UseVisualStyleBackColor = true;
			this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
			// 
			// Reas
			// 
			this.Reas.Location = new System.Drawing.Point(291, 158);
			this.Reas.Margin = new System.Windows.Forms.Padding(4);
			this.Reas.Multiline = true;
			this.Reas.Name = "Reas";
			this.Reas.Size = new System.Drawing.Size(404, 77);
			this.Reas.TabIndex = 29;
			// 
			// pos
			// 
			this.pos.Location = new System.Drawing.Point(291, 103);
			this.pos.Margin = new System.Windows.Forms.Padding(4);
			this.pos.Name = "pos";
			this.pos.Size = new System.Drawing.Size(193, 22);
			this.pos.TabIndex = 27;
			// 
			// Pasp
			// 
			this.Pasp.Location = new System.Drawing.Point(830, 49);
			this.Pasp.Margin = new System.Windows.Forms.Padding(4);
			this.Pasp.Name = "Pasp";
			this.Pasp.Size = new System.Drawing.Size(223, 22);
			this.Pasp.TabIndex = 25;
			// 
			// MN
			// 
			this.MN.Location = new System.Drawing.Point(421, 50);
			this.MN.Margin = new System.Windows.Forms.Padding(4);
			this.MN.Name = "MN";
			this.MN.Size = new System.Drawing.Size(193, 22);
			this.MN.TabIndex = 23;
			// 
			// N
			// 
			this.N.Location = new System.Drawing.Point(219, 50);
			this.N.Margin = new System.Windows.Forms.Padding(4);
			this.N.Name = "N";
			this.N.Size = new System.Drawing.Size(193, 22);
			this.N.TabIndex = 22;
			// 
			// LN
			// 
			this.LN.Location = new System.Drawing.Point(16, 50);
			this.LN.Margin = new System.Windows.Forms.Padding(4);
			this.LN.Name = "LN";
			this.LN.Size = new System.Drawing.Size(193, 22);
			this.LN.TabIndex = 21;
			// 
			// Act
			// 
			this.Act.AutoSize = true;
			this.Act.Location = new System.Drawing.Point(624, 107);
			this.Act.Margin = new System.Windows.Forms.Padding(4);
			this.Act.Name = "Act";
			this.Act.Size = new System.Drawing.Size(18, 17);
			this.Act.TabIndex = 17;
			this.Act.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(287, 135);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(147, 17);
			this.label11.TabIndex = 9;
			this.label11.Text = "Причина увольнения";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 135);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(123, 17);
			this.label12.TabIndex = 8;
			this.label12.Text = "Дата увольнения";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(522, 103);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 17);
			this.label13.TabIndex = 7;
			this.label13.Text = "Не уволен(а)";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(287, 79);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(81, 17);
			this.label14.TabIndex = 6;
			this.label14.Text = "Должность";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(12, 79);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(179, 17);
			this.label15.TabIndex = 5;
			this.label15.Text = "Дата принятия на работу";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(827, 28);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(172, 17);
			this.label16.TabIndex = 4;
			this.label16.Text = "Серия и номер паспорта";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(620, 28);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(111, 17);
			this.label17.TabIndex = 3;
			this.label17.Text = "Дата рождения";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(417, 28);
			this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(71, 17);
			this.label18.TabIndex = 2;
			this.label18.Text = "Отчество";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(213, 28);
			this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(35, 17);
			this.label19.TabIndex = 1;
			this.label19.Text = "Имя";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(12, 28);
			this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(70, 17);
			this.label20.TabIndex = 0;
			this.label20.Text = "Фамилия";
			// 
			// selected_button
			// 
			this.selected_button.Location = new System.Drawing.Point(1192, 397);
			this.selected_button.Name = "selected_button";
			this.selected_button.Size = new System.Drawing.Size(323, 38);
			this.selected_button.TabIndex = 33;
			this.selected_button.Text = "Снять выделение";
			this.selected_button.UseVisualStyleBackColor = true;
			this.selected_button.Click += new System.EventHandler(this.selected_button_Click);
			// 
			// Find
			// 
			this.Find.AllowUserToAddRows = false;
			this.Find.BackgroundColor = System.Drawing.SystemColors.Control;
			this.Find.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Find.Location = new System.Drawing.Point(16, 78);
			this.Find.Name = "Find";
			this.Find.RowTemplate.Height = 24;
			this.Find.Size = new System.Drawing.Size(1620, 185);
			this.Find.TabIndex = 34;
			this.Find.SelectionChanged += new System.EventHandler(this.Find_SelectionChanged);
			// 
			// Main_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1549, 541);
			this.Controls.Add(this.selected_button);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.off);
			this.Controls.Add(this.Fired);
			this.Controls.Add(this.Search_button);
			this.Controls.Add(this.SearchBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Actcb);
			this.Controls.Add(this.Poscb);
			this.Controls.Add(this.LNcb);
			this.Controls.Add(this.Delete_button);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.Data_Person);
			this.Controls.Add(this.Find);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Main_form";
			this.Text = "Главная страница";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_form_FormClosing);
			this.Load += new System.EventHandler(this.Main_form_Load);
			((System.ComponentModel.ISupportInitialize)(this.Data_Person)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.info1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.courseworkDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.course_workDataSet)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Find)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.DataGridView Data_Person;
		private System.Windows.Forms.BindingSource courseworkDataSetBindingSource;
		public Course_workDataSet course_workDataSet;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button Delete_button;
		private System.Windows.Forms.Button Search_button;
		private System.Windows.Forms.TextBox SearchBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox Actcb;
		private System.Windows.Forms.CheckBox Poscb;
		private System.Windows.Forms.CheckBox LNcb;
		private System.Windows.Forms.CheckBox Fired;
		private System.Windows.Forms.BindingSource info1BindingSource;
		public Course_workDataSetTableAdapters.Info1TableAdapter info1TableAdapter;
		private System.Windows.Forms.Button off;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox Reas;
		private System.Windows.Forms.TextBox pos;
		private System.Windows.Forms.TextBox Pasp;
		private System.Windows.Forms.TextBox MN;
		private System.Windows.Forms.TextBox N;
		private System.Windows.Forms.TextBox LN;
		private System.Windows.Forms.CheckBox Act;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button edit_button;
		private System.Windows.Forms.Button OK_button;
		private System.Windows.Forms.Button Cancel_button;
		private System.Windows.Forms.TextBox DOB;
		private System.Windows.Forms.TextBox DOE;
		private System.Windows.Forms.TextBox DOD;
		private System.Windows.Forms.Button add_button;
		private System.Windows.Forms.Button selected_button;
		private System.Windows.Forms.DataGridView Find;
		private System.Windows.Forms.DataGridViewTextBoxColumn Index;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
		private System.Windows.Forms.DataGridViewTextBoxColumn Midname;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn Documents;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfEmployment;
		private System.Windows.Forms.DataGridViewTextBoxColumn Position;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Actuality;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDismissal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
	}
}

