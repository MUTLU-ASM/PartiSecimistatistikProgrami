using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PartiSecimİstasistikProgrami
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SBTQ48V\SQLEXPRESS;Initial Catalog=secimVT;Integrated Security=True");
        private void btnOy_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ilce(ilcead,aparti,bparti,cparti,dparti,eparti) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1",txtİlceadi.Text);
            komut.Parameters.AddWithValue("@p2", txtAparti.Text);
            komut.Parameters.AddWithValue("@p3", txtBparti.Text);
            komut.Parameters.AddWithValue("@p4", txtCparti.Text);
            komut.Parameters.AddWithValue("@p5", txtDparti.Text);
            komut.Parameters.AddWithValue("@p6", txtEparti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti.");
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            frmGrafikler frm = new frmGrafikler();
            this.Hide();
            frm.Show();
            
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
