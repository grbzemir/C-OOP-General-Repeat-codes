using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    public interface IMusteri

    { 
        void EkranaYaz();
      
    }

    public class BireyselMusteri:IMusteri

    {
        public void EkranaYaz() 
        
        {

            Console.WriteLine("Ben bireysel müşteriyim");

        }
    }

    public class KurumsalMusteri:IMusteri 
    
    { 

        public void EkranaYaz() 
        
        {

            Console.WriteLine("Ben kurumsal müşteriyim");

        }
    
    }
    internal class Program

      
    {
        static private void Goster(IMusteri musteri)
        {

            musteri.EkranaYaz();

        }

        static void Main()

        {

            KurumsalMusteri musteri = new KurumsalMusteri();
            BireyselMusteri musteri1 = new BireyselMusteri();

            Program.Goster(musteri1);


        }


            // soyut sınıflardan ve ınterfaceden nesne üretemezsin
        }
    }

