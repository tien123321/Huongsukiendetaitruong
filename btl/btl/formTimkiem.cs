using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl.Chức_năng_tìm_kiếm.formTimkiem;

namespace btl
{
    public partial class formTimkiem : Form
    {
      
       
        formloadtimkiem loadform = new formloadtimkiem();

        public formTimkiem()
        {
            InitializeComponent();
        }
        public void loadform1()
        {

            loadform.TopLevel = false;
            panel3.Controls.Add(loadform);
            loadform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            loadform.Show();

        }
        private void formTimkiem_Load(object sender, EventArgs e)
        {
            loadform1();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
