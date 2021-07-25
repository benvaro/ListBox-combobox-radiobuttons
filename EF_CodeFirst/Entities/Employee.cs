namespace EF_CodeFirst.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        // Навігаційні властивості
        public virtual Position Position { get; set; }
    }
}
