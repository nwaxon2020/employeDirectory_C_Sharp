//creat name space to avoid collistions of class names
namespace SetEmployee
{
    //create the class called employee
    public class Employee
    {
        //create variables to get and set what ever a user passes, more like a quick function to set and get values.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }

        //This is known a constructor, it is to make sure values are passed and avoid errors.
        public Employee(int id, string name, string department, string phoneNumber, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            PhoneNumber = phoneNumber;
            Salary = salary;
        }

        //function to diplay the employee that is being passed.
        public void DisplayEmployee() {
            Console.WriteLine($"ID: {Id}\nNAME: {Name}\nDEPARTMENT: {Department}\nPHONE_NUMBER: {PhoneNumber}\nSALARY: {Salary}");
        }
    };
 
}