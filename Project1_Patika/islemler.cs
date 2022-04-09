using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Patika
{
    class islemler : kisiler
    {
        kisiler kisi = new kisiler();
        public List<kisiler> person = new List<kisiler>();


        public void Rehber()
        {
            //Default 5 kisilik listeyi ekli halde listele

            person.Add(new kisiler("Recep", "Koseni", "1234567890"));
            person.Add(new kisiler("Ebru", "Koseni", "1234567890"));
            person.Add(new kisiler("Sibel", "Koseni", "1234567890"));
            person.Add(new kisiler("Eyyup", "Koseni", "1234567890"));
            person.Add(new kisiler("Saban", "Koseni", "1234567890"));
        }
        public void kayitEkle()
        {


            Console.WriteLine("Lütfen isim giriniz: ");
            isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz: ");
            soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen cep numarasi giriniz: ");
            cep = Console.ReadLine();

            person.Add(new kisiler(isim, soyisim, cep));


            kayitListele();




        }

        public void Menu()
        {

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seciniz");
            Console.WriteLine("********************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek) ");
            Console.WriteLine("(2) Varolan Numarayi Silmek ");
            Console.WriteLine("(3) Varolan Numarayi Güncellemek ");
            Console.WriteLine("(4) Rehberi Listelemek ");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(0) Cikis");

        }


        public void kayitListele()
        {
            Console.WriteLine("     Telefon Rehberi     ");
            Console.WriteLine("*************************");



            foreach (var item in person)
            {
                if (item.isim != null || item.soyisim != null)  //if (kisi.Isim == null)  continue;  Kisi silinmisse hicbirsey yazma
                {
                    Console.WriteLine($"isim : {item.isim}");
                    Console.WriteLine($"soyisim : {item.soyisim}");
                    Console.WriteLine($"Telefon Numarasi : {item.cep}\n");
                }


            }





        }

        public void kayitSil()
        {

            Console.WriteLine("Lütfen numarasini silmek istediğiniz kisinin adini veya soyadini giriniz");
            string silinicekKisi = Console.ReadLine();

            //Kisi Var ise

            if (person.Contains("soyisim") || person.Contains("isim"))
            {
                Console.WriteLine($"{isim} {soyisim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (y/n) ");

                try
                {
                    char onay = char.Parse(Console.ReadLine());
                    switch (onay)
                    {
                        case 'y':
                            Console.WriteLine($"{isim} isimli kişi rehberden başarıyla silindi");
                            person.Remove("isim yada soyadi");
                            break;

                        case 'n':
                            break;

                        default:
                            Console.WriteLine("Yanlış tuşa basıldı. Lütfen (y/n) tuslarından birine basın.");
                            kayitSil();
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Yanlış tuşa basıldı. Lütfen (y/n) tuslarından birine basın " + ex.Message);
                    kayitSil();

                }

            }

            else

            {

                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. ");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1) ");
                Console.WriteLine("* Yeniden denemek için: (2) ");

                try
                {
                    int secim = int.Parse(Console.ReadLine());

                    switch (secim)
                    {
                        case 1:
                            break;
                        case 2:
                            kayitSil();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lütfen 1 ve ya 2 seçiniz." + ex.Message);
                    kayitSil();
                }

            }

        }

        public void kayitGuncelle()
        {

            Console.WriteLine("Lütfen numarasini güncellemek istediğiniz kisinin adini veya soyadini giriniz")

            string guncellenecekKisi = Console.ReadLine();


            if (person.Contains(new kisiler(guncellenecekKisi)))
            {
                Console.WriteLine("Yeni numarayi giriniz:");

                string numara = Console.ReadLine();

                var varmi = person.FirstOrDefault(c => c.isim == guncellenecekKisi);

                if (varmi != null)
                {
                    varmi.cep = numara;
                }
            }



            else

            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("(1) Güncellemeyi Sonlandır ");
                Console.WriteLine("(2) Yeniden Dene           ");

                try
                {
                    int secim = int.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            break;
                        case 2:
                            kayitGuncelle();
                            break;
                        default:
                            Console.WriteLine("Yanlış bir seçim girildi.");
                            Console.WriteLine("Lütfen(1) veya (2) seçeneklerinden birini seçiniz. ");
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(" " + ex.Message);

                }

            }



        }

        public void kayitAra()

        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n*********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            try
            {
                int secilen = int.Parse(Console.ReadLine());

                switch(secilen)
                {
                    case 1:

                        string aranacakKisi = Console.ReadLine();

                        foreach (kisiler item in person)
                        {
                            if(item.isim.ToLower()==aranacakKisi.ToLower() || item.soyisim.ToLower()==aranacakKisi.ToLower())
                            {
                                Console.WriteLine("Arama Sonuçlarınız:\n*********************************************");
                                Console.WriteLine(aranacakKisi);
                            }
                        }

                        break;

                    case 2:

                        string aranacakNum = Console.ReadLine();

                        foreach (kisiler item in person)
                        {
                            if (item.Cep == aranacakNum)
                            {
                                Console.WriteLine("Arama Sonuçlarınız:\n*********************************************");
                                Console.WriteLine(kisi);
                            }

                        }

                        break;

                        default:
                        Console.WriteLine("Hatalı Seçim");
                        kayitAra();
                        break;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Hatalı Seçim" + ex.Message);
                kayitAra();
            }


        }


    }





}
