// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "John";
        person.LastName = "Doe";
        person.PrintFullName();

        Employee employee = new Employee();
        employee.EmployeeId = "E123";
        employee.Department = "IT";
        employee.BaseSalary = 50000;
        double salary = employee.CalculateSalary();
        Console.WriteLine($"Employee Salary: {salary}");
    }
}
