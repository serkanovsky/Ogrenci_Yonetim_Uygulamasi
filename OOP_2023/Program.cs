using System;
using System.Collections.Generic;
using System.Security.Authentication;

namespace Ogrenci_Yonetim_Uygulamasi
{
    internal class Program
    {
        static List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        static void Main(string[] args)
        {
            SahteVeriGir();
            OgrenciListele();
            Console.WriteLine();
            OgrenciSil();
            OgrenciEkle();

        }
        static void OgrenciEkle()
        {
            Ogrenci o = new Ogrenci();

            Console.WriteLine("1- Ogrenci Ekle ------");
            Console.WriteLine("Ogrencinin");
            Console.Write("No: ");
            o.No = int.Parse(Console.ReadLine());
            Console.Write("Adi: ");
            o.Ad = Console.ReadLine();
            Console.Write("Soyadi: ");
            o.Soyad = Console.ReadLine();
            Console.Write("Subesi: ");
            o.Sube = Console.ReadLine();

            Console.WriteLine("Ogrenciyi kaydetmek istediginize emin misiniz?(E/H");
            string secim = Console.ReadLine();
            if (secim == "e")
            {
                Ogrenciler.Add(o);
                Console.WriteLine("Ogrenci EKlendi");
            }
            else
            {
                Console.WriteLine("Ogrenci eklenmedi");
            }
            Ogrenciler.Add(o);
        }
        static void OgrenciListele()
        {
            Console.WriteLine("2- Ogrenci Listele ----------");
            Console.WriteLine();
            Console.WriteLine("Sube   No     Ad Soyad");
            Console.WriteLine("-----------------------------");

            foreach (Ogrenci ogr in Ogrenciler)
            {
                Console.WriteLine(ogr.Sube + " " + ogr.No + " " + ogr.Soyad);
            }
        }
        static void OgrenciSil()
        {
            Console.WriteLine("3- Ogrenci Sil---------");
            Console.WriteLine("Silmek istediginiz ogrencinin");
            Console.WriteLine("No: ");
            int no = int.Parse(Console.ReadLine());

            foreach (Ogrenci x in Ogrenciler)
            {
                if (x.No==no)
                {
                    Console.WriteLine("Adi: "+x.Ad);
                    Console.WriteLine("Soyadi: "+x.Soyad); 
                    Console.WriteLine("Subesi: "+x.Sube);

                    Console.WriteLine("Ogrenciyi silmek istediginize emin misiniz? (E/H)");
                    string secim = Console.ReadLine().ToLower();
                    if (secim == "e")
                    {
                        Ogrenciler.Remove(x);
                        Console.WriteLine("Ogrenci Silindi");
                    }
                    else
                    {
                        Console.WriteLine("Ogrenci silinmedi.");
                    }

                }
            }
        }

        static void SahteVeriGir()
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Ali";
            o1.Soyad = "Deniz";
            o1.No = 56;
            o1.Sube = "B";

            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Melis";
            o2.Soyad = "Su";
            o2.No = 12;
            o2.Sube = "B";

            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Ali";
            o3.Soyad = "Deniz";
            o3.No = 29;
            o3.Sube = "B";

            Ogrenciler.Add(o1);
            Ogrenciler.Add(o2);
            Ogrenciler.Add(o3);
        }
    }
}
