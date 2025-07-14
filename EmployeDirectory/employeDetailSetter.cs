//creat name space to avoid collistions of class names
namespace SetEmployee
{
    // Add this struct for employee address information
    public struct Address
    {
        public string Street;
        public string City;
        public string State;

        public Address(string street, string city, string state)
        {
            Street = street;
            City = city;
            State = state;
        }

        public void DisplayAddress()
        {
            Console.WriteLine($"Address: {Street}, {City}, {State}");
        }
    }
    //create the class called employee
    public class Employee
    {
        //create variables to get and set what ever a user passes, more like a quick function to set and get values.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }
        public Address EmployeeAddress { get; set; } //Get the employee address

        //This is known a constructor, it is to make sure values are passed and avoid errors.
        public Employee(int id, string name, string department, string phoneNumber, double salary, Address address)
        {
            Id = id;
            Name = name;
            Department = department;
            PhoneNumber = phoneNumber;
            Salary = salary;
            EmployeeAddress = address;  // Add this line
        }

        //function to diplay the employee that is being passed.
        public void DisplayEmployee()
        {
            Console.WriteLine($"ID: {Id}\nNAME: {Name}\nDEPARTMENT: {Department}\nPHONE_NUMBER: {PhoneNumber}\nSALARY: {Salary}");
            EmployeeAddress.DisplayAddress();
        }
    };
 
}