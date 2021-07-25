using EF_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationContext();

            //var position = new Position
            //{
            //    Title = "Manager"
            //};

            var employee = new Employee
            {
                Name = "Ania",
                Age = 20,
                Position = context.Positions.FirstOrDefault(x => x.Title == "Manager")
            };

            context.Employees.Add(employee);
           // context.Positions.Add(position);
            context.SaveChanges();
        }
    }
}
