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

namespace _220601006__SerdarŞahin__Ödev2
{
    public partial class hastasilme : Form
    {
        public hastasilme()
        {
            InitializeComponent();
        }

        private void hastasilme_Load(object sender, EventArgs e)
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
        NpgsqlConnection baglan = new NpgsqlConnection("Server = localhost; port=5432; Database=postgres;user Id = postgres; password=12345");
        public void verilerigoster()
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
            verilerigoster();
            groupBox1.Visible = true;

            dataGridView1.Visible = false;
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

        private void silbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            listView1.Visible = false;
            silbtn.Visible = false;
            iptalbtn.Visible = false;
            conn.Open();
            NpgsqlCommand komut_sil = new NpgsqlCommand();
            komut_sil.Connection = conn;
            komut_sil.Parameters.AddWithValue("@kimlik", kilmliktxt.Text);
            komut_sil.CommandType = CommandType.Text;
            komut_sil.CommandText = "delete from hasta where tc = @kimlik";
            NpgsqlDataReader dr = komut_sil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_sil.Dispose();
            conn.Close();
            MessageBox.Show("Hasta işlemi başarılı bir şekilde gerçekleşti ");
            verileri_goster("select * from hasta");


        }

        private void iptalbtn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
