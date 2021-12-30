using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]); hatalı kod

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Oğuzcan" });
            //customers.Add(new Customer { Id = 2, FirstName = "Aslı" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Oğuzcan" },
                new Customer { Id = 2, FirstName = "Kate" },
                new Customer { Id = 3, FirstName = "Akil" },
                new Customer { Id = 4, FirstName = "Sıla" }
            };

            var customer2 = new Customer
            {
                Id = 5,
                FirstName = "Salih"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[1]
            {
                new Customer{Id = 6, FirstName = "Ali" },

            });

            //Console.WriteLine(customers.Contains(customer2));

            //customers.Clear();

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index:{0}", index);

            customers.Add(customer2);

            var lastIndex = customers.LastIndexOf(customer2);
            Console.WriteLine("Last Index:{0}", lastIndex);

            customers.Insert(0, customer2);

            //customers.Remove(customer2);
            //customers.Remove(customer2);

            customers.RemoveAll(c => c.FirstName == "Salih");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine("Count:{0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            // Console.WriteLine(cities[2]);
        }
    }


    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
