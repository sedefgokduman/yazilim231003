﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim231003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci sayıyı giriniz");
            int sayi1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz");
            int sayi2=Convert.ToInt16(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.WriteLine($"iki sayının toplamı {toplam}");
            Console.ReadKey();
        }
    }
}
