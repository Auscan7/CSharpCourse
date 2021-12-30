using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class RecordNotFoundExcepion:Exception
    {
        public RecordNotFoundExcepion(string message):base(message)
        {

        }
    }
}
