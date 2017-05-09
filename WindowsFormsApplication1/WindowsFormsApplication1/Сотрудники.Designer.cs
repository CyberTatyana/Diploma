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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.Изменить = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceDataSet1 = new WindowsFormsApplication1.ServiceDataSet();
            this.button9 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button12 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.placeHolderTextBox7 = new System.Windows.Forms.PlaceHolderTextBox();
            this.placeHolderTextBox6 = new System.Windows.Forms.PlaceHolderTextBox();
            this.placeHolderTextBox5 = new System.Windows.Forms.PlaceHolderTextBox();
            this.placeHolderTextBox4 = new System.Windows.Forms.PlaceHolderTextBox();
            this.placeHolderTextBox1 = new System.Windows.Forms.PlaceHolderTextBox();
            this.placeHolderTextBox3 = new System.Windows.Forms.PlaceHolderTextBox();
            this.placeHolderTextBox2 = new System.Windows.Forms.PlaceHolderTextBox();
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
            this.сотрудникиDataGridView.Location = new System.Drawing.Point(13, 72);
            this.сотрудникиDataGridView.Name = "сотрудникиDataGridView";
            this.сотрудникиDataGridView.Size = new System.Drawing.Size(556, 220);
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
            this.button5.Location = new System.Drawing.Point(443, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(298, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Стаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Номер\r\nпаспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Телефон";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(68, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.placeHolderTextBox5);
            this.panel1.Controls.Add(this.placeHolderTextBox4);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.placeHolderTextBox1);
            this.panel1.Controls.Add(this.placeHolderTextBox3);
            this.panel1.Controls.Add(this.placeHolderTextBox2);
            this.panel1.Location = new System.Drawing.Point(13, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 255);
            this.panel1.TabIndex = 29;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Стаж";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Должность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "ФИО";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 26);
            this.label10.TabIndex = 32;
            this.label10.Text = "Номер\r\nпаспорта";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(212, 229);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "Выход";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Изменить
            // 
            this.Изменить.Location = new System.Drawing.Point(72, 208);
            this.Изменить.Name = "Изменить";
            this.Изменить.Size = new System.Drawing.Size(75, 23);
            this.Изменить.TabIndex = 29;
            this.Изменить.Text = "Изменить";
            this.Изменить.UseVisualStyleBackColor = true;
            this.Изменить.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Изменить);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(298, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 257);
            this.panel2.TabIndex = 30;
            this.panel2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(72, 179);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(111, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(71, 146);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 100);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 59);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 0;
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
            this.button9.Location = new System.Drawing.Point(13, 38);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 23);
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
            this.panel3.Location = new System.Drawing.Point(118, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 54);
            this.panel3.TabIndex = 32;
            this.panel3.Visible = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(131, 26);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Сброс";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(3, 26);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(118, 23);
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
            this.comboBox1.Location = new System.Drawing.Point(4, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(13, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(99, 23);
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
            this.panel4.Location = new System.Drawing.Point(366, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 54);
            this.panel4.TabIndex = 34;
            this.panel4.Visible = false;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 26);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(209, 23);
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
            this.comboBox3.Location = new System.Drawing.Point(0, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(115, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // placeHolderTextBox7
            // 
            this.placeHolderTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox7.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox7.Location = new System.Drawing.Point(115, 3);
            this.placeHolderTextBox7.Name = "placeHolderTextBox7";
            this.placeHolderTextBox7.PlaceHolderText = "Введите параметры поиска";
            this.placeHolderTextBox7.Size = new System.Drawing.Size(100, 20);
            this.placeHolderTextBox7.TabIndex = 3;
            this.placeHolderTextBox7.Text = "Введите параметры поиска";
            // 
            // placeHolderTextBox6
            // 
            this.placeHolderTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox6.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox6.Location = new System.Drawing.Point(131, 1);
            this.placeHolderTextBox6.Name = "placeHolderTextBox6";
            this.placeHolderTextBox6.PlaceHolderText = "Введите фильтр";
            this.placeHolderTextBox6.Size = new System.Drawing.Size(100, 20);
            this.placeHolderTextBox6.TabIndex = 4;
            this.placeHolderTextBox6.Text = "Введите фильтр";
            // 
            // placeHolderTextBox5
            // 
            this.placeHolderTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox5.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox5.Location = new System.Drawing.Point(68, 167);
            this.placeHolderTextBox5.Name = "placeHolderTextBox5";
            this.placeHolderTextBox5.PlaceHolderText = "Введите номер телефона";
            this.placeHolderTextBox5.Size = new System.Drawing.Size(146, 20);
            this.placeHolderTextBox5.TabIndex = 28;
            this.placeHolderTextBox5.Text = "Введите номер телефона";
            // 
            // placeHolderTextBox4
            // 
            this.placeHolderTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox4.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox4.Location = new System.Drawing.Point(70, 126);
            this.placeHolderTextBox4.Name = "placeHolderTextBox4";
            this.placeHolderTextBox4.PlaceHolderText = "Введите номер паспорта";
            this.placeHolderTextBox4.Size = new System.Drawing.Size(144, 20);
            this.placeHolderTextBox4.TabIndex = 27;
            this.placeHolderTextBox4.Text = "Введите номер паспорта";
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(68, 3);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "Введите ФИО";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(144, 20);
            this.placeHolderTextBox1.TabIndex = 15;
            this.placeHolderTextBox1.Text = "Введите ФИО";
            // 
            // placeHolderTextBox3
            // 
            this.placeHolderTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox3.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox3.Location = new System.Drawing.Point(70, 78);
            this.placeHolderTextBox3.Name = "placeHolderTextBox3";
            this.placeHolderTextBox3.PlaceHolderText = "Введите стаж";
            this.placeHolderTextBox3.Size = new System.Drawing.Size(144, 20);
            this.placeHolderTextBox3.TabIndex = 19;
            this.placeHolderTextBox3.Text = "Введите стаж";
            // 
            // placeHolderTextBox2
            // 
            this.placeHolderTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox2.Location = new System.Drawing.Point(70, 40);
            this.placeHolderTextBox2.Name = "placeHolderTextBox2";
            this.placeHolderTextBox2.PlaceHolderText = "Введите должность";
            this.placeHolderTextBox2.Size = new System.Drawing.Size(144, 20);
            this.placeHolderTextBox2.TabIndex = 17;
            this.placeHolderTextBox2.Text = "Введите должность";
            // 
            // Сотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 322);
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
        private System.Windows.Forms.Button Изменить;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}