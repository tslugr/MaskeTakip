﻿using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {


            SelamVer(isim:"Uğur");
            SelamVer();
            SelamVer();
            int sonuc = Topla(6, 58);
            //Diziler /Arrays

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Uğur";
            ogrenciler[1] = "Nevin";
            ogrenciler[2] = "Halide";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            Console.ReadLine();
        }
        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5,int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+sonuc);
            return sonuc;
        }
    }
    
}
