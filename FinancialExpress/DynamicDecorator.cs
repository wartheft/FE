using FinancialExpress.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialExpress
{
    class DynamicDecorator
    {
        public void Bob()
        {
            List<dynamic> data = new List<dynamic>();
            Employee employee = new Employee();            
            data.Add(new { a = 1, b = "test",c=employee });
            Fred(data);
        }
        private void Fred(List<dynamic> data)
        {
            //Fred processing logic
            foreach (var datum in data)
            {
                Console.WriteLine(String.Format("{0}: {1}", datum.a, datum.b));
            }
        }
    }
}



