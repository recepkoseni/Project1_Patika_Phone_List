using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Patika
{
    class Program
    {
        static void Main(string[] args)
        {
            islemler yeniIslem = new islemler();
            List<kisiler> person1 = new List<kisiler>();


            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seciniz veya cikmak icin E basiniz :) ");
                Console.WriteLine("********************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek) ");
                Console.WriteLine("(2) Varolan Numarayi Silmek ");
                Console.WriteLine("(3) Varolan Numarayi Güncellemek ");
                Console.WriteLine("(4) Rehberi Listelemek ");
                Console.WriteLine("(5) Rehberde Arama Yapmak");



                try
                {
                    string giris = Convert.ToString(Console.ReadLine());

                    if (giris == "1")
                    {

                       person1= yeniIslem.kayitEkle();

                    }

                    else if (giris == "4")
                    {
                        yeniIslem.kayitListele(person1);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı giriş yaptiniz !");

                } 
            }


        }
    }
}
