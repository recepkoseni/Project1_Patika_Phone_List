using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Patika
{
    class islemler
    {
        kisiler kisi = new kisiler();
        public List<kisiler> person = new List<kisiler>();



        public List<kisiler> kayitEkle()
        {
            

            Console.WriteLine("Lütfen isim giriniz: ");       
            string isim = kisi.isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz: ");
            string soyisim = kisi.soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen cep numarası giriniz: ");
            string cep = kisi.cep = Console.ReadLine();

            person.Add(new kisiler(isim,soyisim,cep));


            return person;




        }

        public void kayitListele(List<kisiler> liste)
        {
            Console.WriteLine("     Telefon Rehberi     ");
            Console.WriteLine("*************************");
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }

    }
}
