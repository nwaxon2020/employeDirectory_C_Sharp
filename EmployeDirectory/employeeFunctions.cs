
using SetEmployee;
// Name space to avoid conflict of class
namespace Function
{
    //function class to hold diffrent functions
    public class Functions
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }

        List<Employee> employee = new();

        //file variable
        private const string DataFilePath = "employees.data";


        //Add employee method/function
        public void AddEmployee()
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

            // Address information
            Console.Write("Enter Street: ");
            string street = Console.ReadLine() ?? "No Street";

            Console.Write("Enter City: ");
            string city = Console.ReadLine() ?? "No City";

            Console.Write("Enter State: ");
            string state = Console.ReadLine() ?? "No State";

            //pass in the street informations
            Address address = new Address(street, city, state);



            //Add employee to the list
            employee.Add(new Employee(id, name, department, phoneNumber, salary, address));
            Console.WriteLine("Please wait...!");
            Thread.Sleep(3000); //3 sec delay to allow program run smoothly
            Console.WriteLine("\n--Employee Added sucessfully--");

            //display a few details of the added employee such as Name and Phone number
            DisplayAddedEmploye();
            Thread.Sleep(5000); // 5 sec delay to allow user see success message 

        }

        //Method/function to display name and phone number of the employee added
        public void DisplayAddedEmploye()
        {
            Console.WriteLine($"Name: {Name}\nPhone_Number: {PhoneNumber}");
        }

        // View Employee Method/ function
        public void ViewEmployee()
        {
            //Check if employee exists
            if (employee.Count == 0)
            {
                Console.WriteLine("\nPlease wait.....");
                Thread.Sleep(3000);
                Console.WriteLine("Employe not found");
                return;
            }
            else
            {
                //Show a list of all employees found
                Console.WriteLine("\nPlease wait.....");
                Thread.Sleep(3000);
                foreach (var item in employee)
                {
                    item.DisplayEmployee(); //this is what displays all the employess
                    Console.WriteLine("--------------------------------------");
                }
            }
        }

        // EDIT THE EMPLOYEE BY ID
        public void EditEmployee()
        {
            Console.Write("Enter Employee's ID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            //Get the first Matching value
            var emp = employee.FirstOrDefault(e => e.Id == id);

            //if no employee do show "Employee not found"
            if (emp == null)
            {
                Console.WriteLine("\nPlease wait.....");
                Thread.Sleep(3000);
                Console.WriteLine("Employee not Found");
            }
            else
            {
                //edit the employe details
                Console.Write("Enter Employee's Name: ");
                emp.Name = Console.ReadLine() ?? emp.Name;

                Console.Write("Enter Employee's Department: ");
                emp.Department = Console.ReadLine() ?? emp.Department;

                Console.Write("Enter Employee's PhoneNumber: ");
                emp.PhoneNumber = Console.ReadLine() ?? emp.PhoneNumber;

                Console.Write("Enter Employee's Salary: ");
                emp.Salary = double.Parse(Console.ReadLine() ?? $"{emp.Salary}");

                //Show a message of success of edited employee
                Console.WriteLine("Please wait...!");
                Thread.Sleep(3000); //3 sec delay to allow program run smoothly
                Console.WriteLine($"\n--Employee ({emp.Name}) Updated sucessfully--");
            }
        }

        // Additional Requirement Save and Upload File--------------------------------------------------------------      
        // Method to save employees to file
        public void SaveEmployeesToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(DataFilePath))
                {
                    foreach (Employee emp in employee)
                    {
                        writer.WriteLine($"{emp.Id},{emp.Name},{emp.Department},{emp.PhoneNumber},{emp.Salary}," +
                        $"{emp.EmployeeAddress.Street},{emp.EmployeeAddress.City}," +
                        $"{emp.EmployeeAddress.State}");
                    }
                }
                Console.WriteLine("Data saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }

        // Add this method to load employees from file
        public void LoadEmployeesFromFile()
        {
            try
            {
                if (File.Exists(DataFilePath))
                {
                    employee.Clear(); // Clear existing data before loading
                    string[] lines = File.ReadAllLines(DataFilePath);
                    
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(',');
                        if (data.Length >= 8)
                        {
                            Address address = new Address(data[5], data[6], data[7]);
                            employee.Add(new Employee(
                                int.Parse(data[0]),
                                data[1],
                                data[2],
                                data[3],
                                double.Parse(data[4]),
                                address
                            ));
                        }
                    }
                    Console.WriteLine("Data loaded successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }

    }
}