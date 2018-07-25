using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialExpress.Model
{
    [Serializable()]
    public class Employee
    {
        private int _id;
        private string _empName;
        private int _empAge;
        private string _empDesignation;
     
        public int Id { get => _id; set => _id = value; }
        public string EmpName { get => _empName; set => _empName = value; }
        public int EmpAge { get => _empAge; set => _empAge = value; }
        public string EmpDesignation { get => _empDesignation; set => _empDesignation =value; }

    }
    public class ErrorEmployee : Employee
    {
        public string[] ErrorReason { get; set; }
    }
}
