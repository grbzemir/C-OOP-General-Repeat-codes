using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{

    public class Musteri

    { 
    public int ID;
    public string Name;
    public string Surname;
    
    public void Info()

        {
            Console.WriteLine("Musteri Bilgileri Id: {0} Name: {1} {2} ", ID,Name,Surname);
        }
    }
    


    internal class Program
    {
        static void Main(string[] args)
        {

             Musteri m1 = new Musteri();
             m1.ID = 1;
             m1.Name = "Ali";
             m1.Surname = "Veli";
             m1.Info();

            Musteri m2 = new Musteri();

            m2.ID = 2;
            m2.Name = "Ayşe";
            m2.Surname = "Fatma";
            m2.Info();

        }
    }
}
