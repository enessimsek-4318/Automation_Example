using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Otomat
{
    class Urunler
    {
        public List<string> Ad = new List<string>()
        {
            "Filtre Kahve","Americano","Cappuccino","Türk Kahvesi","Tea Latte","Flat White","Mocha"
        };
        public List<double> fiyat = new List<double>()
        {
            14.5,17.75,18.5,12.5,19.75,20.5,22.5
        };
        public int giris()
        {
            Console.WriteLine("******************ENES ŞİMŞEK******************");
            Console.WriteLine("Admin Girişi   :1\nMüşteri Girişi :2\nÇıkış          :3\nLütfen Seçiminizi Yapınız:");
            int secim = Convert.ToInt32(Console.ReadLine());
            return secim;
        }
        public void hataliIslem()
        {
            Console.WriteLine("Eksik veya Hatalı Giriş Yaptınız!");
        }
        public void listele()
        {
            for (int i = 0; i < Ad.Count; i++)
            {
                Console.WriteLine("-{0}-" + Ad[i] + " " + fiyat[i] + " TL", i + 1);
            }

        }
        public double paraYatir()
        {
            Console.WriteLine("Lütfen Paranızı Yatırınız:");
            double yatanPara = Convert.ToDouble(Console.ReadLine());
            return yatanPara;
        }
        public double secAl()
        {
            double toplam = 0;
            Console.WriteLine("Lütfen Almak İstediğiniz Ürünü Seçiniz:");
            int alınan = Convert.ToInt32(Console.ReadLine());
            if (alınan>fiyat.Count)
            {
                hataliIslem();
            }
            else
            {
                toplam += fiyat[alınan];
                
            }
            return toplam;
        }
        public void paraUstu(double x,double y)
        {
            if (x<y)
            {
                Console.WriteLine("Yetersiz Bakiye");
            }
            else
            {
                double paraUstu = x - y;
                Console.WriteLine("Lütfen Kalan Paranızı Alınız:\nParanız: {0}\n******************Afiyet Olsun******************", paraUstu);
            }
            Thread.Sleep(4000);           
        }
       
    }
}
