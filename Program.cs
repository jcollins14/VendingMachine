using System;

namespace RandomVend

{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine blessRNG = new VendingMachine();
            Console.WriteLine("Stream Vending Machine Starting Up...");
            blessRNG.Unpack();
            Console.WriteLine("All Drinks Loaded. Now Selecting");
            blessRNG.Vend(blessRNG.PickDrink());
            blessRNG.Repack();
            Environment.Exit(1);
        }
    }
}
