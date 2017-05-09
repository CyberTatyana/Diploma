namespace WindowsFormsApplication1
{
    partial class Оборудование
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
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оборудованиеTableAdapter = new WindowsFormsApplication1.ServiceDataSetTableAdapters.ОборудованиеTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ServiceDataSetTableAdapters.TableAdapterManager();
            this.оборудованиеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.типоборудованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeHolderTextBox1 = new System.Windows.Forms.PlaceHolderTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.тип_оборудованияTableAdapter = new WindowsFormsApplication1.ServiceDataSetTableAdapters.Тип_оборудованияTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.placeHolderTextBox2 = new System.Windows.Forms.PlaceHolderTextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типоборудованияBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceDataSet
            // 
            this.serviceDataSet.DataSetName = "ServiceDataSet";
            this.serviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.serviceDataSet;
            // 
            // оборудованиеTableAdapter
            // 
            this.оборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = this.оборудованиеTableAdapter;
            this.tableAdapterManager.Ремонт_оборудованияTableAdapter = null;
            this.tableAdapterManager.РемонтTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тип_оборудованияTableAdapter = null;
            // 
            // оборудованиеDataGridView
            // 
            this.оборудованиеDataGridView.AutoGenerateColumns = false;
            this.оборудованиеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.оборудованиеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.оборудованиеDataGridView.DataSource = this.оборудованиеBindingSource;
            this.оборудованиеDataGridView.Location = new System.Drawing.Point(6, 70);
            this.оборудованиеDataGridView.Name = "оборудованиеDataGridView";
            this.оборудованиеDataGridView.Size = new System.Drawing.Size(438, 220);
            this.оборудованиеDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название_оборудования";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название_оборудования";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип_оборудования";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип_оборудования";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата производства";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата производства";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Тип оборудования";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(169, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 24);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.placeHolderTextBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 173);
            this.panel1.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(288, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 26);
            this.button6.TabIndex = 7;
            this.button6.Text = "Выход";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.типоборудованияBindingSource;
            this.comboBox1.DisplayMember = "Тип_оборудования";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Тип_оборудования";
            // 
            // типоборудованияBindingSource
            // 
            this.типоборудованияBindingSource.DataMember = "Тип_оборудования";
            this.типоборудованияBindingSource.DataSource = this.serviceDataSet;
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(142, 8);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "Введите тип оборудования";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(188, 20);
            this.placeHolderTextBox1.TabIndex = 3;
            this.placeHolderTextBox1.Text = "Введите название оборудования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата производства";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип оборудования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название оборудования";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(320, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 24);
            this.button7.TabIndex = 8;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // тип_оборудованияTableAdapter
            // 
            this.тип_оборудованияTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.placeHolderTextBox2);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Location = new System.Drawing.Point(224, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 61);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // placeHolderTextBox2
            // 
            this.placeHolderTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox2.Location = new System.Drawing.Point(126, 4);
            this.placeHolderTextBox2.Name = "placeHolderTextBox2";
            this.placeHolderTextBox2.PlaceHolderText = "Введите фильтр";
            this.placeHolderTextBox2.Size = new System.Drawing.Size(100, 20);
            this.placeHolderTextBox2.TabIndex = 4;
            this.placeHolderTextBox2.Text = "Введите фильтр";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(132, 32);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Сброс";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(4, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Фильтр";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Тип_оборудования"});
            this.comboBox2.Location = new System.Drawing.Point(4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 27);
            this.button3.TabIndex = 10;
            this.button3.Text = "Фильтрация";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Оборудование
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 316);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.оборудованиеDataGridView);
            this.Name = "Оборудование";
            this.Text = "Оборудование";
            this.Load += new System.EventHandler(this.Outfit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типоборудованияBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ServiceDataSet serviceDataSet;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        private ServiceDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView оборудованиеDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource типоборудованияBindingSource;
        private ServiceDataSetTableAdapters.Тип_оборудованияTableAdapter тип_оборудованияTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox2;
    }
}