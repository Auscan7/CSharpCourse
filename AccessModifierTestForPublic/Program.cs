using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;  //başka projeyi kullanmak için

namespace AccessModifierTestForPublic
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course(); //public class olduğu için farklı projede(burada) geçerli.
        }
    }
}
