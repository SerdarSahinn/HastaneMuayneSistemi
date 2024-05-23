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
    public partial class HastaListesi : Form
    {
        public HastaListesi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string connString = "Server = localhost; port=5432; Database=postgres;user Id = postgres; password=12345";
        private void button1_Click(object sender, EventArgs e)
        {


            string arananAd = textBox1.Text.Trim();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM hasta WHERE ad = @arananAd";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@arananAd", arananAd);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    MessageBox.Show("Hastalar Listeniyor...");
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }


        }
        private void ListeleTumHastalar()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM hasta";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void hepsilistebtn_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            ListeleTumHastalar();
        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void HastaListesi_Load(object sender, EventArgs e)
        {
           
        }
    }
}
