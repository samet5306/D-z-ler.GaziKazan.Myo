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
            
            Console.WriteLine("Kaç tane isim giriceksiniz");
            int sayi = int.Parse(Console.ReadLine());
            string[] dizi = new string[sayi];
            
            for (int i = 0; i < dizi.Length; i++)
                {
                    Console.WriteLine($"{i+1}.isimi giriniz");
                       dizi[i] = Console.ReadLine();
                }
            Array.Sort(dizi);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            
            
            Console.ReadKey();
        }
    }
}
