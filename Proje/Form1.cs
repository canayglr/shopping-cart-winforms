using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        Siparis siparis = new Siparis();
        public Form1()
        {
            InitializeComponent();
        }
        AdminPanel panel = new AdminPanel();
        private void admin_Click(object sender, EventArgs e)
        {
            panel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tumurunler.Items.Count == 0)
            {
                MessageBox.Show("Ürün yok!");
                return;
            }
            if (tumurunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ürün seçiniz!");
                return;
            }
            Urun urun = (Urun)tumurunler.SelectedItem;
            siparis.sepet.UrunEkle(urun);
        }

        private void sepettencikar_Click(object sender, EventArgs e)
        {
            if (sepet.Items.Count == 0)
            {
                MessageBox.Show("Ürün yok!");
                return;
            }
            if (sepet.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ürün seçiniz!");
                return;
            }
            Urun urun = (Urun)tumurunler.SelectedItem;
            siparis.sepet.UrunCikar(urun);
        }

        private void siparisver_Click(object sender, EventArgs e)
        {
            siparis.SiparisVer();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            siparis.sepet.SepetTemizle();
        }
    }
}
