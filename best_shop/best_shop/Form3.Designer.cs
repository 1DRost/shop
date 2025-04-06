namespace best_shop
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.mDKDataSet = new best_shop.MDKDataSet();
            this.mDKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статусзаказаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статус_заказаTableAdapter = new best_shop.MDKDataSetTableAdapters.Статус_заказаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусзаказаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(77, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статусы заказов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 321);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::best_shop.Properties.Resources.png_transparent_arrow;
            this.button1.Location = new System.Drawing.Point(2, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 48);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mDKDataSet
            // 
            this.mDKDataSet.DataSetName = "MDKDataSet";
            this.mDKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDKDataSetBindingSource
            // 
            this.mDKDataSetBindingSource.DataSource = this.mDKDataSet;
            this.mDKDataSetBindingSource.Position = 0;
            // 
            // статусзаказаBindingSource
            // 
            this.статусзаказаBindingSource.DataMember = "Статус_заказа";
            this.статусзаказаBindingSource.DataSource = this.mDKDataSetBindingSource;
            // 
            // статус_заказаTableAdapter
            // 
            this.статус_заказаTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусзаказаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource mDKDataSetBindingSource;
        private MDKDataSet mDKDataSet;
        private System.Windows.Forms.BindingSource статусзаказаBindingSource;
        private MDKDataSetTableAdapters.Статус_заказаTableAdapter статус_заказаTableAdapter;
    }
}