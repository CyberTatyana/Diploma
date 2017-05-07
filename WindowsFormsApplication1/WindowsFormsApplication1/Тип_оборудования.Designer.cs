namespace WindowsFormsApplication1
{
    partial class Тип_оборудования
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
            System.Windows.Forms.Label тип_оборудованияLabel1;
            this.тип_оборудованияDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тип_оборудованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceDataSet = new WindowsFormsApplication1.ServiceDataSet();
            this.тип_оборудованияTableAdapter = new WindowsFormsApplication1.ServiceDataSetTableAdapters.Тип_оборудованияTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ServiceDataSetTableAdapters.TableAdapterManager();
            this.placeHolderTextBox1 = new System.Windows.Forms.PlaceHolderTextBox();
            тип_оборудованияLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.тип_оборудованияDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.тип_оборудованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // тип_оборудованияDataGridView
            // 
            this.тип_оборудованияDataGridView.AutoGenerateColumns = false;
            this.тип_оборудованияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.тип_оборудованияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.тип_оборудованияDataGridView.DataSource = this.тип_оборудованияBindingSource;
            this.тип_оборудованияDataGridView.Location = new System.Drawing.Point(12, 38);
            this.тип_оборудованияDataGridView.Name = "тип_оборудованияDataGridView";
            this.тип_оборудованияDataGridView.Size = new System.Drawing.Size(280, 124);
            this.тип_оборудованияDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.placeHolderTextBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(тип_оборудованияLabel1);
            this.panel1.Location = new System.Drawing.Point(12, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 100);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 24);
            this.button4.TabIndex = 5;
            this.button4.Text = "Добавить и сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // тип_оборудованияLabel1
            // 
            тип_оборудованияLabel1.AutoSize = true;
            тип_оборудованияLabel1.Location = new System.Drawing.Point(9, 18);
            тип_оборудованияLabel1.Name = "тип_оборудованияLabel1";
            тип_оборудованияLabel1.Size = new System.Drawing.Size(103, 13);
            тип_оборудованияLabel1.TabIndex = 6;
            тип_оборудованияLabel1.Text = "Тип оборудования:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(244, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Тип_оборудования";
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип_оборудования";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // тип_оборудованияBindingSource
            // 
            this.тип_оборудованияBindingSource.DataMember = "Тип_оборудования";
            this.тип_оборудованияBindingSource.DataSource = this.serviceDataSet;
            // 
            // serviceDataSet
            // 
            this.serviceDataSet.DataSetName = "ServiceDataSet";
            this.serviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тип_оборудованияTableAdapter
            // 
            this.тип_оборудованияTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тип_оборудованияTableAdapter = this.тип_оборудованияTableAdapter;
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(118, 18);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "Введите тип оборудования";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(152, 20);
            this.placeHolderTextBox1.TabIndex = 7;
            this.placeHolderTextBox1.Text = "Введите тип оборудования";
            // 
            // Тип_оборудования
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 209);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.тип_оборудованияDataGridView);
            this.Name = "Тип_оборудования";
            this.Text = "Тип оборудования";
            this.Load += new System.EventHandler(this.Type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.тип_оборудованияDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.тип_оборудованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ServiceDataSet serviceDataSet;
        private System.Windows.Forms.BindingSource тип_оборудованияBindingSource;
        private ServiceDataSetTableAdapters.Тип_оборудованияTableAdapter тип_оборудованияTableAdapter;
        private ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView тип_оборудованияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}