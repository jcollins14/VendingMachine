﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RandomVend
{
    class VendingMachine
    {
        public List<Beverage> Drinks;
        public VendingMachine()
        {
            Drinks = new List<Beverage>();  
        }

        public VendingMachine(List<Beverage> drinks)
        {
            Drinks = drinks;
        }

        public string PickDrink()
        {
            List<string> selection = new List<string>();
            Random rng = new Random();

            foreach(Beverage drink in Drinks)
            {
                for (int i = 0; i < drink.Quantity; i++)
                {
                    selection.Add(drink.Name);
                }
            }

            int pick = rng.Next(selection.Count);
            return selection[pick];
        }

        public void Vend(string pick)
        {
            StreamWriter output = new StreamWriter("output.txt");

            //Drink Removal from List
            foreach(Beverage drink in Drinks)
            {
                if (drink.Name == pick)
                {
                    drink.Quantity--;
                    if (drink.Quantity == 0)
                    {
                        Drinks.Remove(drink);
                        pick += "(Last One!)";
                    }
                }
            }
            output.WriteLine(pick);
            output.Close();
        }

        public void Unpack()
        {
            StreamReader inv = new StreamReader("inventory.txt");
            string line;
            while ((line = inv.ReadLine()) != null)
            {
                string[] parameters = new string[2];
                parameters = line.Split(',');
                Beverage create = new Beverage(parameters[0], int.Parse(parameters[1]));
                Drinks.Add(create);
            }
            inv.Close();
        }

        public void Repack()
        {
            StreamWriter save = new StreamWriter("inventory.txt");
            foreach (Beverage drink in Drinks)
            {
                save.WriteLine(drink.ToString());
            }
            save.Close();
        }
    }
}
