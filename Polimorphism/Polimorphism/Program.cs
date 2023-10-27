using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{


    public class TemelSınıf

    {

         public int en;
         public int boy;

        virtual public int Alan()

        {
            return 0;
        }
       
    }

    public class Ucgen:TemelSınıf 
    
    {
        override public  int Alan()
        {

            return en*boy / 2;
        }

    }

    public class Dortgen:TemelSınıf

    {
       override public  int Alan()
        {

            return en * boy;
        
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {

            TemelSınıf Ucgen = new Ucgen();
            Ucgen.en = 5;
            Ucgen.boy = 4;
            Ucgen.Alan();

            int alan =  Ucgen.Alan();
            Console.WriteLine("ucgenin alanı = " + alan);

            TemelSınıf dortgen = new Dortgen();

            dortgen.en = 3;
            dortgen.boy = 9;
            dortgen.Alan();

            int alan2 = dortgen.Alan();
            Console.WriteLine("Dorgenin alanı = " + alan2 );


            Console.ReadKey();
           
        }
    }
}
