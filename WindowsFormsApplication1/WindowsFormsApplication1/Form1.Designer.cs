namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label тип_оборудованияLabel1;
            this.button1 = new System.Windows.Forms.Button();
            this.тип_оборудованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceDataSet = new WindowsFormsApplication1.ServiceDataSet();
            this.тип_оборудованияTableAdapter = new WindowsFormsApplication1.ServiceDataSetTableAdapters.Тип_оборудованияTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ServiceDataSetTableAdapters.TableAdapterManager();
            this.placeHolderTextBox1 = new System.Windows.Forms.PlaceHolderTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            тип_оборудованияLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.тип_оборудованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // тип_оборудованияLabel1
            // 
            тип_оборудованияLabel1.AutoSize = true;
            тип_оборудованияLabel1.Location = new System.Drawing.Point(26, 19);
            тип_оборудованияLabel1.Name = "тип_оборудованияLabel1";
            тип_оборудованияLabel1.Size = new System.Drawing.Size(103, 13);
            тип_оборудованияLabel1.TabIndex = 2;
            тип_оборудованияLabel1.Text = "Тип оборудования:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить и сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.placeHolderTextBox1.Location = new System.Drawing.Point(135, 19);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "Введите тип оборудования";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(152, 20);
            this.placeHolderTextBox1.TabIndex = 3;
            this.placeHolderTextBox1.Text = "Введите тип оборудования";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.placeHolderTextBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(тип_оборудованияLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 165);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.тип_оборудованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ServiceDataSet serviceDataSet;
        private System.Windows.Forms.BindingSource тип_оборудованияBindingSource;
        private ServiceDataSetTableAdapters.Тип_оборудованияTableAdapter тип_оборудованияTableAdapter;
        private ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PlaceHolderTextBox placeHolderTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}