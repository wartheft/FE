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

            EmployeeBase empBase = EmployeeBase.Instance();

            do
            {
                empBase.LoadMenuAction();
            } while (empBase.UserChoice != '5');

        }


    }
}
