
namespace btl.Xulyacountadmin
{
    partial class FormLop_acountAdmin
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nMalop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoihoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(306, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Lớp 9";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Lớp 8";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Lớp 7";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Lớp 6";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nMalop,
            this.nTenlophoc,
            this.Khoihoc,
            this.siso});
            this.dataGridView1.Location = new System.Drawing.Point(4, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(406, 212);
            this.dataGridView1.TabIndex = 15;
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
            // Khoihoc
            // 
            this.Khoihoc.DataPropertyName = "Khoihoc";
            this.Khoihoc.HeaderText = "Khối hoc";
            this.Khoihoc.Name = "Khoihoc";
            this.Khoihoc.ReadOnly = true;
            this.Khoihoc.Width = 140;
            // 
            // siso
            // 
            this.siso.DataPropertyName = "siso";
            this.siso.HeaderText = "Sĩ số";
            this.siso.Name = "siso";
            this.siso.ReadOnly = true;
            this.siso.Width = 140;
            // 
            // FormLop_acountAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 288);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLop_acountAdmin";
            this.Text = "FormChucnang_Lop_acountAdmin";
            this.Load += new System.EventHandler(this.FormLop_acountAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMalop;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTenlophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoihoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn siso;
    }
}