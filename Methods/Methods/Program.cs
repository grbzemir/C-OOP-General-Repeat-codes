using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Program p = new Program();

            // program sınıfından bir nesne tanımlamış olduk.

            int sonuc = p.Topla(5, 6);
            int carpimSonuc = p.Carp(5, 6);

            Console.WriteLine("Toplam sonucu  = " + sonuc);

            Console.WriteLine("Carpım Sonucu  = "  + carpimSonuc);
            Console.ReadLine();

        }

        private int Topla(int a , int b)
        {
                return a + b;
        }
        

        int Carp(int x , int y)
        {
            return x * y;
        }
    
    }
}
