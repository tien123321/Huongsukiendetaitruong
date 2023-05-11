
namespace btl.Xulyacountadmin.formxuly
{
    partial class Timgiavienadmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_Ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.tb_Ma = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giáo viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên giáo viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính : ";
            // 
            // mtb_Ngaysinh
            // 
            this.mtb_Ngaysinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_Ngaysinh.Location = new System.Drawing.Point(186, 127);
            this.mtb_Ngaysinh.Mask = "00/00/0000";
            this.mtb_Ngaysinh.Name = "mtb_Ngaysinh";
            this.mtb_Ngaysinh.Size = new System.Drawing.Size(170, 29);
            this.mtb_Ngaysinh.TabIndex = 5;
            this.mtb_Ngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // tb_Ma
            // 
            this.tb_Ma.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ma.Location = new System.Drawing.Point(186, 22);
            this.tb_Ma.Name = "tb_Ma";
            this.tb_Ma.Size = new System.Drawing.Size(170, 29);
            this.tb_Ma.TabIndex = 6;
            // 
            // tb_ten
            // 
            this.tb_ten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten.Location = new System.Drawing.Point(186, 66);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(170, 29);
            this.tb_ten.TabIndex = 7;
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nam.Location = new System.Drawing.Point(171, 184);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(68, 27);
            this.rb_Nam.TabIndex = 8;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Checked = true;
            this.rb_Nu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nu.Location = new System.Drawing.Point(275, 185);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(54, 27);
            this.rb_Nu.TabIndex = 9;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(220, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Timgiavienadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 416);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_Nu);
            this.Controls.Add(this.rb_Nam);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_Ma);
            this.Controls.Add(this.mtb_Ngaysinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Timgiavienadmin";
            this.Text = "Timgiavienadmin";
            this.Load += new System.EventHandler(this.Timgiavienadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtb_Ngaysinh;
        private System.Windows.Forms.TextBox tb_Ma;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}