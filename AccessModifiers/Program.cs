using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        protected int Id { get; set; }

        //private int id; eğer kodun en ilk bloğundaysa içerdeki tüm bloklar kullanabilir

        public void Add()
        {
                            
        }

        public void Delete()
        {
            //private int id -- eğer bir bloğun içindeki bir bloktaysa dışardaki bloklar erişemez
        }
    }

    class Student:Customer
    {
        public void Save()
        {
            //Id  protected sayesinde inherit edilddiği sınıflarda erişilebilir.
            Customer customer = new Customer();
            //customer.id   private sadece tanımlandığı bloktan erişilebilir
        }
    }

    public class Course //internal bir classın default'idir. Aynı proje içersiinde istediğimiz noktada çağırabiliriz!
    {
        public string Name { get; set; }
        private class NestedClass // sadece nested classlar private olabilir!
        {

        }
    }
}
