using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dızıler.GaziKazan.Myo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] dizi = new int[3];
            //dizi:referans
            //dizi[0] = 5;
            //dizi[1] = 8;
            //dizi[2] = 11;
            ////Console.WriteLine(dizi[0]);
            ////Console.WriteLine(dizi[1]);
            ////Console.WriteLine(dizi[2]);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //Console.WriteLine("Kaç tane isim giriceksiniz");
            //int sayi = int.Parse(Console.ReadLine());
            //string[] dizi = new string[sayi];

            //for (int i = 0; i < dizi.Length; i++)
            //    {
            //        Console.WriteLine($"{i+1}.isimi diziniz");
            //           dizi[i] = Console.ReadLine();
            //    }
            //Array.Sort(dizi);
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            double toplam = 0;
            
            Console.WriteLine("Kaç tane sayı  giriceksiniz");
            int sayi = int.Parse(Console.ReadLine());
            int[] sayılar = new int[sayi];
            for (int i = 0; i < sayılar.Length; i++)
            {
                
                Console.WriteLine($"{i + 1}.sayıyı giriniz");
                sayılar[i] = int.Parse(Console.ReadLine());
                toplam += sayılar[i];
            }
            Array.Sort(sayılar);
            for (int i = 0; i < sayılar.Length; i++)
            {

                Console.WriteLine(sayılar[i]);

            }
            Console.WriteLine($"Ortalama:{toplam/sayi}");    


            Console.ReadKey();
        }
    }
}
