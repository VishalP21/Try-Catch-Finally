using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Finally
{
    public class ErrorExcaption : Exception
    {
        public ErrorExcaption(string message) : base(message)
        {

        }
    }
}
