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

namespace VERILER_SIFRELEME
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbSifrelemeSifreCozme;Integrated Security=True;Encrypt=False;");

        void listele()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_SIFRE_VERILER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }



        void listeleSifresiz()
        {
            // Clear previous columns and rows
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            // Add columns if not already present
            dataGridView2.Columns.Add("AD", "Ad");
            dataGridView2.Columns.Add("SOYAD", "Soyad");
            dataGridView2.Columns.Add("MAIL", "Mail");
            dataGridView2.Columns.Add("SIFRE", "Şifre");
            dataGridView2.Columns.Add("HESAP_NO", "Hesap No");

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_SIFRE_VERILER", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                byte[] adBytes = Convert.FromBase64String(dr["AD"].ToString());
                string ad = ASCIIEncoding.ASCII.GetString(adBytes);

                byte[] soyadBytes = Convert.FromBase64String(dr["SOYAD"].ToString());
                string soyad = ASCIIEncoding.ASCII.GetString(soyadBytes);

                byte[] mailBytes = Convert.FromBase64String(dr["MAIL"].ToString());
                string mail = ASCIIEncoding.ASCII.GetString(mailBytes);

                byte[] sifreBytes = Convert.FromBase64String(dr["SIFRE"].ToString());
                string sifre = ASCIIEncoding.ASCII.GetString(sifreBytes);

                byte[] hesapNoBytes = Convert.FromBase64String(dr["HESAP_NO"].ToString());
                string hesapNo = ASCIIEncoding.ASCII.GetString(hesapNoBytes);

                dataGridView2.Rows.Add(ad, soyad, mail, sifre, hesapNo);
            }
            conn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            byte[] adDizisi = ASCIIEncoding.ASCII.GetBytes(ad);
            string sifreliAd = Convert.ToBase64String(adDizisi);
        
            string soyad = txtSoyad.Text;
            byte[] soyadDizisi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string sifreliSoyad = Convert.ToBase64String(soyadDizisi);

            string mail = txtMail.Text;
            byte[] mailDizisi = ASCIIEncoding.ASCII.GetBytes(mail);
            string sifreliMail = Convert.ToBase64String(mailDizisi);

            string sifre = txtSifre.Text;
            byte[] sifreDizisi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifreliSifre = Convert.ToBase64String(sifreDizisi);

            string hesapNo = txtHesapNo.Text;
            byte[] hesapNoDizisi = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string sifreliHesapNo = Convert.ToBase64String(hesapNoDizisi);

            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_SIFRE_VERILER(AD,SOYAD,MAIL,SIFRE,HESAP_NO) " +
                "VALUES(@P1,@P2,@P3,@P4,@P5)",conn);
            cmd.Parameters.AddWithValue("@P1", sifreliAd);
            cmd.Parameters.AddWithValue("@P2", sifreliSoyad);
            cmd.Parameters.AddWithValue("@P3", sifreliMail);
            cmd.Parameters.AddWithValue("@P4", sifreliSifre);
            cmd.Parameters.AddWithValue("@P5", sifreliHesapNo);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Veriler Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            listeleSifresiz();
        }

        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            string adCozum = txtSifreCoz.Text;
            byte[] adCozumDizini = Convert.FromBase64String(adCozum);
            string adVerisi = ASCIIEncoding.ASCII.GetString(adCozumDizini);
            lblCozulmusSifre.Text = adVerisi;
        }
    }
}
