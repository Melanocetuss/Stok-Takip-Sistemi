using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Kerem_Cesur_Odev
{
    internal class Urun
    {
        private string urunTuru;
        private string marka;
        private string model;
        private string durumu;
        private int toptanFiyati;
        private int karMarji;
            
     
        public Urun(string urunTuru , string marka , string model , string durumu , int toptanFiyati , int karMarji)
        {
            this.urunTuru = urunTuru;
            this.marka = marka;
            this.model = model;
            this.durumu = durumu;
            this.toptanFiyati = toptanFiyati;
            this.karMarji = karMarji;
        }

        public string listele()
        {
            string cikti = "";
            cikti+="----| " + "\n" + "Urunun Türü: " +this.urunTuru +"      " +"\n";
            cikti+="Urunun Markası: " + this.marka +"      " +"\n";
            cikti+="Model: " +this.model +"      " +"\n";
            cikti+="Durumu: " +this.durumu +"      " +"\n";
            cikti+="Toptan fiyati: " +this.toptanFiyati +"TL" +"      " +"\n";
            cikti+="Satis Fiyati" +(this.toptanFiyati+((this.toptanFiyati*this.karMarji)/100)) + "TL" + "\n"+ " |----";

            return cikti;
        }


        public void setUrunTuru(string urunTuru)
        {
            this.urunTuru = urunTuru;
        }

        public void setMarka(string marka)
        {
            this.marka = marka;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setDurumu(string durumu)
        {
            this.durumu = durumu;
        }

        public void setToptanFiyati(int toptanFiyati)
        {
            this.toptanFiyati = toptanFiyati;
        }
        public void setKarMarji(int karMarji)
        {
            this.karMarji = karMarji;
        }



        public string getUrunTuru()
        {
            return this.urunTuru;
        }

        public string getMarka()
        {
            return this.marka;
        }
   

        public string getModel()
        {
            return this.model;
        }
       
        public string getDurumu()
        {
            return this.durumu;
        }

        
        public int getToptanFiyati()
        {
            return this.toptanFiyati;
        }
    
        public int getKarMarji()
        {
            return this.karMarji;
        }     
    }
}
