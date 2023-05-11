
namespace btl.Xulyacountadmin
{
    partial class FormDiemtk_AcountAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nMasv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trungbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(406, 263);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // FormDiemtk_AcountAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 288);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDiemtk_AcountAdmin";
            this.Text = "Formchucnang_Diemtk_AcountAdmin";
            this.Load += new System.EventHandler(this.FormDiemtk_AcountAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trungbinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhhieu;
    }
}