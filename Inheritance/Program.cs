using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{Firstname = "Aslı"},
                new Student{Firstname = "Oğuzcan"},
                new Person{Firstname = "Mehmet"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.Firstname);
            }
            Console.ReadLine();

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }
    //Only one parent allowed for each class. Parent first interface later.
    class Person2
    {

    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
