namespace _220601006__SerdarŞahin__Ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hastaeklemebtnn_Click(object sender, EventArgs e)
        {
            HastaeklemeFrm hastaeklemeFrm = new HastaeklemeFrm();
            hastaeklemeFrm.Show();
            this.Hide();
        }

        private void hastasilmebtn_Click(object sender, EventArgs e)
        {
            hastasilme aa = new hastasilme();
            aa.Show();
            this.Hide();
        }

        private void hastaguncellemebtn_Click(object sender, EventArgs e)
        {
            GüncelleFrm güncelleFrm = new GüncelleFrm();
            güncelleFrm.Show();
            this.Hide();

        }

        private void hastalistebtn_Click(object sender, EventArgs e)
        {
            HastaListesi hastaListesi = new HastaListesi();
            hastaListesi.Show();
            this.Hide();
        }

        private void cksbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}