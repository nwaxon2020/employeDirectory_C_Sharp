using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using SetEmployee;

namespace Function
{
    //function class to hold diffrent functions
    public class Functions
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }

        List<Employee> employee = new();

        //Add employee method/function
        public Employee AddEmployee()
        {
            //get ID
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            //get Name
            Console.Write("Enter Employee Name: ");
            string? name = Console.ReadLine() ?? "No Name";
            Name = name;

            //get Department
            Console.Write("Enter Employee Deparment: ");
            string? department = Console.ReadLine() ?? "No Department";

            //get Phone Number
            Console.Write("Enter Employee Phone Number: ");
            string? phoneNumber = Console.ReadLine() ?? "No Phone Number";
            PhoneNumber = phoneNumber;

            //get Salary
            Console.Write("Enter Employee Salary: ");
            double salary = double.Parse(Console.ReadLine() ?? "0.00");


            //return object so it can be added to the employee list
            return new Employee(id, name, department, phoneNumber, salary);

        }

        //diplay name and phone number of the employee added
        public void DisplayAddedEmploye()
        {
            Console.WriteLine($"Name: {Name}\nPhone_Number: {PhoneNumber}");
        }

        public void ViewEmployee()
        {
            if (employee.Count == 0)
            {
                Console.WriteLine("\nPlease wait.....");
                Thread.Sleep(3000);
                Console.WriteLine("Employe not found");
                return;
            }
            else
            {
                Console.WriteLine("\nPlease wait.....");
                Thread.Sleep(3000);
                foreach (var item in employee)
                {
                    item.DisplayEmployee();
                    Console.WriteLine("--------------------------------------");
                }
            }
        }

        public void EditEmployee()
        {
            Console.Write("Enter Employee's ID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            var emp = employee.FirstOrDefault(e => e.Id == id);
            if (emp == null)
            {
                Console.WriteLine("\nPlease wait.....");
                Thread.Sleep(3000);
                Console.WriteLine("Employee not Found");
            }
            else
            {
                Console.Write("Enter Employee's Name: ");
                emp.Name = Console.ReadLine() ?? emp.Name;

                Console.Write("Enter Employee's Department: ");
                emp.Department = Console.ReadLine() ?? emp.Department;

                Console.Write("Enter Employee's PhoneNumber: ");
                emp.PhoneNumber = Console.ReadLine() ?? emp.PhoneNumber;

                Console.Write("Enter Employee's Salary: ");
                emp.Salary = double.Parse(Console.ReadLine() ?? $"{emp.Salary}");
            }
        }

    }
}