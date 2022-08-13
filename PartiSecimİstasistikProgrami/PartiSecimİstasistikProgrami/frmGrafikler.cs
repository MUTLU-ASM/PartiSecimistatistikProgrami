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
    public partial class frmGrafikler : Form
    {
        public frmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SBTQ48V\SQLEXPRESS;Initial Catalog=secimVT;Integrated Security=True");
        private void lblGeriDon_Click(object sender, EventArgs e)
        {
            frmAnasayfa frm = new frmAnasayfa();
            this.Hide();
            frm.Show();
        }

        private void frmGrafikler_Load(object sender, EventArgs e)
        {
            //İlçe adlarını comboboxa çekme

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ilcead from ilce", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Items.Add(dr[0]);
            }
            baglanti.Close();

            //Grafiğe Toplam Sonuçları Getirme

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(aparti),sum(bparti),sum(cparti),sum(dparti),sum(eparti) from ilce", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A parti",dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E parti", dr2[4]);
            }
            baglanti.Close();
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from ilce where ilcead=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbIlce.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                prgAparti.Value = int.Parse(dr[2].ToString());
                prgBparti.Value = int.Parse(dr[3].ToString());
                prgCparti.Value = int.Parse(dr[4].ToString());
                prgDparti.Value = int.Parse(dr[5].ToString());
                prgEparti.Value = int.Parse(dr[6].ToString());

                lblA.Text = dr[2].ToString();
                lblB.Text = dr[3].ToString();
                lblC.Text = dr[4].ToString();
                lblD.Text = dr[5].ToString();
                lblE.Text = dr[6].ToString();
            }
            baglanti.Close();
        }
    }
}
