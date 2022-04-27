using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.DataAccess;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;



namespace ConsoleApp1.Controllers
{
    public class EmployeeController
    {
        private readonly AppDbContext context;
        public EmployeeController()
        {
            context = new AppDbContext();
        }
        public List<Employee> GetAllEmployees()
        {
            return context.employees.ToList();
        }   
        public void GetEmployeeId(int? id)
        {
            Employee empployee = context.employees.Find();
            Console.WriteLine(empployee.Fullname);
            context.SaveChanges();
        }
        public List<Employee> GetEmployees()
        {
            return context.employees.ToList();
            context.SaveChanges();
        }
        public  void Add(int id,string name)
        {
            try
            {
                Employee employee = new Employee();
                context.employees.Add(employee);
                context.SaveChanges();
                Console.WriteLine("Employee added");
            }
            catch
            {
                Console.WriteLine("Some problem");
            }
        }
        public void Delete(int Id)
        {
            try
            {
                Employee employeedb = context.employees.Find(Id);
                if (employeedb == null)
                {
                    Console.WriteLine("Not Found");
                    return;
                }
                context.employees.Remove(employeedb);
                context.SaveChanges();
            }
            catch
            {
                Console.WriteLine("has problem");
            }
        }
        public void FilterByName(string search)
        {
            List<Employee> employees = context.employees.ToList();
            bool IsExist = false;
            foreach (var item in employees)
            {
                if (item.Fullname.ToLower().Contains(search))
                {
                    Console.WriteLine(item.Fullname);
                    IsExist = true;
                }
                else
                {
                    IsExist = false;
                }
            }
            if (!IsExist)
            {
                Console.WriteLine("Error404 Not Found");
            }
        }
        
    }
}
