using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //works
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            
            foreach (var worker in workers)
            {
                worker.Work();
            }
            
            //Eats
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            
            //Gets salary
            ISalary[] getsSalary = new ISalary[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var salary in getsSalary)
            {
                salary.GetSalary();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();

    }

    //SOLID, Interface Segregation
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Launch Break for managers and workers!");
        }

        public void GetSalary()
        {
            Console.WriteLine("Payday for managers and workers!");
        }

        public void Work()
        {
            Console.WriteLine("Work time for everyone!");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
           
        }

        public void GetSalary()
        {
           
        }

        public void Work()
        {
            
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            
        }
    }
}
