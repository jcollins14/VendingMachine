namespace RandomVend
{
    internal class Beverage
    {
        public string Name;
        public int Quantity;

        public Beverage(string title)
        {
            Name = title;
            Quantity = 1;
        }

        public Beverage(string title, int num)
        {
            Name = title;
            Quantity = num;
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            string output = Name + ", " + Quantity;
            return output;
        }
    }
}

