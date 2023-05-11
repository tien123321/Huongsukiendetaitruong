
namespace btl.Xulyacountadmin.formxuly
{
    partial class Themvaupdategiaovien
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
            this.components = new System.ComponentModel.Container();
            this.cb_Gioitinh = new System.Windows.Forms.CheckBox();
            this.dtpk_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_tensgv = new System.Windows.Forms.TextBox();
            this.tb_Magv = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Gioitinh
            // 
            this.cb_Gioitinh.AutoSize = true;
            this.cb_Gioitinh.Checked = true;
            this.cb_Gioitinh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Gioitinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Gioitinh.Location = new System.Drawing.Point(164, 158);
            this.cb_Gioitinh.Name = "cb_Gioitinh";
            this.cb_Gioitinh.Size = new System.Drawing.Size(64, 25);
            this.cb_Gioitinh.TabIndex = 27;
            this.cb_Gioitinh.Text = "Nam";
            this.cb_Gioitinh.UseVisualStyleBackColor = true;
            // 
            // dtpk_Ngaysinh
            // 
            this.dtpk_Ngaysinh.CustomFormat = "dd-MM-yyyy";
            this.dtpk_Ngaysinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_Ngaysinh.Location = new System.Drawing.Point(164, 112);
            this.dtpk_Ngaysinh.Name = "dtpk_Ngaysinh";
            this.dtpk_Ngaysinh.Size = new System.Drawing.Size(180, 29);
            this.dtpk_Ngaysinh.TabIndex = 26;
            // 
            // tb_tensgv
            // 
            this.tb_tensgv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tensgv.Location = new System.Drawing.Point(164, 73);
            this.tb_tensgv.Name = "tb_tensgv";
            this.tb_tensgv.Size = new System.Drawing.Size(180, 29);
            this.tb_tensgv.TabIndex = 23;
            // 
            // tb_Magv
            // 
            this.tb_Magv.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tb_Magv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Magv.Location = new System.Drawing.Point(164, 26);
            this.tb_Magv.Name = "tb_Magv";
            this.tb_Magv.Size = new System.Drawing.Size(180, 29);
            this.tb_Magv.TabIndex = 22;
            this.tb_Magv.TextChanged += new System.EventHandler(this.tb_Magv_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(132, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(132, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giới tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngày sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Giáo viên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã giao viên :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Themvaupdategiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 396);
            this.Controls.Add(this.cb_Gioitinh);
            this.Controls.Add(this.dtpk_Ngaysinh);
            this.Controls.Add(this.tb_tensgv);
            this.Controls.Add(this.tb_Magv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Themvaupdategiaovien";
            this.Text = "Themvaupdategiaovien";
            this.Load += new System.EventHandler(this.Themvaupdategiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Gioitinh;
        private System.Windows.Forms.DateTimePicker dtpk_Ngaysinh;
        private System.Windows.Forms.TextBox tb_tensgv;
        private System.Windows.Forms.TextBox tb_Magv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}