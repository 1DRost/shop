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
            this.accept = new System.Windows.Forms.Button();
            this.deliver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.recipient,
            this.address,
            this.deliveryDate});
            this.dataGridView1.Location = new System.Drawing.Point(80, 34);
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
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 40;
            // 
            // recipient
            // 
            this.recipient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.recipient.HeaderText = "Получатель";
            this.recipient.MinimumWidth = 6;
            this.recipient.Name = "recipient";
            this.recipient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.recipient.Width = 125;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.address.HeaderText = "Адрес";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.address.Width = 250;
            // 
            // deliveryDate
            // 
            this.deliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deliveryDate.HeaderText = "Дата доставки";
            this.deliveryDate.MinimumWidth = 6;
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deliveryDate.Width = 130;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button deliver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipient;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDate;
    }
}

