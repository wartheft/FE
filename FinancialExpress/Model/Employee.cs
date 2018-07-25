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
        private int _validateInt(dynamic value)
        {
            if (!(!String.IsNullOrWhiteSpace(value) && Int32.TryParse(value, out int reValue)))
            {
                throw new Exception("Enter Valid Input");
            }
            return value;
        }
        private string _validateString(dynamic value)
        {
            if (!(!String.IsNullOrWhiteSpace(value) && (value!= string.Empty)))
            {
                throw new Exception("Enter Valid Input");
            }
            return value;
        }
        public int Id { get => _id; set => _id = _validateInt(value); }
        public string EmpName { get => _empName; set => _empName = _validateString(value); }
        public int EmpAge { get => _empAge; set => _empAge = _validateInt(value); }
        public string EmpDesignation { get => _empDesignation; set => _empDesignation = _validateString(value); }

    }
    public class ErrorEmployee : Employee
    {
        public string[] ErrorReason { get; set; }
    }
}
