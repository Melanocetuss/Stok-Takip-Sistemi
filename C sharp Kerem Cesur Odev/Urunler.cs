using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Kerem_Cesur_Odev
{
    internal class Urunler
    {
        public List<Urun> urunler;

        public Urunler()
        {
            urunler = new List<Urun>();
        }

        public bool ekle(Urun urun)
        {
            try
            {
                urunler.Add(urun);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int sil(string model)
        {
            int index = urunler.FindIndex(item => item.getModel() == model);
            if (index != -1)
            {
                urunler.RemoveAt(index);
                return index;
            }       
            else
                return -1;
        }

        public string Listele()
        {
            string cikti = "";
            foreach (Urun urun in urunler)
            {
                cikti += urun.listele();
                cikti += "_____________________\n";
            }
            return cikti;
        }

        public int ara(string model)
        {
            return urunler.FindIndex(item => item.getModel() == model);      
            
        }

        public int guncelle( string model , int toptanFiyati , int karMarji )
        {
            int index = urunler.FindIndex(urun => urun.getModel() == model);

            if (index != -1)
            {
                urunler[index].setToptanFiyati(toptanFiyati);
                urunler[index].setKarMarji(karMarji);


                return index;
            }
            else
            {
                return -1;
            }
        }


    }
}
