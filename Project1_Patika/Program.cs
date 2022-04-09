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
            


            
            yeniIslem.Rehber();

            while (true)
            {
                try
                {
                    int secim = int.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            yeniIslem.kayitEkle();
                            break;
                        case 2:
                            yeniIslem.kayitSil();
                            break;
                        case 3:
                            yeniIslem.kayitGuncelle();
                            break;
                        case 4:
                            yeniIslem.kayitListele();
                            break;
                        case 5:
                            yeniIslem.kayitAra();
                            break;
                        case 0:
                            Console.WriteLine("Program Kapatılıyor.");
                            break;
                        default:
                            Console.WriteLine("Program Kapatılıyor.");
                            break;

                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Hatalı Seçim. Program Kapanıyor " + ex.Message);
                }


            }



        }
    }
}
