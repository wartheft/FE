using FinancialExpress.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FinancialExpressLib
{
    class EmployeeBase
    {
        private static EmployeeBase _instance;
        private Employee _employeeDetails = new Employee();
        private char userChoice = '5';
        public static List<Employee> EmployeeCollection = new List<Employee>();
        public char UserChoice { get => userChoice; set => userChoice = value; }
        internal Employee EmployeeDetails { get => _employeeDetails; set => _employeeDetails = value; }


        protected EmployeeBase()
        {
        }

        public static EmployeeBase Instance()
        {

            if (_instance == null)
            {
                _instance = new EmployeeBase();
            }

            return _instance;
        }
        public void printMenuHeader(int Count, char printChracter, string strPrintMenuHeader)
        {
            int i;
            for (i = 0; i < Count; i++)
            {
                Console.Write(printChracter);
            }
            Console.Write(strPrintMenuHeader);
            for (i = 0; i < Count; i++)
            {
                Console.Write(printChracter);
            }

        }
        public void LoadMenuAction()
        {
            Console.WriteLine("\n \n");
            printMenuHeader(25, '#', "EMPLOYEE DETAILS");
            Console.WriteLine("\n");
            Console.WriteLine("#1 List Employee Details");
            Console.WriteLine("#2 Add New Employee");
            Console.WriteLine("#3 Delete Existing Employee");
            Console.WriteLine("#4 Save Employee Details");
            Console.WriteLine("#5 Close Application");
            Console.WriteLine("Please choose your action#");

            try
            {

                UserChoice = Console.ReadKey().KeyChar;
                if (!string.IsNullOrWhiteSpace(UserChoice.ToString()))
                {
                    switch (UserChoice)
                    {
                        case '1':
                            Console.WriteLine("ListUser Details");
                            ListEmployeeDetails();
                            break;
                        case '2':
                            Console.WriteLine("Add New User");
                            AddEmployeeDetails();
                            break;
                        case '3':
                            Console.WriteLine("Enter the Employee ID to Delete Existing Employee");
                            DeleteEmployeeDetails(Console.ReadLine());
                            break;
                        case '4':
                            Console.WriteLine("Save Employee Details");
                            SaveEmployeeList("XML");
                            break;
                        case '5':
                            Console.WriteLine("Close Application");
                            break;
                        default:
                            DisplayErrorMessage("Choose a Valid input from the list");
                            LoadMenuAction();
                            break;
                    }

                }
                else
                {
                    DisplayErrorMessage("Choose a Valid input from the list");
                    LoadMenuAction();
                }

            }
            catch (Exception ex)
            {

                DisplayErrorMessage(ex.Message);
            }
        }
        public void DisplayErrorMessage(String strErrorMessage)
        {
            Console.WriteLine(strErrorMessage);
        }
        public void AddEmployeeDetails()
        {
            EmployeeDetails = new Employee();
            Console.WriteLine("Enter Employee Name");
            EmployeeDetails.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Age");
            EmployeeDetails.EmpAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Designation");
            EmployeeDetails.EmpDesignation = Console.ReadLine();
            EmployeeCollection.Add(new Employee() { Id = EmployeeCollection.Count() > 0 ? EmployeeCollection.Max(x => x.Id) + 1 : 1, EmpAge = EmployeeDetails.EmpAge, EmpName = EmployeeDetails.EmpName, EmpDesignation = EmployeeDetails.EmpDesignation });
            Console.WriteLine("Employee Details Added");
        }

        public void DeleteEmployeeDetails(string Value)
        {
            if (!String.IsNullOrWhiteSpace(Value) && Int32.TryParse(Value, out int _DeleteEmployee))
            {
                EmployeeCollection.Remove(EmployeeCollection.Single(r => r.Id == _DeleteEmployee));
                Console.WriteLine("Employee Details with Employee ID " + _DeleteEmployee + " has been Removed");
            }
        }
        public void ListEmployeeDetails()
        {
            Console.WriteLine("\n \n");
            printMenuHeader(30, '#', "EMPLOYEE LIST");
            Console.WriteLine("\n");
            Console.Write(String.Format("|{0,15}|{1,15}|{2,15}|{3,15}|\n", "Employee ID", "Name", "Designation", "Age"));
            EmployeeCollection.ForEach(i => Console.Write(String.Format("|{0,15}|{1,15}|{2,15}|{3,15}|\n", i.Id, i.EmpName, i.EmpDesignation, i.EmpAge)));
        }
        public void SaveEmployeeList(string strSaveAs)
        {
            try
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(List<Employee>));
                //TextWriter for serializing 
                TextWriter filestream = new StreamWriter(@"D:\output.xml");
                //write to the file
                serialiser.Serialize(filestream, EmployeeCollection);
                // Close the file
                filestream.Close();
                Console.WriteLine("Converted to XML");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
