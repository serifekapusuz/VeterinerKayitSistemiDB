using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerKlinigiKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MusteriGetir()
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MusteriID, Ad + ' ' + Soyad AS MusteriAd FROM Musteri", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMusteri.DataSource = dt;
            cmbMusteri.ValueMember = "MusteriID";
            cmbMusteri.DisplayMember = "MusteriAd";
            connection.Close();
        }

        private void HayvanGetir()
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT HayvanID, Ad FROM Hayvan", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbRandevuHayvan.DataSource = dt;
            cmbRandevuHayvan.DisplayMember = "Ad";
            cmbRandevuHayvan.ValueMember = "HayvanID";

            cmbAsiHayvan.DataSource = dt.Copy();
            cmbAsiHayvan.DisplayMember = "Ad";
            cmbAsiHayvan.ValueMember = "HayvanID";
            connection.Close();
        }

        private void VeterinerGetir()
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT VeterinerID, Ad + ' ' + Soyad AS AdSoyad FROM Veteriner", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbRandevuVeteriner.DataSource = dt;
            cmbRandevuVeteriner.DisplayMember = "AdSoyad";
            cmbRandevuVeteriner.ValueMember = "VeterinerID";
            connection.Close();
        }
        private void AsiHayvanGetir()
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT HayvanID, Ad FROM Hayvan", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbAsiHayvan.DataSource = dt;
            cmbAsiHayvan.DisplayMember = "Ad";
            cmbAsiHayvan.ValueMember = "HayvanID";
       
            connection.Close();
        }

        private void TedaviHayvanGetir()
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT HayvanID, Ad FROM Hayvan", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTedaviHayvan.DataSource = dt;
                cmbTedaviHayvan.DisplayMember = "Ad";
                cmbTedaviHayvan.ValueMember = "HayvanID";
               
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Musteri (Ad, Soyad, Telefon, Adres) VALUES (@Ad, @Soyad, @Telefon, @Adres)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Ad", txtMusteriAd.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtMusteriSoyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri eklendi.");
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Musteri";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMusteriler.DataSource = dt;

            connection.Close();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow != null)
            {
                int musteriID = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells["MusteriID"].Value);
                string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Musteri WHERE MusteriID=@ID", connection);
                cmd.Parameters.AddWithValue("@ID", musteriID);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Müşteri silindi.");
            }
        }

        private void btnHayvanEkle_Click(object sender, EventArgs e)
        {

            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Hayvan (Ad, Tur, Irk, DogumTarihi, Cinsiyet, MusteriID) VALUES (@Ad, @Tur, @Irk, @DogumTarihi, @Cinsiyet, @MusteriID)", connection);
            cmd.Parameters.AddWithValue("@Ad", txtHayvanAd.Text);
            cmd.Parameters.AddWithValue("@Tur", txtHayvanTur.Text);
            cmd.Parameters.AddWithValue("@Irk", txtHayvanIrk.Text);
            cmd.Parameters.AddWithValue("@DogumTarihi", dtpDogumTarihi.Value);
            cmd.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.Text);
            cmd.Parameters.AddWithValue("@MusteriID", cmbMusteri.SelectedValue);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Hayvan eklendi.");


        }

        private void btnHayvanListele_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Hayvan";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHayvanlar.DataSource = dt;

            connection.Close();
        }

        private void btnHayvanSil_Click(object sender, EventArgs e)
        {
            if (dgvHayvanlar.CurrentRow != null)
            {
                int hayvanID = Convert.ToInt32(dgvHayvanlar.CurrentRow.Cells["HayvanID"].Value);
                string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Hayvan WHERE HayvanID=@ID", connection);
                cmd.Parameters.AddWithValue("@ID", hayvanID);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Hayvan silindi.");
            }
        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Veteriner (Ad, Soyad, Uzmanlik) VALUES (@Ad, @Soyad, @Uzmanlik)", connection);
            cmd.Parameters.AddWithValue("@Ad", txtVetAd.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtVetSoyad.Text);
            cmd.Parameters.AddWithValue("@Uzmanlik", txtUzmanlik.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Veteriner eklendi.");
        }

        private void btnVeterinerListele_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Veteriner", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVeterinerler.DataSource = dt;
            connection.Close();
        }

        private void btnVeterinerSil_Click(object sender, EventArgs e)
        {
            if (dgvVeterinerler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvVeterinerler.CurrentRow.Cells["VeterinerID"].Value);
                string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Veteriner WHERE VeterinerID=@ID", connection);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Veteriner silindi.");
            }
        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Randevu (HayvanID, VeterinerID, Tarih, Saat) VALUES (@HayvanID, @VeterinerID, @Tarih, @Saat)", connection);
            cmd.Parameters.AddWithValue("@HayvanID", cmbRandevuHayvan.SelectedValue);
            cmd.Parameters.AddWithValue("@VeterinerID", cmbRandevuVeteriner.SelectedValue);
            cmd.Parameters.AddWithValue("@Tarih", dtpRandevuTarihi.Value);
            cmd.Parameters.AddWithValue("@Saat", txtRandevuSaat.Text);
            cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Randevu eklendi.");
        }

        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Randevu", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgRandevular.DataSource = dt;
            connection.Close();
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            if (dgRandevular.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgRandevular.CurrentRow.Cells["RandevuID"].Value);
                string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Randevu WHERE RandevuID=@ID", connection);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Randevu silindi.");
            }
        }

        private void btnAsiEkle_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(
    "INSERT INTO Asi (HayvanID, AsiAdi, AsiTarihi, SonrakiTarih) VALUES (@HayvanID, @AsiAdi, @AsiTarihi, @SonrakiTarih)",
    connection);
            cmd.Parameters.AddWithValue("@HayvanID", cmbAsiHayvan.SelectedValue);
            cmd.Parameters.AddWithValue("@AsiAdi", txtAsiAdi.Text);
            cmd.Parameters.AddWithValue("@AsiTarihi", dtAsiTarihi.Value);
            cmd.Parameters.AddWithValue("@SonrakiTarih", dtSonrakiAsi.Value);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Aşı eklendi.");
        }

        private void btnAsiListele_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Asi", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAsilar.DataSource = dt;
            connection.Close();
        }

        private void btnAsiSil_Click(object sender, EventArgs e)
        {
            if (dgvAsilar.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvAsilar.CurrentRow.Cells["AsiID"].Value);
                string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Asi WHERE AsiID=@ID", connection);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Aşı silindi.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            HayvanGetir();
            VeterinerGetir();
            AsiHayvanGetir();
            TedaviHayvanGetir();
        }

        private void btnTedaviEkle_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tedavi (HayvanID, Teshis, UygulananTedavi, Tarih) VALUES (@hayvanID, @teshis, @uygulanantedavi, @tarih)", connection);
                cmd.Parameters.AddWithValue("@hayvanID", cmbTedaviHayvan.SelectedValue);
                cmd.Parameters.AddWithValue("@teshis", txtTeshis.Text);
                cmd.Parameters.AddWithValue("@uygulanantedavi", txtUygulananTedavi.Text);
                cmd.Parameters.AddWithValue("@ucret", txtUcret.Text);
                cmd.Parameters.AddWithValue("@tarih", dtpTedaviTarihi.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Tedavi kaydı başarıyla eklendi.");
            }
        }

        private void btnTedaviListele_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT T.TedaviID, H.Ad AS HayvanAdi, T.Teshis, T.UygulananTedavi
, T.Tarih 
                                                  FROM Tedavi T 
                                                  INNER JOIN Hayvan H ON T.HayvanID = H.HayvanID", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTedaviler.DataSource = dt;
            }
        }

        private void btnTedaviSil_Click(object sender, EventArgs e)
        {
            if (dgvTedaviler.SelectedRows.Count > 0)
            {
                int tedaviID = Convert.ToInt32(dgvTedaviler.SelectedRows[0].Cells["TedaviID"].Value);
                string connectionString = @"Server=localhost;Database=VeterinerKayit; Trusted_Connection=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Tedavi WHERE TedaviID = @id", connection);
                    cmd.Parameters.AddWithValue("@id", tedaviID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tedavi silindi.");
                    
                }
            }
        }
    }
}
