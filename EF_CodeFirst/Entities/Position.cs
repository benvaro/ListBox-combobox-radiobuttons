using System.Collections.Generic;

namespace EF_CodeFirst.Entities
{
    public class Position
    {
        public Position()
        {
            Employees = new List<Employee>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
