using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Demo
{
    class Program
    {
        // DbContext
        // ORM - Object Relation Mapping 
        static void Main(string[] args)
        {
            Around_the_world_for_80_daysEntities context = new Around_the_world_for_80_daysEntities();

            foreach (var item in context.Clients.ToList().Take(10))
            {
                Console.WriteLine(item.CName + " " + item.CSurName);
            }

            var client = new Client
            {
                CName = "aaaaa",
                CSurName = "bbbb"
            };

            //    context.Clients.Add(client);
            //      context.SaveChanges(); // збережи зміни

            Console.WriteLine();
            var addedClient = context.Clients.FirstOrDefault(x => x.CName.StartsWith("aaa"));
            if (addedClient != null)
            {
                Console.WriteLine(addedClient.CName + " " + addedClient.CSurName);
            }

            var firstClient = context.Clients.FirstOrDefault();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in firstClient?.ClientTours)
            {
                Console.WriteLine(item.Tour.TName + "; Price: " + item.Tour.Cost);
            }
        }
    }
}
