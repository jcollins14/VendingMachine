# VendingMachine

This is a program created to automate a Twitch Channel Points Incentive to drink a beverage from a random selection. This is intended to be run in the background.

Most of the logic is contained within VendingMachine.cs but I will explain each method within.

## VendingMachine.cs Methods

##### Unpack()
Loads from a text file named "inventory.txt" _(a template has been provided)_. Each line of the file will be created into a **Beverage** object, with the number after the comma indicating the quantity. Each **Beverage** object is loaded into the VendingMachines internal List<Beverage>.

##### PickDrink()
Takes the internal List<Beverage> and converts the list into a number of strings, with each drink name being duplicated X times, where X is the quanitty of the specific beverage. A random number generator is called and a beverage is picked.

This method returns a string of the **Beverage**'s name.

##### Vend (string)
Requires a string name of a **Beverage**. If the provided string matches the name of a beverage in the VendingMachine's internal **Beverage** list, the quantity of the selected beverage is decremented, and if it then equals zero, is removed from the VendingMachine's internal list. 

A StreamWriter outputs the selected drink name to "output.txt", to be read by OBS. A note is added if the beverage is the last one of its type.

##### Repack()
This method saves the internal list of the VendingMachine back to "inventory.txt" for reference on future usage.
