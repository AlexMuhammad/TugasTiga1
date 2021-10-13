using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class frmTugasTiga1 : Form
    {
        public frmTugasTiga1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            lblNim.Text = "20.11.3567";
            lblNama.Text = "Muh. Alex Saputra";
            lblKelas.Text = "IF05";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblKelas.Text = "";
            lblNim.Text = "";
            lblNama.Text = "";

        }
    }
}
