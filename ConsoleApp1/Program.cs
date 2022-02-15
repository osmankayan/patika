using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciGelenDeger = string.Empty;

        // Goto kullanımı için bir başlık tanımlaması yapalım. 

        YenidenSecim:

            Console.WriteLine("Lütfen bulunduğunuz ay'ın sayısal değerini yazınız");
            kullaniciGelenDeger = Console.ReadLine();

            switch (kullaniciGelenDeger)
            {
                case "1": Console.WriteLine("Ocak"); break;
                case "2": Console.WriteLine("Şubat"); break;
                case "3": Console.WriteLine("Mart"); break;
                case "4": Console.WriteLine("Nisan"); break;
                case "5": Console.WriteLine("Mayıs"); break;
                case "6": Console.WriteLine("Haziran"); break;
                case "7": Console.WriteLine("Temmuz"); break;
                case "8": Console.WriteLine("Agustos"); break;
                case "9": Console.WriteLine("Eylül"); break;
                case "10": Console.WriteLine("Ekim"); break;
                case "11": Console.WriteLine("Kasım"); break;
                case "12": Console.WriteLine("Aralık"); break;
                default:
                    Console.WriteLine("Aralık dışı değer girişi yaptınız...");
                    goto YenidenSecim;
            }
        }
    }
}
