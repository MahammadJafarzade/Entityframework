using ConsoleApp1.Controllers;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeController emp = new EmployeeController();
            Console.WriteLine("Enter Fullname:");
            Console.ReadLine();
            emp.Add(5,"Mehemmed");
            
            foreach (var item in emp.GetAllEmployees())
            {
                Console.WriteLine(item.Fullname);
            }
        }
    }
}
