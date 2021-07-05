namespace CarLibrary
{
    public class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Engine { get; set; }

        public override string ToString()
        {
            return $"{Brand} {Name}, {Year} {Engine}";
        }
    }
}
