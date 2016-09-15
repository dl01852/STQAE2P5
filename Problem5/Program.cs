using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckDate date = new CheckDate();

            Console.WriteLine(date.validMonth(15));
          
        }
    }
}
