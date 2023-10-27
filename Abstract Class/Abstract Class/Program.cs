using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class

    // soyut sınıflar abstract class
{

    abstract public class TemelSınıf

    {
        abstract public void Islem();

        public void Test()

        {
            Console.WriteLine("Soyut olmayan metot cagırıldı");
        }
    }

    public class TureyenSınıf1 : TemelSınıf

    {
        public override void Islem()
        {
            Console.WriteLine("Türeyen sınıf 1 metodu cagırıldı");
        }

    }

    public class TureyenSınıf2 : TemelSınıf

    {
        public override void Islem()
        {
            Console.WriteLine("Türeyen sınıf 2 metodu cagırıldı");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            TemelSınıf ts1 = new  TureyenSınıf1();
            ts1.Islem();
            ts1.Test();

            TemelSınıf ts2 = new TureyenSınıf2();
            ts2.Islem();

            ts2.Test();
        }
    }
}
