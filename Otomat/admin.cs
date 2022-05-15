using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomat
{
    class admin
    {
        private string kullaniciAdi = "enes4318";
        public string adminSifre = "enes";
        private ulong adminTelefon = 05369984438;

        Urunler urun = new Urunler();

        public bool loginYap()
        {
            Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz:");
            string gelenKullaniciAdi = Console.ReadLine();
            Console.WriteLine("Lütfen Şifrenizi Giriniz:");
            string gelenSifre = Console.ReadLine();
            if ((kullaniciAdi == gelenKullaniciAdi) && (adminSifre == gelenSifre))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void adminİslemListele()
        {
            Console.WriteLine("Ürün Ekleme      :1\nÜrün Silme       :2\nFiyat Güncelleme :3\nŞifre Değiştirme :4\nÜrün Listele     :5\nAnamenü          :6");
        }
        public int secimYaptır()
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi seçiniz:");
            int adminSecim = Convert.ToInt32(Console.ReadLine());
            return adminSecim;
        }
        public void urunEkle(List<string> a, List<double> b)
        {
            Console.WriteLine("Eklemek İstediğiniz Ürünün Adını Giriniz:");
            string eklenenUrun = Console.ReadLine();
            if (a.Contains(eklenenUrun))
            {
                Console.WriteLine("Eklemek İstediğiniz Ürün Mevcuttur.");
            }
            Console.WriteLine("Eklediğiniz Ürünün Fiyatını Giriniz:");
            double eklenenUrunFiyat = Convert.ToDouble(Console.ReadLine());
            urun.Ad.Add(eklenenUrun);
            urun.fiyat.Add(eklenenUrunFiyat);
        }
        public void urunSilme(List<string> a, List<double> b)
        {
            urun.listele();
            Console.WriteLine("Silmek İstediğiniz Ürünün Numarasını Giriniz:");
            int silUrun = Convert.ToInt32(Console.ReadLine());
            urun.Ad.RemoveAt(silUrun);
            urun.fiyat.RemoveAt(silUrun);
        }
        public void adminListe(List<string> x, List<double> y)
        {
            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine("-{0}-" + x[i] + " " + y[i] + " TL", i + 1);
            }
        }
        public void fiyatGuncelleme(List<double> a)
        {
            urun.listele();
            Console.WriteLine("Fiyat Güncellemesi Yapmak İstediğiniz Ürünün Numarasını Giriniz:");
            int guncellemeFiyat = Convert.ToInt32(Console.ReadLine());
            urun.fiyat.RemoveAt(guncellemeFiyat);
            Console.WriteLine("Ürünün Yeni Fiyatını Giriniz:");
            double guncelfiyat = Convert.ToDouble(Console.ReadLine());
            urun.fiyat.Insert(guncellemeFiyat, guncelfiyat);
        }
        public void sifreDegistirme(string a)
        {
            Console.WriteLine("Mevcut Şifrenizi Giriniz:");
            string mevcutSifre = Console.ReadLine();
            if (mevcutSifre==a)
            {
                Console.WriteLine("Yeni Şifrenizi Giriniz:");
                string yeniSifre = Console.ReadLine();
                Console.WriteLine("Yeni Şifre Tekrar Giriniz:");
                string yeniSifre1 = Console.ReadLine();
                if (yeniSifre==yeniSifre1)
                {
                    a = yeniSifre;
                    Console.WriteLine("Şifreniz Değiştirilmiştir. Değiştirme Bilgilendirme Mesajı {0} nolu Telefonunuza Gönderilmiştir.",adminTelefon);
                }
                else
                {
                    urun.hataliIslem();
                }
            }
            else
            {
                urun.hataliIslem();
            }
        }

    }
}
