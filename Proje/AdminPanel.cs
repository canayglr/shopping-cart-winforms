using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ad.Text == "" || stok.Text == "" || fiyat.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz!");
                return;
            }
            Urun urun = new Urun(Int32.Parse(stok.Text), Double.Parse(fiyat.Text), ++Urun.urunIDGlobal, ad.Text);
            //Urun.urunler.Add(urun);
            listBox1.Items.Add(urun);
            Form1.tumurunler.Items.Add(urun);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Ürün yok!");
                return;
            }
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ürün seçiniz!");
                return;
            }
            UrunDuzenle duzenle = new UrunDuzenle((Urun)listBox1.SelectedItem);
            duzenle.Show();

        }

        private void silurun_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Ürün yok!");
                return;
            }
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ürün seçiniz!");
                return;
            }
            Urun urun = (Urun)listBox1.SelectedItem;
            listBox1.Items.Remove(urun);
            Form1.tumurunler.Items.Remove(urun);
            bool urunsepettemi = false;
            for (int i = Form1.sepet.Items.Count - 1; i >= 0; i--)
            {
                Urun u = (Urun)Form1.sepet.Items[i];
                if (urun.getName().Equals(u.getName()))
                {
                    Form1.sepet.Items.RemoveAt(i);
                    urunsepettemi = true;
                }
            }
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Ürün yok!");
                return;
            }
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ürün seçiniz!");
                return;
            }
            UrunDuzenle duzenle = new UrunDuzenle((Urun)listBox1.SelectedItem);
            duzenle.Show();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Kapatmayı iptal et
            this.Hide();     // Sadece gizle
        }
    }
}
