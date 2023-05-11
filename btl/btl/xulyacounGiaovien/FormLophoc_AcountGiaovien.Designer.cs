
namespace btl.xulyacounGiaovien
{
    partial class FormLophoc_AcountGiaovien
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
            this.nMalop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slsv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nMalop,
            this.nTenlophoc,
            this.nTenmonhoc,
            this.slsv});
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(390, 274);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nMalop
            // 
            this.nMalop.DataPropertyName = "nMalop";
            this.nMalop.HeaderText = "Mã lớp";
            this.nMalop.Name = "nMalop";
            this.nMalop.ReadOnly = true;
            // 
            // nTenlophoc
            // 
            this.nTenlophoc.DataPropertyName = "nTenlophoc";
            this.nTenlophoc.HeaderText = "Tên lớp học";
            this.nTenlophoc.Name = "nTenlophoc";
            this.nTenlophoc.ReadOnly = true;
            this.nTenlophoc.Width = 160;
            // 
            // nTenmonhoc
            // 
            this.nTenmonhoc.DataPropertyName = "nTenmonhoc";
            this.nTenmonhoc.HeaderText = "Tên môn học";
            this.nTenmonhoc.Name = "nTenmonhoc";
            this.nTenmonhoc.ReadOnly = true;
            this.nTenmonhoc.Width = 140;
            // 
            // slsv
            // 
            this.slsv.DataPropertyName = "slsv";
            this.slsv.HeaderText = "Sĩ số";
            this.slsv.Name = "slsv";
            this.slsv.ReadOnly = true;
            this.slsv.Width = 140;
            // 
            // FormLophoc_AcountGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 288);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLophoc_AcountGiaovien";
            this.Text = "Formchucnang_Lophoc_AcountGiaovien";
            this.Load += new System.EventHandler(this.FormLophoc_AcountGiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMalop;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTenlophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn slsv;
    }
}