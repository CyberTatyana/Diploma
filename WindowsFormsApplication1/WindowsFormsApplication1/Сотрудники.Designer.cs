namespace WindowsFormsApplication1
{
    partial class Сотрудники
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
            this.components = new System.ComponentModel.Container();
            this.serviceDataSet = new WindowsFormsApplication1.ServiceDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new WindowsFormsApplication1.ServiceDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ServiceDataSetTableAdapters.TableAdapterManager();
            this.сотрудникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.placeHolderTextBox1 = new System.Windows.Forms.PlaceHolderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.placeHolderTextBox2 = new System.Windows.Forms.PlaceHolderTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.placeHolderTextBox3 = new System.Windows.Forms.PlaceHolderTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.placeHolderTextBox5 = new System.Windows.Forms.PlaceHolderTextBox();
            this.placeHolderTextBox4 = new System.Windows.Forms.PlaceHolderTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceDataSet1 = new WindowsFormsApplication1.ServiceDataSet();
            this.button9 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.placeHolderTextBox6 = new System.Windows.Forms.PlaceHolderTextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button12 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.placeHolderTextBox7 = new System.Windows.Forms.PlaceHolderTextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceDataSet
            // 
            this.serviceDataSet.DataSetName = "ServiceDataSet";
            this.serviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.serviceDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = null;
            this.tableAdapterManager.Ремонт_оборудованияTableAdapter = null;
            this.tableAdapterManager.РемонтTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.Тип_оборудованияTableAdapter = null;
            // 
            // сотрудникиDataGridView
            // 
            this.сотрудникиDataGridView.AutoGenerateColumns = false;
            this.сотрудникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сотрудникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.сотрудникиDataGridView.DataSource = this.сотрудникиBindingSource;
            this.сотрудникиDataGridView.Location = new System.Drawing.Point(20, 111);
            this.сотрудникиDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.сотрудникиDataGridView.Name = "сотрудникиDataGridView";
            this.сотрудникиDataGridView.Size = new System.Drawing.Size(834, 338);
            this.сотрудникиDataGridView.TabIndex = 1;
            this.сотрудникиDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.сотрудникиDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn2.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Стаж";
            this.dataGridViewTextBoxColumn3.HeaderText = "Стаж";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер_паспорта";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер_паспорта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(664, 458);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 458);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 458);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(102, 5);
            this.placeHolderTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "Введите ФИО";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(214, 26);
            this.placeHolderTextBox1.TabIndex = 15;
            this.placeHolderTextBox1.Text = "Введите ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Должность";
            // 
            // placeHolderTextBox2
            // 
            this.placeHolderTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox2.Location = new System.Drawing.Point(105, 62);
            this.placeHolderTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placeHolderTextBox2.Name = "placeHolderTextBox2";
            this.placeHolderTextBox2.PlaceHolderText = "Введите должность";
            this.placeHolderTextBox2.Size = new System.Drawing.Size(214, 26);
            this.placeHolderTextBox2.TabIndex = 17;
            this.placeHolderTextBox2.Text = "Введите должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Стаж";
            // 
            // placeHolderTextBox3
            // 
            this.placeHolderTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox3.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox3.Location = new System.Drawing.Point(105, 120);
            this.placeHolderTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placeHolderTextBox3.Name = "placeHolderTextBox3";
            this.placeHolderTextBox3.PlaceHolderText = "Введите стаж";
            this.placeHolderTextBox3.Size = new System.Drawing.Size(214, 26);
            this.placeHolderTextBox3.TabIndex = 19;
            this.placeHolderTextBox3.Text = "Введите стаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 40);
            this.label4.TabIndex = 22;
            this.label4.Text = "Номер\r\nпаспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Телефон";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 317);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 35);
            this.button6.TabIndex = 25;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.placeHolderTextBox5);
            this.panel1.Controls.Add(this.placeHolderTextBox4);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.placeHolderTextBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.placeHolderTextBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.placeHolderTextBox2);
            this.panel1.Location = new System.Drawing.Point(20, 503);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 392);
            this.panel1.TabIndex = 29;
            this.panel1.Visible = false;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(214, 317);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 35);
            this.button14.TabIndex = 29;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // placeHolderTextBox5
            // 
            this.placeHolderTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox5.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox5.Location = new System.Drawing.Point(102, 257);
            this.placeHolderTextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placeHolderTextBox5.Name = "placeHolderTextBox5";
            this.placeHolderTextBox5.PlaceHolderText = "Введите номер телефона";
            this.placeHolderTextBox5.Size = new System.Drawing.Size(217, 26);
            this.placeHolderTextBox5.TabIndex = 28;
            this.placeHolderTextBox5.Text = "Введите номер телефона";
            // 
            // placeHolderTextBox4
            // 
            this.placeHolderTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox4.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox4.Location = new System.Drawing.Point(105, 194);
            this.placeHolderTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placeHolderTextBox4.Name = "placeHolderTextBox4";
            this.placeHolderTextBox4.PlaceHolderText = "Введите номер паспорта";
            this.placeHolderTextBox4.Size = new System.Drawing.Size(214, 26);
            this.placeHolderTextBox4.TabIndex = 27;
            this.placeHolderTextBox4.Text = "Введите номер паспорта";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(318, 352);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 35);
            this.button7.TabIndex = 26;
            this.button7.Text = "Выход";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(447, 500);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 395);
            this.panel2.TabIndex = 30;
            this.panel2.Visible = false;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.serviceDataSet1;
            // 
            // serviceDataSet1
            // 
            this.serviceDataSet1.DataSetName = "ServiceDataSet";
            this.serviceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(20, 58);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 35);
            this.button9.TabIndex = 31;
            this.button9.Text = "Фильтрация";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.placeHolderTextBox6);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(177, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 83);
            this.panel3.TabIndex = 32;
            this.panel3.Visible = false;
            // 
            // placeHolderTextBox6
            // 
            this.placeHolderTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox6.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox6.Location = new System.Drawing.Point(196, 2);
            this.placeHolderTextBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placeHolderTextBox6.Name = "placeHolderTextBox6";
            this.placeHolderTextBox6.PlaceHolderText = "Введите фильтр";
            this.placeHolderTextBox6.Size = new System.Drawing.Size(148, 26);
            this.placeHolderTextBox6.TabIndex = 4;
            this.placeHolderTextBox6.Text = "Введите фильтр";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(196, 40);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(150, 35);
            this.button11.TabIndex = 3;
            this.button11.Text = "Сброс";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(4, 40);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(177, 35);
            this.button10.TabIndex = 2;
            this.button10.Text = "Фильтр";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Должность"});
            this.comboBox1.Location = new System.Drawing.Point(6, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(20, 18);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(148, 35);
            this.button12.TabIndex = 33;
            this.button12.Text = "Поиск";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.placeHolderTextBox7);
            this.panel4.Controls.Add(this.button13);
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Location = new System.Drawing.Point(549, 18);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 83);
            this.panel4.TabIndex = 34;
            this.panel4.Visible = false;
            // 
            // placeHolderTextBox7
            // 
            this.placeHolderTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox7.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox7.Location = new System.Drawing.Point(172, 5);
            this.placeHolderTextBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placeHolderTextBox7.Name = "placeHolderTextBox7";
            this.placeHolderTextBox7.PlaceHolderText = null;
            this.placeHolderTextBox7.Size = new System.Drawing.Size(148, 26);
            this.placeHolderTextBox7.TabIndex = 3;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(4, 40);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(314, 35);
            this.button13.TabIndex = 2;
            this.button13.Text = "Поиск";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ФИО",
            "Номер_паспорта",
            "Телефон"});
            this.comboBox3.Location = new System.Drawing.Point(0, 5);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(170, 28);
            this.comboBox3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 186);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 237);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 4;
            // 
            // Сотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 911);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.сотрудникиDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Сотрудники";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Worker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ServiceDataSet serviceDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private ServiceDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView сотрудникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ServiceDataSet serviceDataSet1;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox5;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox7;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}