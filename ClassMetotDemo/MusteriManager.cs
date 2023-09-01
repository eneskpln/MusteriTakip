using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri dongu) 
        {
            Console.WriteLine("Eklenen Müşteri: " + dongu.Adi + " " + dongu.soyAdi);
           
        }
           
        public void Silme(Musteri dongu)
        {
            Console.WriteLine("Silinen Müşteri: " + dongu.Adi + " " + dongu.soyAdi);
        }
    }
}
