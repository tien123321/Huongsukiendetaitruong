
namespace btl.xulyacounGiaovien
{
    partial class FormMonhoc_Acountgiaovien
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
            this.nTenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemmieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem1tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemhocki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.nTenmonhoc,
            this.Diemmieng,
            this.Diem15phut,
            this.Diem1tiet,
            this.Diemhocki,
            this.Diemthi});
            this.dataGridView1.Location = new System.Drawing.Point(4, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(406, 212);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nMasv
            // 
            this.nMasv.DataPropertyName = "nMasv";
            this.nMasv.HeaderText = "Mã học sinh";
            this.nMasv.Name = "nMasv";
            this.nMasv.ReadOnly = true;
            this.nMasv.Width = 50;
            // 
            // nTensv
            // 
            this.nTensv.DataPropertyName = "nTensv";
            this.nTensv.HeaderText = "Tên học sinh";
            this.nTensv.Name = "nTensv";
            this.nTensv.ReadOnly = true;
            this.nTensv.Width = 130;
            // 
            // nTenmonhoc
            // 
            this.nTenmonhoc.DataPropertyName = "nTenmonhoc";
            this.nTenmonhoc.HeaderText = "Tên môn học";
            this.nTenmonhoc.Name = "nTenmonhoc";
            this.nTenmonhoc.ReadOnly = true;
            this.nTenmonhoc.Width = 70;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 17;
            this.button4.Text = "Báo cáo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "Xem toàn bộ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormMonhoc_Acountgiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 288);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMonhoc_Acountgiaovien";
            this.Text = "FormChucnang_Monhoc_Acountgiaovien";
            this.Load += new System.EventHandler(this.FormMonhoc_Acountgiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemmieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem1tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemhocki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemthi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}