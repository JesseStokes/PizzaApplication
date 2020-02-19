using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stokes_Assign8_ATC_PizzaApp
{
    class NegativeException : ApplicationException
    {
        public NegativeException(string message)
            : base(message)
        {

        }
    }
}
