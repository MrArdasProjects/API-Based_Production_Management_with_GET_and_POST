namespace Partnera
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button_List = new System.Windows.Forms.Button();
            this.Button_Uretim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1827, 717);
            this.dataGridView1.TabIndex = 0;
            // 
            // Button_List
            // 
            this.Button_List.BackColor = System.Drawing.Color.Silver;
            this.Button_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_List.ForeColor = System.Drawing.Color.Black;
            this.Button_List.Location = new System.Drawing.Point(12, 76);
            this.Button_List.Name = "Button_List";
            this.Button_List.Size = new System.Drawing.Size(239, 88);
            this.Button_List.TabIndex = 1;
            this.Button_List.Text = "İş Emri Listele";
            this.Button_List.UseVisualStyleBackColor = false;
            this.Button_List.Click += new System.EventHandler(this.Button_List_Click);
            // 
            // Button_Uretim
            // 
            this.Button_Uretim.BackColor = System.Drawing.Color.Silver;
            this.Button_Uretim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_Uretim.ForeColor = System.Drawing.Color.Black;
            this.Button_Uretim.Location = new System.Drawing.Point(275, 76);
            this.Button_Uretim.Name = "Button_Uretim";
            this.Button_Uretim.Size = new System.Drawing.Size(239, 88);
            this.Button_Uretim.TabIndex = 2;
            this.Button_Uretim.Text = "Üretim";
            this.Button_Uretim.UseVisualStyleBackColor = false;
            this.Button_Uretim.Click += new System.EventHandler(this.Button_Uretim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1881, 913);
            this.Controls.Add(this.Button_Uretim);
            this.Controls.Add(this.Button_List);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button_List;
        private System.Windows.Forms.Button Button_Uretim;
    }
}

