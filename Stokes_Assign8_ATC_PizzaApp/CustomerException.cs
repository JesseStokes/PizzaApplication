using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stokes_Assign8_ATC_PizzaApp
{
    class CustomerException : ApplicationException
    {
        public CustomerException(string message)
            : base(message)
        {

        }
    }
}
