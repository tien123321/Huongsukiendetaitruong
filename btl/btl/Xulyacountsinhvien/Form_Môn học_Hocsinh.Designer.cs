
namespace btl.Xulyacountsinhvien
{
    partial class Formchucnang_Môn_học
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
            this.nTenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemmieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem1tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemhocki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nTenmonhoc,
            this.Diemmieng,
            this.Diem15phut,
            this.Diem1tiet,
            this.Diemhocki,
            this.Diemthi});
            this.dataGridView1.Location = new System.Drawing.Point(4, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(406, 264);
            this.dataGridView1.TabIndex = 16;
            // 
            // nTenmonhoc
            // 
            this.nTenmonhoc.DataPropertyName = "nTenmonhoc";
            this.nTenmonhoc.HeaderText = "Tên môn học";
            this.nTenmonhoc.Name = "nTenmonhoc";
            this.nTenmonhoc.ReadOnly = true;
            this.nTenmonhoc.Width = 170;
            // 
            // Diemmieng
            // 
            this.Diemmieng.DataPropertyName = "Diemmieng";
            this.Diemmieng.HeaderText = "Điểm miệng";
            this.Diemmieng.Name = "Diemmieng";
            this.Diemmieng.ReadOnly = true;
            this.Diemmieng.Width = 60;
            // 
            // Diem15phut
            // 
            this.Diem15phut.DataPropertyName = "Diem15phut";
            this.Diem15phut.HeaderText = "Điểm 15 phút";
            this.Diem15phut.Name = "Diem15phut";
            this.Diem15phut.ReadOnly = true;
            this.Diem15phut.Width = 60;
            // 
            // Diem1tiet
            // 
            this.Diem1tiet.DataPropertyName = "Diem1tiet";
            this.Diem1tiet.HeaderText = "Điểm 1 tiết";
            this.Diem1tiet.Name = "Diem1tiet";
            this.Diem1tiet.ReadOnly = true;
            this.Diem1tiet.Width = 60;
            // 
            // Diemhocki
            // 
            this.Diemhocki.DataPropertyName = "Diemhocki";
            this.Diemhocki.HeaderText = "Điểm học kì";
            this.Diemhocki.Name = "Diemhocki";
            this.Diemhocki.ReadOnly = true;
            this.Diemhocki.Width = 80;
            // 
            // Diemthi
            // 
            this.Diemthi.DataPropertyName = "Diemthi";
            this.Diemthi.HeaderText = "Điểm thi";
            this.Diemthi.Name = "Diemthi";
            this.Diemthi.ReadOnly = true;
            this.Diemthi.Width = 80;
            // 
            // Formchucnang_Môn_học
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 288);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Formchucnang_Môn_học";
            this.Text = "Formchucnang_Môn_học";
            this.Load += new System.EventHandler(this.Formchucnang_Môn_học_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemmieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem1tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemhocki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemthi;
    }
}