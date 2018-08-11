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
            EmployeeDetails employeeDetails = new EmployeeDetails();
            Console.WriteLine("New Employee Details added with Employee ID " + employeeDetails.addEmployeeBasicDetails("Hemanth", 31, "Lead Consultant"));
            Console.WriteLine("New Employee Details added with Employee ID " + employeeDetails.addEmployeeBasicDetails("Kannan", 31, "Senior Consultant"));
            Console.WriteLine("New Employee Details added with Employee ID " + employeeDetails.addEmployeeBasicDetails("Suresh", 21, "Technical Architect"));
            employeeDetails.AdditionalDetails.Add("Door No", "21");
            employeeDetails.AdditionalDetails.Add("Building Name", "Raj Bavan");
            employeeDetails.AdditionalDetails.Add("Street Name", "MPS Street");
            employeeDetails.AdditionalDetails.Add("City", "Chennai");
            employeeDetails.AdditionalDetails.Add("State", "Tamil Nadu");
            employeeDetails.AdditionalDetails.Add("Country", "India");
            employeeDetails.addEmployeeAdditionalDetails(2, "Address Details", employeeDetails.AdditionalDetails);
            employeeDetails.AdditionalDetails.Clear();
            employeeDetails.AdditionalDetails.Add("UG", "BE-Cmputer Science");
            employeeDetails.AdditionalDetails.Add("PG", "MBA-Technology Management");
            employeeDetails.AdditionalDetails.Add("University", "Anna University");
            employeeDetails.addEmployeeAdditionalDetails(2, "Qualification", employeeDetails.AdditionalDetails);
                

            employeeDetails.saveEmployeeCollectionToXML();
            Console.ReadLine();
        }
    }
}
