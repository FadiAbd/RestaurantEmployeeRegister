namespace RestaurantEmployeeRegister
{
    public class Program
    {
        static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee details (Or type 'exit' to finish and get the list):");

            while (true)
            {
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                    break;

                Console.Write("Enter Employee Salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                employees.Add(new Employee { Name = name, Salary = salary });
            }

            PrintEmployeeInfo();
            RunTest(employees);
        }
        //Function to print emp details
        static void PrintEmployeeInfo()
        {
            Console.WriteLine("\nEmployee Details:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }
        // A function that does what an Unit test do
        static void RunTest(List<Employee> employees)
        {
            if (employees.Count > 0)
            {
                Console.WriteLine("\nUnit test passed: At least one employee added.");
            }
            else
            {
                Console.WriteLine("\nUnit test failed: No employees added.");
            }
        }
    }
}
