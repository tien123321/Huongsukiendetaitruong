﻿
namespace btl.xulyacounGiaovien
{
    partial class FormHocsinh_AcountGiaovien
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
            this.dNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.dNgaysinh,
            this.nGioitinh,
            this.nDiachi,
            this.nTenlophoc});
            this.dataGridView1.Location = new System.Drawing.Point(4, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(406, 212);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nMasv
            // 
            this.nMasv.DataPropertyName = "nMasv";
            this.nMasv.HeaderText = "Mã học sinh";
            this.nMasv.Name = "nMasv";
            this.nMasv.ReadOnly = true;
            this.nMasv.Width = 60;
            // 
            // nTensv
            // 
            this.nTensv.DataPropertyName = "nTensv";
            this.nTensv.HeaderText = "Tên học sinh";
            this.nTensv.Name = "nTensv";
            this.nTensv.ReadOnly = true;
            this.nTensv.Width = 140;
            // 
            // dNgaysinh
            // 
            this.dNgaysinh.DataPropertyName = "dNgaysinh";
            this.dNgaysinh.HeaderText = "Ngày sinh";
            this.dNgaysinh.Name = "dNgaysinh";
            this.dNgaysinh.ReadOnly = true;
            // 
            // nGioitinh
            // 
            this.nGioitinh.DataPropertyName = "nGioitinh";
            this.nGioitinh.HeaderText = "Giới tính";
            this.nGioitinh.Name = "nGioitinh";
            this.nGioitinh.ReadOnly = true;
            this.nGioitinh.Width = 60;
            // 
            // nDiachi
            // 
            this.nDiachi.DataPropertyName = "nDiachi";
            this.nDiachi.HeaderText = "Địa chỉ";
            this.nDiachi.Name = "nDiachi";
            this.nDiachi.ReadOnly = true;
            this.nDiachi.Width = 120;
            // 
            // nTenlophoc
            // 
            this.nTenlophoc.DataPropertyName = "nTenlophoc";
            this.nTenlophoc.HeaderText = "Tên lớp";
            this.nTenlophoc.Name = "nTenlophoc";
            this.nTenlophoc.ReadOnly = true;
            this.nTenlophoc.Width = 80;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(229, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "Báo cáo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "Xem toàn bộ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormHocsinh_AcountGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 288);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormHocsinh_AcountGiaovien";
            this.Text = "Formchucnang_Hocsinh_AcountGiaovien";
            this.Load += new System.EventHandler(this.FormHocsinh_AcountGiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTenlophoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}