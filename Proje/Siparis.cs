using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    class Siparis: ISiparisVerilebilir
    {
        public int ID;
        public DateTime tarih;

        public Sepet sepet = new Sepet();
        public void SiparisVer()
        {
            if (StokVarMi())
            {
                MessageBox.Show("Sipariş Başarıyla Verildi!");
            }
        }

        public bool StokVarMi()
        {
            if (sepet.Urun.Count <= 0) return false;
            for(int i = 0; i<sepet.Urun.Count; i++)
            {
                if (sepet.Urun[i].getStok() < 1)
                {
                    MessageBox.Show(sepet.Urun[i].getName() + " ürünü stokta yok!");
                    return false;
                }
            }
            return true;
        }
        
    }
}
