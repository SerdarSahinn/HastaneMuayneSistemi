using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _220601006__SerdarŞahin__Ödev2
{
    public partial class GüncelleFrm : Form
    {
        public GüncelleFrm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("Server=localhost; port=5432; Database=postgres;user Id=postgres;password=12345");
        public void VerileriGoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from hasta where tc like '%" + kilmliktxt.Text + "%'", baglan);
            NpgsqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["tc"].ToString();
                ekle.SubItems.Add(rd["ad"].ToString());
                ekle.SubItems.Add(rd["soyad"].ToString());
                ekle.SubItems.Add(rd["telefon"].ToString());
                ekle.SubItems.Add(rd["adres"].ToString());
                ekle.SubItems.Add(rd["dogum_yeri"].ToString());
                ekle.SubItems.Add(rd["dogum_tarihi"].ToString());
                ekle.SubItems.Add(rd["hastalık_teshisi"].ToString());
                ekle.SubItems.Add(rd["kullanılacak_ilac"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();


        }

        private void Hastagstrbtn_Click(object sender, EventArgs e)
        {
            VerileriGoster();
            groupBox1.Visible = true;
            dataGridView1.Visible = false;
        }

        private void GüncelleFrm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            listView1.Columns.Add("Tc", 100);
            listView1.Columns.Add("Ad", 100);
            listView1.Columns.Add("Soyad", 150);
            listView1.Columns.Add("telefon", 100);
            listView1.Columns.Add("adres", 100);
            listView1.Columns.Add("doğum yeri", 150);
            listView1.Columns.Add("doğum tarihi", 100);
            listView1.Columns.Add("Haslık teşhisi", 100);
            listView1.Columns.Add("İlaç", 100);
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; port=5432; Database=postgres;user Id = postgres; password=12345");
        public void verileri_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        private void bilggilerikaydetbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            conn.Open();
            NpgsqlCommand komut_guncelle = new NpgsqlCommand();
            komut_guncelle.Connection = conn;
            komut_guncelle.Parameters.AddWithValue("@tcsi", tctxt.Text);
            komut_guncelle.Parameters.AddWithValue("@adı", adtxt.Text);
            komut_guncelle.Parameters.AddWithValue("@soyadı", soyadtxt.Text);
            komut_guncelle.Parameters.AddWithValue("@telefonu", telefontxt.Text);
            komut_guncelle.Parameters.AddWithValue("@adresi", adrestxt.Text);
            komut_guncelle.Parameters.AddWithValue("@dogumyeri", dogumyeritxt.Text);
            komut_guncelle.Parameters.AddWithValue("@dogumtarihi", dogumtarihitxt.Text);
            komut_guncelle.Parameters.AddWithValue("@hastalık", teshistxt.Text);
            komut_guncelle.Parameters.AddWithValue("@ilacı", ilactxt.Text);
            komut_guncelle.CommandType = CommandType.Text;
            komut_guncelle.CommandText = "update hasta set tc=@tcsi,ad=@adı,soyad=@soyadı,telefon=@telefonu,adres=@adresi,dogum_yeri=@dogumyeri,dogum_tarihi=@dogumtarihi,hastalık_teshisi=@hastalık,kullanılacak_ilac=@ilacı where tc=@tcsi";
            NpgsqlDataReader dr = komut_guncelle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_guncelle.Dispose();
            conn.Close();
            MessageBox.Show("Hasta Bilgileri Güncellenmiştir");
            verileri_goster("select *from hasta");

            listView1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
