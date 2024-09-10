namespace EmployeeRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            bool quit = false;
            while(true)
            {
                Console.WriteLine("Hello and welcome to the Employee registry!\n What would you like to do? \n 1. Review Employee Record \n 2. Add an employee \n 3. Exit Application\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        if (employees.Count > 0)
                            foreach (Employee e in employees)
                                Console.WriteLine(e.Print());
                        else
                            Console.WriteLine("\nSorry, there are no registered employees");
                        break;
                    case "2":
                        Console.WriteLine("\nPlease enter employee name");

                        string name = Console.ReadLine();
                        int salary;
                        while (true)
                        {
                            Console.WriteLine("\nPlease enter salary");

                            if (!int.TryParse(Console.ReadLine(), out salary))
                                Console.WriteLine("Input is not a valid number, try again");
                            else
                                break;
                        }

                        Employee tempEmp = new Employee(name, salary);

                        Console.WriteLine($"\nEnter '1' to confirm new employee {tempEmp.Print()}, enter any other key to cancel");

                        if(Console.ReadLine() == "1")
                            employees.Add(tempEmp);
                        break;
                        case "3":
                        Console.WriteLine("\nConfirm quit by pressing '1'");
                        if (Console.ReadLine() == "1")
                            quit = true;
                        break;
                    default:
                        Console.WriteLine("\nUnrecognized input, try again.");
                        break;
                }
                Console.WriteLine("\nPress enter to continue");
                Console.ReadLine();
                if (quit)
                    break;
                else Console.Clear();
            }
        }
    }

    internal class Employee(string name, int salary)
    {
        public string Print()
        {
            return $"Name: {name}, Salary: {salary}";
        }

    }
}
