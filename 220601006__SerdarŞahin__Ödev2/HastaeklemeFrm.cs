using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace _220601006__SerdarŞahin__Ödev2
{
    public partial class HastaeklemeFrm : Form
    {
        public HastaeklemeFrm()
        {
            InitializeComponent();
        }

        private void eklelistegriw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        NpgsqlConnection baglan = new NpgsqlConnection("Server = localhost; port=5432; Database=postgres;user Id = postgres; password=12345");
        public void verilerigoster(string txt)
        {
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader rd = komut.ExecuteReader();
            if (rd.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rd);
                eklelistegriw.DataSource = dt;
            }
            komut.Dispose();
            baglan.Close();
        }

        private void bilggilerikaydetbtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglan;

            komut_ekle.Parameters.AddWithValue("@tcsi", int.Parse(tctxt.Text));
            komut_ekle.Parameters.AddWithValue("@adı", adtxt.Text);
            komut_ekle.Parameters.AddWithValue("@soyadı", soyadtxt.Text);
            komut_ekle.Parameters.AddWithValue("@teli", long.Parse(telefontxt.Text));
            komut_ekle.Parameters.AddWithValue("@adresi", adrestxt.Text);
            komut_ekle.Parameters.AddWithValue("@dogumtrh", dogumtarihitxt.Text);
            komut_ekle.Parameters.AddWithValue("dogumyeri", dogumyeritxt.Text);
            komut_ekle.Parameters.AddWithValue("@hastalık", teshistxt.Text);
            komut_ekle.Parameters.AddWithValue("@ilaclar", ilactxt.Text);
            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into hasta(tc,ad,soyad,telefon,adres,dogum_tarihi,dogum_yeri,hastalık_teshisi,kullanılacak_ilac) values(@tcsi,@adı,@soyadı,@teli,@adresi,@dogumtrh,@dogumyeri,@hastalık,@ilaclar)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                eklelistegriw.DataSource = dt;

            }
            komut_ekle.Dispose();
            baglan.Close();
            MessageBox.Show("Hasta Ekleme İşlemi Başarılı Bir Şekilde Gerçekleşti");
            verilerigoster("select * from hasta");

        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void tctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hataeklebtn_Click(object sender, EventArgs e)
        {
            hastaeklegorupbox.Visible = true;
        }

        private void HastaeklemeFrm_Load(object sender, EventArgs e)
        {
            hastaeklegorupbox.Visible=false;
        }
    }
}
