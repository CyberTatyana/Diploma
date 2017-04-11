namespace WindowsFormsApplication1
{
    partial class Ремонт_оборудования
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
            this.ремонт_оборудованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ремонт_оборудованияTableAdapter = new WindowsFormsApplication1.ServiceDataSetTableAdapters.Ремонт_оборудованияTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ServiceDataSetTableAdapters.TableAdapterManager();
            this.оборудованиеTableAdapter = new WindowsFormsApplication1.ServiceDataSetTableAdapters.ОборудованиеTableAdapter();
            this.ремонтTableAdapter = new WindowsFormsApplication1.ServiceDataSetTableAdapters.РемонтTableAdapter();
            this.ремонт_оборудованияDataGridView = new System.Windows.Forms.DataGridView();
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_оборудованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_оборудованияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceDataSet
            // 
            this.serviceDataSet.DataSetName = "ServiceDataSet";
            this.serviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ремонт_оборудованияBindingSource
            // 
            this.ремонт_оборудованияBindingSource.DataMember = "Ремонт_оборудования";
            this.ремонт_оборудованияBindingSource.DataSource = this.serviceDataSet;
            // 
            // ремонт_оборудованияTableAdapter
            // 
            this.ремонт_оборудованияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = this.оборудованиеTableAdapter;
            this.tableAdapterManager.Ремонт_оборудованияTableAdapter = this.ремонт_оборудованияTableAdapter;
            this.tableAdapterManager.РемонтTableAdapter = this.ремонтTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тип_оборудованияTableAdapter = null;
            // 
            // оборудованиеTableAdapter
            // 
            this.оборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // ремонтTableAdapter
            // 
            this.ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // ремонт_оборудованияDataGridView
            // 
            this.ремонт_оборудованияDataGridView.AutoGenerateColumns = false;
            this.ремонт_оборудованияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ремонт_оборудованияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ремонт_оборудованияDataGridView.DataSource = this.ремонт_оборудованияBindingSource;
            this.ремонт_оборудованияDataGridView.Location = new System.Drawing.Point(12, 29);
            this.ремонт_оборудованияDataGridView.Name = "ремонт_оборудованияDataGridView";
            this.ремонт_оборудованияDataGridView.Size = new System.Drawing.Size(346, 148);
            this.ремонт_оборудованияDataGridView.TabIndex = 1;
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.serviceDataSet;
            // 
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataMember = "Ремонт";
            this.ремонтBindingSource.DataSource = this.serviceDataSet;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Оборудование";
            this.dataGridViewTextBoxColumn1.DataSource = this.оборудованиеBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Название_оборудования";
            this.dataGridViewTextBoxColumn1.HeaderText = "Оборудование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ремонт";
            this.dataGridViewTextBoxColumn2.DataSource = this.ремонтBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ремонт";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Ремонт_оборудования
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 212);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ремонт_оборудованияDataGridView);
            this.Name = "Ремонт_оборудования";
            this.Text = "Смета";
            this.Load += new System.EventHandler(this.Repair_of_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_оборудованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонт_оборудованияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ServiceDataSet serviceDataSet;
        private System.Windows.Forms.BindingSource ремонт_оборудованияBindingSource;
        private ServiceDataSetTableAdapters.Ремонт_оборудованияTableAdapter ремонт_оборудованияTableAdapter;
        private ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ремонт_оборудованияDataGridView;
        private ServiceDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        private ServiceDataSetTableAdapters.РемонтTableAdapter ремонтTableAdapter;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}