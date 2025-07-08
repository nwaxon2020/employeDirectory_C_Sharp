// calling the instance of the great created in the HelloWorld folder
using Greet;
using Function;

//create a new object of types 
HelloWorld helloWorld = new();
Functions functions = new();

//bool to exit program when true
bool exit = true;

//call the method fom the class hello world
helloWorld.SayHello();

//Start program of Employee directory
while (exit != false)
{
    //Options to choose action
    Console.WriteLine("\n---Employee Management System---");
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("2. Edit Employee");
    Console.WriteLine("3. View All Employees");
    Console.WriteLine("4. Exit");

    Console.Write("\nChoose an option: ");

    //use swicth instead of if statement to amke code simple
    switch (Console.ReadLine())
    {
        case "1":
            functions.AddEmployee(); // method to add employee 
            break;
        case "2":
            functions.EditEmployee(); // method to Edit employee 
            break;

        case "3":
            functions.ViewEmployee(); // method to View employee 
            break;

        case "4":      
            exit = false; //exit change to true to exit program
            Console.WriteLine("\nThankyou and GoodBye...!");
            break;

        default:
            Console.WriteLine("Wrong Choice Try Again!!");
            break;
    }
}


