using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{

    internal class Program
    {

        public class Musteri

        {
            public int ID;
            public string Name;

            public Musteri()
            {
            }

            public Musteri(int id) 
            
        {
           
             this.ID = id;
        }

         public Musteri(int id , string name)

            {

                this.ID = id;
                this.Name = name;
            }
         public void PrintName()

            {
                Console.WriteLine("Id = {0} and Name = {1}", this.ID,this.Name);
            }

        

        }
        static void Main(string[] args)
        {

            Musteri m = new Musteri();
            m.ID = 1;
            m.Name = "Emir";
            m.PrintName();
            
            
            Musteri m2 = new Musteri();

            m2.ID = 2;
            m2.Name = "Yetkin";
            m2.PrintName();





            Console.ReadKey();

            

        }
    }
}
