using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading
{
    public class Program
    {
        static void Main(string[] args)
        {

            Topla(5, 6);
            Topla(5, 6, 7);
            Topla(5.5f, 6.5f);
            Topla(10 , 15, out int b);
            Topla(10, 15, new int[] { 1, 2, 3, 4, 5 });
            Console.ReadKey();

        }

        static void Topla(int a , int b)

        {
            int sonuc = a + b;
            Console.WriteLine("Toplam Sonucu = {0} " , sonuc);


        }

        static void Topla(int a , int b , int c)
        {
            int sonuc = a + b + c;
            Console.WriteLine("Toplam Sonucu = {0} ", sonuc);
        }

        static void Topla(float a , float b)

        {
            float sonuc = a + b;
            Console.WriteLine("Toplam Sonucu = {0} ", sonuc);
        }
        
        static void Topla(int a , int b , out int sonuc)

        {
            sonuc = a + b;

            Console.WriteLine("ilk metot cagırıldı & toplam = {0}" , sonuc);

        }

        static void Topla(int a , int b , int[] dizi)

        {

        }

        static void Topla(int a , int b , params float[] dizi1)

        {

        }
    }
}
