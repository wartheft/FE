using FinancialExpress.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinancialExpress
{
    class Program
    {

        static void Main(string[] args)
        {
            DynamicDecorator test = new DynamicDecorator();
            test.Bob();
            Console.ReadLine();
        }
    }
}
