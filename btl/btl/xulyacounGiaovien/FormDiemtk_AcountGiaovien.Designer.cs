
namespace btl.xulyacounGiaovien
{
    partial class FormDiemtk_AcountGiaovien
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
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nMasv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trungbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "Báo cáo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nMasv,
            this.nTensv,
            this.Trungbinh,
            this.danhhieu});
            this.dataGridView1.Location = new System.Drawing.Point(4, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(406, 224);
            this.dataGridView1.TabIndex = 16;
            // 
            // nMasv
            // 
            this.nMasv.DataPropertyName = "nMasv";
            this.nMasv.HeaderText = "Mã học sinh";
            this.nMasv.Name = "nMasv";
            this.nMasv.ReadOnly = true;
            this.nMasv.Width = 140;
            // 
            // nTensv
            // 
            this.nTensv.DataPropertyName = "nTensv";
            this.nTensv.HeaderText = "Tên học sinh";
            this.nTensv.Name = "nTensv";
            this.nTensv.ReadOnly = true;
            this.nTensv.Width = 180;
            // 
            // Trungbinh
            // 
            this.Trungbinh.DataPropertyName = "Trungbinh";
            this.Trungbinh.HeaderText = "Trung bình";
            this.Trungbinh.Name = "Trungbinh";
            this.Trungbinh.ReadOnly = true;
            this.Trungbinh.Width = 140;
            // 
            // danhhieu
            // 
            this.danhhieu.DataPropertyName = "danhhieu";
            this.danhhieu.HeaderText = "Đạt";
            this.danhhieu.Name = "danhhieu";
            this.danhhieu.ReadOnly = true;
            // 
            // FormDiemtk_AcountGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 288);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Name = "FormDiemtk_AcountGiaovien";
            this.Text = "Formchucnang_Diemtk_AcountGiaovien";
            this.Load += new System.EventHandler(this.FormDiemtk_AcountGiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trungbinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhhieu;
    }
}