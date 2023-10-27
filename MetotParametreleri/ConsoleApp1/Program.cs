using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] _params = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            ParametreMethodu (_params);
            int i;
            i = 5;

            int Toplam;
            int Carpim;


            Hesapla(5, 6 , out Toplam, out Carpim);
            Console.WriteLine("sum = {0} ve carpim = {1}" , Toplam,Carpim);
            
            Console.ReadKey();

        }

        public static void OrnekMethod(int a)

        {
            a = 10;
        }

        public static void OrnekMetod2(ref int b)
        // referans olarak tamamladım
        {
            b = 10;
        }

         public static void Hesapla(int Fn,  int  Sn, out int Sum, out int Product)

         { 

             Sum = Fn + Sn;
             Product = Fn * Sn;
            

         }

        public static void ParametreMethodu(params int[] numbers)
        {
            Console.WriteLine("Number of elements: {0}", numbers.Length);
          
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }


   }

}


