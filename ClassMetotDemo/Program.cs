using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.Adi = "Enes";
            customer1.soyAdi = "Kaplan";
            customer1.Id = 1877342;

            Musteri customer2 = new Musteri();
            customer2.Adi = "Ali";
            customer2.soyAdi = "Kaya";
            customer2.Id = 1877548;

            Musteri customer3 = new Musteri();
            customer3.Adi = "Demir";
            customer3.soyAdi = "Aldırmaz";
            customer3.Id = 1877362;

            Musteri customer4 = new Musteri();
            customer4.Adi = "Nazlı";
            customer4.soyAdi = "Gülengül";
            customer4.Id = 1872242;

            //Listeleme işlemi aşağıdaki gibidir.

            Musteri[] customers = new Musteri[] {customer1, customer2, customer3, customer4 };

            foreach (var dongu in customers)
            {
                Console.WriteLine("Müşteri Adı: " + dongu.Adi);
                Console.WriteLine("Müşteri Soyadı: " + dongu.soyAdi);
                Console.WriteLine("Müşteri ID: " + dongu.Id);
                Console.WriteLine("*-------------------------*");
            }

            //Müşteri silme ve ekleme fonksiyonları ise aşağıdaki gibidir.
            Console.WriteLine("Ekleme İşlemleri");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(customer1);
            musteriManager.Ekle(customer2);
            musteriManager.Ekle(customer3);
            musteriManager.Ekle(customer4);

            Console.WriteLine("Silme İşlemleri");

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Silme(customer1);
            musterimanager.Silme(customer2);
            musterimanager.Silme(customer3);
            musterimanager.Silme(customer4);    






        }
    }
}
