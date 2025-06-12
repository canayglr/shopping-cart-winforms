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
    public partial class UrunDuzenle : Form
    {
        Urun urun;
        public UrunDuzenle(Urun urun)
        {
            InitializeComponent();
            this.urun = urun;
        }
        private void UrunDuzenle_Load(object sender, EventArgs e)
        {
            ad.Text = urun.getName();
            stok.Text = String.Format("{0}", urun.getStok());
            fiyat.Text = String.Format("{0}", urun.getFiyat());
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            if (ad.Text == "" || stok.Text == "" || fiyat.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz!");
                return;
            }
            AdminPanel.listBox1.Items.Remove(urun);
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
            urun.adDuzenle(ad.Text);
            urun.stokDuzenle(Int32.Parse(stok.Text));
            urun.fiyatDuzenle(Double.Parse(fiyat.Text));
            //Urun.urunler.Add(urun);
            AdminPanel.listBox1.Items.Add(urun);
            Form1.tumurunler.Items.Add(urun);
            if (urunsepettemi) Form1.sepet.Items.Add(urun);
            MessageBox.Show("Düzenleme Başarılı!");
            Close();
        }
    }
}
