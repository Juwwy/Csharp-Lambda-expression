using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeRatingTask
{
    public enum Rank
    {
        Trainee = 20,
        Owner = 100,


    }


    
    class Program
    {
        private static Random randomNumber = new Random();
        static void Main(string[] args)
        {
            IDictionary<string, int> workerRank = GetRank();

            ICollection<Employee> employees = new List<Employee>(){};
          while(true)
          {     
            int counter = 1;

            Console.Write("Enter command [Add | List | Quit]\n");
            string command = Console.ReadLine();

            if(command == "Add" || command == "add")
            {
                Console.Write("How many input do you want to make: ");
                int num = int.Parse(Console.ReadLine());
                  
                    while(true)
                    {
                    

                    
                            
                    if(counter <= num)
                    {
                        Console.Write("Enter your firstname: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Enter lastname: ");
                        string lastName = Console.ReadLine();

                        Console.Write("Enter postion: ");
                        string position = Console.ReadLine();

                        Employee data = new Employee(firstName, lastName, position);
                        employees.Add(data);

                        ++counter;
                    }else{
                        Console.WriteLine($"Input store limit reached!");
                        break;
                    }
                            

                    }
            }else if(command == "List" || command == "list")
            {
                  if(counter >= 0)
                  {
                    foreach (var employee in employees.OrderBy(e=>e.FirstName).OrderBy(e=>e.LastName).OrderByDescending(e=>workerRank[e.Position]))
                    {
                        Console.WriteLine($"{employee}");
                    }
                  }else{
                      Console.WriteLine("No record found");
                  }
            }else if(command == "Quit" || command == "quit")
            {
                  Console.Write("Thanks and GoodBye!");
                  break;
            }else{
                Console.Write($"{command} is an incorrect input!\n");
            }
          }
        }

        static IDictionary<string, int> GetRank()
        {
            IDictionary<string, int> result = new Dictionary<string, int>();
            result.Add("Senior Developer", 50);
            result.Add("Junior Developer", 30);
            result.Add("Project Manager", 95);
            result.Add("Unit Manager", 95);
            result.Add("Owner", 100);
            result.Add("CEO", 98);
            result.Add("Trainee", 20);
            result.Add("Developer", 40);
            result.Add("Team Leader", 94);
            
            return result;
        } 
    }
}
