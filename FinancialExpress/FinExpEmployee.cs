using FinancialExpress.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialExpress
{
    
    public class GenericList<T>
    {
        private Employee _employeeDetails = new Employee();
        public static List<Employee> EmployeeCollection = new List<Employee>();
        internal Employee EmployeeDetails { get => _employeeDetails; set => _employeeDetails = value; }
        public void Add(T input)
        {


        }
        
    }
    class FinExpEmployee
    {
        private class ExampleClass { }
        static void Main()
        {

            // Declare a list of type ExampleClass.
            GenericList<Employee> list3 = new GenericList<Employee>();
            list3.Add(new Employee());
        }
    }
    
    public class GenericCollection
    {
        public static List<dynamic> dynamicCollection = new List<dynamic>();
        public Dictionary<string, Dictionary<string,dynamic>> masterCollection= new Dictionary<string, Dictionary<string, dynamic>>();

        public void AddDetails(string strKey, Dictionary<string, dynamic> addCollection)
        {
            masterCollection.Add(strKey, addCollection);
        }
        public void AddCustomEmployeeDetails(string strKey,List<object> dyContents)
        {
            
        }
        public void AddEmployeeDetails(dynamic EmployeeDetails)
        {
            EmployeeDetails = new Employee();
            Console.WriteLine("Enter Employee Name");
            EmployeeDetails.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Age");
            EmployeeDetails.EmpAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Designation");
            EmployeeDetails.EmpDesignation = Console.ReadLine();
            //EmployeeCollection.Add(new Employee() { Id = EmployeeCollection.Count() > 0 ? EmployeeCollection.Max(x => x.Id) + 1 : 1, EmpAge = EmployeeDetails.EmpAge, EmpName = EmployeeDetails.EmpName, EmpDesignation = EmployeeDetails.EmpDesignation });
            Console.WriteLine("Employee Details Added");
        }

    }
}
