﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Patika
{
    class kisiler
    {
        

        
        public kisiler() { }


        public string isim;
        public string soyisim;
        public string cep;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Cep { get => cep; set => cep = value; }

        public kisiler(string isim, string soyisim, string cep) 
        {
            Isim = isim;
            Soyisim = soyisim;
            Cep = cep;

           

           


        }



    }

}
