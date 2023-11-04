﻿using ConsoleApp2.Context;
using ConsoleApp2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //One();

            using (var northwindContext = new NorthWindContext())

            { 
                
                List<Customer> result = (from c in northwindContext.Customers

                    where c.Country == "UK" && c.City == "London"
                   

                    select c).ToList();

                foreach (var customer in result)

                {

                    Console.WriteLine("Contact name : {0} , city: {1} " , customer.ContactName , customer.City);
                }
            
            
            }

            //using (var northwindContext = new NorthWindContext())

            //{

            //    var result = from c in northwindContext.Customers

            //                 select new {Adi =  c.ContactName ,  Şirketi = c.CompanyName ,Ulke = c.Country } ;
                
            //    foreach (var musteri in result)

            //    {

            //        Console.WriteLine(musteri.Şirketi);

            //    }

            //}

            //using (var northwindContext = new NorthWindContext())

            //{

            //    List<Customer> result = (from c in northwindContext.Customers

            //                                  select c).ToList();

            //    foreach (var customer in result)

            //    {

            //        Console.WriteLine(customer.ContactName);
            //    }
                
                
            //}

            //using (var NorthWindContext = new NorthWindContext())

            //{

            //    Customer customer = NorthWindContext.Customers.Find("Emir");
                
            //    customer.Country = "Turkey";

            //    NorthWindContext.SaveChanges();

            //    Console.WriteLine("Customer is updated");
            
            //}


            //using (var northwindContext = new NorthWindContext())

            //{

            //    Order order = northwindContext.Orders.Find(1);

  
            //    northwindContext.Orders.Remove(order);
            //    northwindContext.SaveChanges();
            //    Console.WriteLine("Order is deleted");

            //}

            //using (var northwindContext = new NorthWindContext())

            //{

            //    Customer customer = northwindContext.Customers.Find("Emir");
            //    customer.Orders.Add(

            //    new Order

            //    {
            //        OrderId = 1,
            //        OrderDate = DateTime.Now,
            //        ShipCity = "Istanbul",
            //        ShipCountry = "Turkey"

            //    });

            //    northwindContext.SaveChanges();

            //}

           
            

        //    using (var northwindContext = new NorthWindContext()) 

        //    {

        //        var customer = new Customer

        //        {

        //            CustomerId = "Emir",

        //            City = " Istanbul",

        //            CompanyName = "GürbüzSoft",

        //            ContactName = "emircangrz@gmail.com",

        //            Country = "Türkiye"
        //        };

        //        northwindContext.Customers.Add(customer);
        //        northwindContext.SaveChanges();

        //    }


        //    Console.ReadLine();

        }

            private static void One()

            {

                using (var NorthWindContext = new NorthWindContext())
                {

                    foreach (var customer in NorthWindContext.Customers)
                    {
                        Console.WriteLine("Customer Name : {0} ", customer.CompanyName);
                    }

                }



                // Apache License 2.0
            }
        }
    }

