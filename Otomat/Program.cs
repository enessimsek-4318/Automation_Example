using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Otomat
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Urunler urn = new Urunler();
            admin adm = new admin();
            while (kontrol)
            {
                int tercih = urn.giris();
                if (tercih == 1)
                {
                    bool kontrol1 = false;
                    if (adm.loginYap())
                    {
                        kontrol1 = true;
                    }
                    else
                    {
                        urn.hataliIslem();
                    }
                    while (kontrol1)
                    {
                        adm.adminİslemListele();
                        int adminSecim = adm.secimYaptır();
                        if (adminSecim == 1)
                        {
                            adm.urunEkle(urn.Ad,urn.fiyat);
                            Thread.Sleep(3000);
                        }
                        else if (adminSecim == 2)
                        {
                            adm.urunSilme(urn.Ad, urn.fiyat);
                            Thread.Sleep(3000);
                        }
                        else if (adminSecim == 3)
                        {
                            adm.fiyatGuncelleme(urn.fiyat);
                            Thread.Sleep(3000);
                        }
                        else if (adminSecim == 4)
                        {
                            adm.sifreDegistirme(adm.adminSifre);
                            Thread.Sleep(3000);
                        }
                        else if (adminSecim == 5)
                        {
                            adm.adminListe(urn.Ad,urn.fiyat);
                            Thread.Sleep(3000);
                        }
                        else if (adminSecim == 6)
                        {
                            Thread.Sleep(2000);
                            kontrol1 = false;
                        }
                        else
                        {
                            urn.hataliIslem();
                        }
                    }

                }
                else if (tercih == 2)
                {
                    double yatanPara=urn.paraYatir();
                    urn.listele();
                    double urunFiyat=urn.secAl();
                    urn.paraUstu(yatanPara,urunFiyat);
                }
                else if (tercih == 3)
                {
                    Thread.Sleep(2000);
                    kontrol = false;
                }
                else
                {
                    urn.hataliIslem();
                }
            }

        }
    }
}
