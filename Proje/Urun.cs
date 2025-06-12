using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Urun
    {
        public static List<Urun> urunler = new List<Urun>();
        private int stok;
        private double fiyat;
        private int urunID;
        private String ad;
        public Urun(int stok, double fiyat, int urunID, String ad)
        {
            this.stok = stok;
            this.fiyat = fiyat;
            this.urunID = urunID;
            this.ad = ad;
        }
        public static int urunIDGlobal = 0;
        public override string ToString()
        {
            return $"{ad} - {fiyat}TL (Stok: {stok})";
        }

        public bool stokVarMi()
        {
            return stok > 0;
        }

        public void stokDuzenle(int yeni)
        {
            stok = yeni;
        }
        public void fiyatDuzenle(double yeni)
        {
            fiyat = yeni;
        }

        public void adDuzenle(String yeni)
        {
            ad = yeni;
        }

        public int getStok()
        {
            return stok;
        }
        public double getFiyat()
        {
            return fiyat;
        }

        public String getName()
        {
            return ad;
        }
    }
}
