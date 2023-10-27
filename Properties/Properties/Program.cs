using Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Properties
{
    public class Ogrenci

    {
        private int _id;
        private string _Name;
        private static int _Devamsizlik = 20;

        public int no

        {
            set;
            get;
        }
        public int Id
        {
            set

            {
                if (value <= 0)

                {
                    Console.WriteLine("Id 0 veya 0 dan küçük olamaz");
                }

                else

                {
                    this._id = value;
                }

            }
            get

            {

                return this._id;

            }


        }

        public string Name

        {
            set
            {

                if (string.IsNullOrEmpty(value))

                {

                    Console.WriteLine("isim null veya boş olamaz");
                }

                this._Name = value;

            }

            get

            {

                if (string.IsNullOrEmpty(this._Name))

                {

                    return "isim girilmemiş";

                }

                else

                {
                    return this._Name;

                }

            }


        }



        //public void SetId(int Id)

        //{

        //    if (Id <= 0)

        //    {
        //        Console.WriteLine("Id 0 veya 0 dan küçük olamaz");
        //    }

        //    else

        //    {
        //        this._id = Id;
        //    }


        //}

        //public int GetId()

        //{

        //    return this.GetId();

        //}

        //public void SetName(string Name)

        // {

        //     if (string.IsNullOrEmpty(Name))

        //     {

        //         Console.WriteLine("isim null veya boş olamaz");
        //     }


        // }

        //public string GetName()


        //{

        //    if (string.IsNullOrEmpty(this._Name))

        //    {

        //        return "isim girilmemiş";

        //    }

        //    else

        //    {
        //        return this._Name;

        //    }


        //}

        public int Devamsizlik

        {
            get


            {

                return Ogrenci._Devamsizlik;

            }


        }

    }
        internal class Program
        {
            static void Main(string[] args)

            {


                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Id = -40;
                ogrenci.Name = "emir";
                ogrenci.no = 81;
                Console.WriteLine("ID = {0} / İsmi = {1} ogrenci no = {2} / Aşılması gereken devamsızlık süresi {2} gündür ", ogrenci.Id, ogrenci.no, ogrenci.Name, ogrenci.Devamsizlik);

                Console.ReadLine();



            }
        }

    }
