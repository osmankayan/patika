using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzodev5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            

            int[] series = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Dizinin {0}. elemanını girin : ", i + 1);
                series[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("series");
            showtheseries(series);

           

            for (int i = 0; i <= series.Length - 1; i++)
            {
                for (int j = 1; j <= series.Length - 1; j++)
                {
                    if (series[j - 1] > series[j])
                    {
                        a = series[j - 1];
                        series[j - 1] = series[j];
                        series[j] = a;
                    }
                }
                showtheseries(series);
            }
            Console.ReadLine();
        }

        public static void showtheseries(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}   ", dizi[i]);
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");

        }
        }
    }

