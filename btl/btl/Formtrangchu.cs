using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl.Xulydulieu.Xuthithongtintaikhoan;

namespace btl
{
 
    public partial class Formtrangchu : Form
    {
        public string tennguoisd;
        public string Tennguoisd
        {
            get { return tennguoisd; }
            set { tennguoisd = value; }
        }
        public Formtrangchu()
        {
            InitializeComponent();
        }
        formhethong amation1 = new formhethong();
        Formchucnangachocsinh formchucnang = new Formchucnangachocsinh();
        formitemthongtintaikhoan formtt = new formitemthongtintaikhoan();
        formTimkiem formtk = new formTimkiem();
        Xulydulieu.Xulydangnhap.Dangnhap xldn = new Xulydulieu.Xulydangnhap.Dangnhap();
        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hệThốngToolStripMenuItem.BackColor = Color.LightGray;
            chứcNăngToolStripMenuItem.BackColor = Color.White;
            tìmKiếmToolStripMenuItem.BackColor = Color.White;
            thôngTinPhầnMềmToolStripMenuItem.BackColor = Color.White;
            formchucnang.Hide();
            formtt.Hide();
            formtk.Hide();

            amation1.TopLevel = false;
            panel1.Controls.Add(amation1);
            amation1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            amation1.Show();
            btn_Dangxuat.Visible = true;
            label2.Visible = true;

            tennguoisd = Properties.Settings.Default.tennguoisudung;
            label2.Text = tennguoisd;
        }
        
        public void FormTrangchu_Load(object sender, EventArgs e)
        {
            
            hệThốngToolStripMenuItem.BackColor = Color.LightGray;
            chứcNăngToolStripMenuItem.BackColor = Color.White;
            tìmKiếmToolStripMenuItem.BackColor = Color.White;
            thôngTinPhầnMềmToolStripMenuItem.BackColor = Color.White;
            amation1.TopLevel = false;
            panel1.Controls.Add(amation1);
            amation1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            amation1.Show();
            tennguoisd = Properties.Settings.Default.tennguoisudung;
            label2.Text = tennguoisd;
            int ltk = Properties.Settings.Default.loaitaikhoan;
            if (ltk == 2)
            {
                tìmKiếmToolStripMenuItem.Enabled = false;
            }

        }
      
        public void FormTrangchu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
                    this.Close();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hệThốngToolStripMenuItem.BackColor = Color.White;
            chứcNăngToolStripMenuItem.BackColor = Color.White;
            tìmKiếmToolStripMenuItem.BackColor = Color.White;
            thôngTinPhầnMềmToolStripMenuItem.BackColor = Color.LightGray;
            formchucnang.Hide();
            amation1.Hide();
            formtk.Hide();


            btn_Dangxuat.Visible = false;
            label2.Visible = false;

            formtt.TopLevel = false;
            panel1.Controls.Add(formtt);
            formtt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            formtt.Show();
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            hệThốngToolStripMenuItem.BackColor = Color.White;
            chứcNăngToolStripMenuItem.BackColor = Color.LightGray;
            tìmKiếmToolStripMenuItem.BackColor = Color.White;
            thôngTinPhầnMềmToolStripMenuItem.BackColor = Color.White;
            amation1.Hide();
            formtt.Hide();
            formtk.Hide();



            btn_Dangxuat.Visible = false;
            label2.Visible = false;

            formchucnang.TopLevel = false;
            panel1.Controls.Add(formchucnang);
            formchucnang.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            formchucnang.Show();
           
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hệThốngToolStripMenuItem.BackColor = Color.White;
            chứcNăngToolStripMenuItem.BackColor = Color.White;
            tìmKiếmToolStripMenuItem.BackColor = Color.LightGray;
            thôngTinPhầnMềmToolStripMenuItem.BackColor = Color.White;
            amation1.Hide();
            formtt.Hide();
            formchucnang.Hide();

            btn_Dangxuat.Visible = false;
            label2.Visible = false;

            formtk.TopLevel = false;
            panel1.Controls.Add(formtk);
            formtk.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            formtk.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    }

      
    

