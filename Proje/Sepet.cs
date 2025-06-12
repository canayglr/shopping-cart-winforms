using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    class Sepet
    {
        public List<Urun> Urun = new List<Urun>();

        public void UrunEkle(Urun urun)
        {
            Urun.Add(urun);
            Form1.sepet.Items.Add(urun);
            ToplamFiyat();
        }
        public void UrunCikar(Urun urun)
        {
            Urun.Remove(urun);
            Form1.sepet.Items.Remove(urun);
            ToplamFiyat();
        }
        public void SepetTemizle()
        {
            Urun.Clear();
            Form1.sepet.Items.Clear();
            ToplamFiyat();
        }

        public void ToplamFiyat()
        {
            double temp = 0;
            if (Urun.Count > 0) { 
                foreach (Urun urun in Urun)
                {
                    temp += urun.getFiyat();
                } 
            }
            Form1.toplamtutar.Text = String.Format("{0} TL", temp);
        }
    }
}
