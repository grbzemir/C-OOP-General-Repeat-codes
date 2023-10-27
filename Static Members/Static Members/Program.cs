using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members
{

    // Başka bir deyişle de bir nesne metodun üreteceği sonucu etkilemeyecek ise o metot static olarak tanımlanır.
    internal class Program
    {
        static void Main(string[] args)
        {

            Daire d1 = new Daire(2);
            float alan1 = d1.AlanHesapla();
            Console.WriteLine(alan1);

            Daire d2 = new Daire(4);
            float alan2 = d2.AlanHesapla();
            Console.WriteLine(alan2);

            Console.ReadLine();
        }
    }
}
