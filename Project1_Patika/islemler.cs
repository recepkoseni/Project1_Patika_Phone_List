using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Patika
{
    class islemler : kisi
    {
        kisi kisi = new kisi();
        public List<kisi> person = new List<kisi>();


        public void Rehber()
        {
            //Default 5 kisilik listeyi ekli halde listele

            person.Add(new kisi("Recep", "Koseni", "9090"));
            person.Add(new kisi("Batman", "Koseni", "7272"));
            person.Add(new kisi("Spiderman", "Koseni", "1111"));
            person.Add(new kisi("Ironman", "Koseni", "7878"));
            person.Add(new kisi("Xman", "Koseni", "0000"));
        }
        public void kayitEkle()
        {


            Console.WriteLine("\nLütfen isim giriniz: ");
            isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz: ");
            soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen cep numarasi giriniz: ");
            cep = Console.ReadLine();

            person.Add(new kisi(isim, soyisim, cep));


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

            Menu();

            //try
            //{
               
            //    string secim = Console.ReadLine();
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Hatali Giriş.Tekrar deneyiniz");
            //    ka
            //}


        }

        public void kayitSil()
        {

            Console.WriteLine("Lütfen numarasini silmek istediğiniz kisinin adini veya soyadini giriniz");
            string silinicekKisi = Console.ReadLine();
        

            //Kisi Var ise

            if (person.Any(c=> c.Isim.Contains(silinicekKisi)) || person.Any(c => c.Soyisim.Contains(silinicekKisi)))
            {

                kisi kisiSilinecek = person.First(c => c.Isim.Contains(silinicekKisi) || c.soyisim.Contains(silinicekKisi));
                Console.WriteLine($"{kisiSilinecek.Isim} {kisiSilinecek.Soyisim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (y/n) ");

                try
                {
                    char onay = char.Parse(Console.ReadLine());
                    switch (onay)
                    {
                        case 'y':
                            Console.WriteLine($"{kisiSilinecek.Isim} isimli kişi rehberden başarıyla silindi\n");
                            person.Remove(kisiSilinecek);
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

            
            Menu();

        }

        public void kayitGuncelle()
        {

            Console.WriteLine("Lütfen numarasini güncellemek istediğiniz kisinin adini veya soyadini giriniz\n");

            string guncellenecekKisi = Console.ReadLine();


            if (person.Count(c=>c.Isim.Contains(guncellenecekKisi))>0 || person.Count(c => c.Soyisim.Contains(guncellenecekKisi)) > 0) // 
            {
                Console.WriteLine("\nYeni numarayi giriniz:");

                string numara = Console.ReadLine();

                kisi varmi = person.FirstOrDefault(c => c.Isim == guncellenecekKisi || c.Soyisim==guncellenecekKisi);

                if (varmi != null)
                {
                    varmi.Cep = numara;


                    Console.WriteLine($"\nisim : {varmi.Isim}");
                    Console.WriteLine($"soyisim : {varmi.Soyisim}");
                    Console.WriteLine($"Telefon Numarasi : {varmi.Cep}\n");

                   
                }
            }



            else

            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("(1) Güncellemeyi Sonlandır ");
                Console.WriteLine("(2) Yeniden Dene           \n");

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
                            Console.WriteLine("Lütfen(1) veya (2) seçeneklerinden birini seçiniz. \n");
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(" " + ex.Message);

                }

            }

            Menu();

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

                        Console.WriteLine("\nAranacak kisinin adini giriniz:");
                        string aranacakKisi = Console.ReadLine();

                        foreach (kisi item in person)
                        {
                            if(item.Isim.ToLower()==aranacakKisi.ToLower() || item.soyisim.ToLower()==aranacakKisi.ToLower())
                            {
                                Console.WriteLine("Arama Sonuçlarınız:\n*********************************************");
                                Console.WriteLine($"\nisim : {item.Isim}");
                                Console.WriteLine($"soyisim : {item.Soyisim}");
                                Console.WriteLine($"Telefon Numarasi : {item.Cep}\n");
                            }
                        }

                        break;

                    case 2:

                        Console.WriteLine("\nAranacak kisinin cep numarasını giriniz:");
                        string aranacakNum = Console.ReadLine();

                        foreach (kisi item in person)
                        {
                            if (item.Cep == aranacakNum)
                            {
                                Console.WriteLine("\nArama Sonuçlarınız:*********************************************");
                                Console.WriteLine($"\nisim : {item.Isim}");
                                Console.WriteLine($"soyisim : {item.Soyisim}");
                                Console.WriteLine($"Telefon Numarasi : {item.Cep}\n");

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


            Menu();
        }


    }





}
