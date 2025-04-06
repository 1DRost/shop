namespace best_shop
{
    partial class Form1
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
            this.accept = new System.Windows.Forms.Button();
            this.deliver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.mDKDataSet = new best_shop.MDKDataSet();
            this.покупательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупательTableAdapter = new best_shop.MDKDataSetTableAdapters.ПокупательTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупательBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.LightCyan;
            this.accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accept.ForeColor = System.Drawing.Color.Black;
            this.accept.Location = new System.Drawing.Point(80, 350);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(300, 60);
            this.accept.TabIndex = 0;
            this.accept.Text = "ЗАКАЗ ПРИНЯТ";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // deliver
            // 
            this.deliver.BackColor = System.Drawing.Color.LightCyan;
            this.deliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deliver.Location = new System.Drawing.Point(386, 350);
            this.deliver.Name = "deliver";
            this.deliver.Size = new System.Drawing.Size(300, 60);
            this.deliver.TabIndex = 1;
            this.deliver.Text = "ЗАКАЗ ДОСТАВЛЕН";
            this.deliver.UseVisualStyleBackColor = false;
            this.deliver.Click += new System.EventHandler(this.deliver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 292);
            this.dataGridView1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Image = global::best_shop.Properties.Resources.png_transparent_arrow;
            this.button3.Location = new System.Drawing.Point(2, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 53);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mDKDataSet
            // 
            this.mDKDataSet.DataSetName = "MDKDataSet";
            this.mDKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // покупательBindingSource
            // 
            this.покупательBindingSource.DataMember = "Покупатель";
            this.покупательBindingSource.DataSource = this.mDKDataSet;
            // 
            // покупательTableAdapter
            // 
            this.покупательTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deliver);
            this.Controls.Add(this.accept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупательBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button deliver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private MDKDataSet mDKDataSet;
        private System.Windows.Forms.BindingSource покупательBindingSource;
        private MDKDataSetTableAdapters.ПокупательTableAdapter покупательTableAdapter;
    }
}

