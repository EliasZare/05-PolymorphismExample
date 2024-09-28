using Company;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hey, Welcome to PolymorphismExample!");
        Console.WriteLine();


        IEmployee _employee;
        _employee = new Developer(1,"Elias","Coding","man");
        Console.WriteLine("My name is "+_employee.GetName());
        Console.WriteLine("my salary : "+_employee.CalculateSalary(20, 2));


        _employee = new Manager();

        Console.ReadKey();
    }
}