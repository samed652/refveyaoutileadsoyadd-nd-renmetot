﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refveyaoutileadsoyaddöndürenmetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "samed";
            string soyad = "turna";
            int yas = 15;
            AdSoyad adSoyad = new AdSoyad();
            adSoyad.BilgiGuncelle(ref ad, ref soyad, ref yas);


            Console.WriteLine("Önceki Değerler:");
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Yaş: " + yas);

        }
    }
    class AdSoyad
    {
        public void BilgiGuncelle(ref string ad, ref string soyad, ref int yas)
        {
            ad = "NURİ";
            soyad = "TIRAŞ";
            yas = 30;
        }
    }
}
