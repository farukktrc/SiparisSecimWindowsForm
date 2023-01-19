namespace listView_Odec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int sonuc = 0;
        int toplam = 0;
        int fiyat = 0;
        private void btnsiparis_Click(object sender, EventArgs e)
        {

            string aciklama;

            if (cmbMenu.SelectedItem == "HAMBURGER")
            {
                fiyat = 45;
            }
            else if (cmbMenu.SelectedItem == "TAVUKBURGER")
            {
                fiyat = 30;
            }
            else if (cmbMenu.SelectedItem == "SOSÝSLÝ")
            {
                fiyat = 25;
            }
            else if (cmbMenu.SelectedItem == "PATATES")
            {
                fiyat = 10;
            }
            aciklama = txtaciklama.Text;

            if (cbketcap.Checked)
            {
                fiyat += 2;

            }
            if (cbmayonez.Checked)
            {
                fiyat += 2;

            }
            if (cbhardal.Checked)
            {
                fiyat += 2;

            }
            if (cbparmesan.Checked)
            {
                fiyat += 2;
            }
            if (cbtursu.Checked)
            {
                fiyat += 2;
            }

            toplam += fiyat;
            lbsiparisler.Items.Add(cmbMenu.SelectedItem + "       " + aciklama + "        " + fiyat.ToString());
            lbltoplam.Text = "Toplam Tutar : " + toplam.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            lbsiparisler.Items.Remove(lbsiparisler.SelectedItem);

            toplam -= fiyat;

            lbltoplam.Text = "Toplam Tutar : " + toplam;
        }

        private void btntamamla_Click(object sender, EventArgs e)
        {
            if (toplam > 100)
            {
                sonuc = toplam - ((toplam / 100) * 10);
                MessageBox.Show("Siðariþiniz Alýnmýþtýr" + "\nÖdemeniz Gereken Miktar : " + sonuc);

            }

        }
    }
}








