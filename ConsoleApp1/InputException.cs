using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InputException : Exception
    {
        public InputException() : base("Please press r, p, or s!")
        {
        }
    }
}
