/* The following code will consist of 3 classes 2 used to store methods and 
   and background code that will be used to gather user input these 2 classes 
   are Ingredients and Instructions. The 3rd class is called Program which consistes of all
   instructions and interactions used to engage with the user this is also known the interface.
*/



public class Ingredients //Creating Ingredients class to store methods 
{
    //Creating mutator and accessor methods to store and retrieve user input 
    public string Name { get; set; }
    public string Unit { get; set; }
    public double Quantity { get; set; }



    //Creating a method for calling mutator and accessor methods from a different class
    public Ingredients(string name, string unit, double quantity)
    {
        Name = name;
        Unit = unit;
        Quantity = quantity;


    }

    //Create method for up-scaling quantity value
    public double CalcScale1(double value1)
    {
        return value1 = Quantity * 0.5;

    }

    public double CalcScale2(double value2)
    {
        return value2 = Quantity * 2;

    }

    public double CalcScale3(double value3)
    {
        return value3 = Quantity * 3;

    }


}

public class Instructions //Creating Insructions class to store methods 
{
    //Creating mutator and accessor methods to store and retrieve user input 
    public int Step { get; set; }
    public string Description { get; set; }


    //Creating a method for calling mutator and accessor methods from a different class
    public Instructions(int step, string description)
    {
        Step = step;
        Description = description;

    }



}
class Program //Creating main class for program aka the interface

{
    static void Main(string[] args)
    {
        Console.WriteLine("How much ingredients do you want to enter?");
        int count = Convert.ToInt32(Console.ReadLine());

        // Creating an array of Ingredients objects
        Ingredients[] ingredients = new Ingredients[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Enter details for ingredient {i + 1}:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Unit of measurement: ");
            string unit = Console.ReadLine();

            Console.Write("Amount: ");
            double quantity = Convert.ToDouble(Console.ReadLine());





            // Creating a new Ingredients object with user input and adding it to the array
            ingredients[i] = new Ingredients(name, unit, quantity);








        }
        ////////////////////////////////////////////////////////////////////////////////////////////////

        Console.WriteLine("How many steps do you want to enter?");
        int sum = Convert.ToInt32(Console.ReadLine());

        // Creating an array of Instructions objects
        Instructions[] instructions = new Instructions[sum];

        for (int j = 0; j < sum; j++)
        {
            Console.WriteLine($"Enter details for ingredient {j + 1}:");

            Console.Write("Step: ");
            int step = Convert.ToInt32(Console.ReadLine());

            Console.Write("Description: ");
            string description = Console.ReadLine();

            // Creating a new Ingredients object with user input and adding it to the array
            instructions[j] = new Instructions(step, description);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        Console.WriteLine("Would you like to scale the ingreindents? \nEnter:\n0 - No, continue" +
                          "\n1 - Half Quantity \n2 - Double Quantity \n3 - Triple Quantity ");

        int ans = Convert.ToInt32(Console.ReadLine());

        if (ans == 0)
        {
            // Displaying the details of each ingredient
            Console.WriteLine("\nDetails of Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"\nName: {ingredient.Name}\nUnit of measurement: {ingredient.Unit}\nAmount: {ingredient.Quantity}");
            }

            Console.WriteLine("\nInstructions:");
            foreach (var instruction in instructions)
            {
                Console.WriteLine($"\nStep: {instruction.Step},\nDescription: {instruction.Description}");
            }


        }

        else if (ans == 1)
        {
            // Displaying the details of each ingredient
            Console.WriteLine("\nDetails of Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"\nName: {ingredient.Name}\nUnit of measurement: {ingredient.Unit}\nAmount: ");
            }

            Console.WriteLine("\nInstructions:");
            foreach (var instruction in instructions)
            {
                Console.WriteLine($"\nStep: {instruction.Step},\nDescription: {instruction.Description}");
            }

        }

        else if (ans == 2)
        {
            // Displaying the details of each ingredient
            Console.WriteLine("\nDetails of Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"\nName: {ingredient.Name}\nUnit of measurement: {ingredient.Unit}\nAmount: {ingredient.CalcScale2} ");
            }

            Console.WriteLine("\nInstructions:");
            foreach (var instruction in instructions)
            {
                Console.WriteLine($"\nStep: {instruction.Step},\nDescription: {instruction.Description}");
            }

        }

        else if (ans == 3)
        {
            // Displaying the details of each ingredient
            Console.WriteLine("\nDetails of Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"\nName: {ingredient.Name}\nUnit of measurement: {ingredient.Unit}\nAmount: {ingredient.CalcScale3}");
            }

            Console.WriteLine("\nInstructions:");
            foreach (var instruction in instructions)
            {
                Console.WriteLine($"\nStep: {instruction.Step},\nDescription: {instruction.Description}");
            }

        }

        Console.WriteLine("\nHow would like to proceed further? " +
                          "\nEnter: \n1 - Reset Quantity \n2 - To add new recipie \n 3 - To end the program");
        int ans2 = Convert.ToInt32(Console.ReadLine());

        if (ans2 == 1)
        {
            // Displaying the details of each ingredient
            Console.WriteLine("\nDetails of Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"\nName: {ingredient.Name}\nUnit of measurement: {ingredient.Unit}\nAmount: {ingredient.Quantity}");
            }

            Console.WriteLine("\nInstructions:");
            foreach (var instruction in instructions)
            {
                Console.WriteLine($"\nStep: {instruction.Step},\nDescription: {instruction.Description}");
            }
        }

        else if (ans2 == 2)
        {
            Console.WriteLine("Bye");
        }



    }

}