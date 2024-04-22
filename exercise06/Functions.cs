using System;

// All the parameters are strings, we use them to search via name, breed, age or weight
public class Functions
{
    public static string[,] animals = new string[,]
    {
        { "Cachorro", "Labrador", "5", "25kg" },
        { "Gato", "Siames", "3", "5kg" },
        { "Pássaro", "Canário", "2", "0.05kg" }
    };

    public static void searchByName()
    {
        Console.WriteLine("What's the name of the animal you are looking for?: ");
        string name = Console.ReadLine();
        Console.WriteLine("\n");
        for (int i = 0; i < 3; i++)
        {
            if (name == animals[i, 0])
            {
                Console.WriteLine("We found him/her based on name!\n");
            }
        }
    }

    public static void searchByBreed()
    {
        Console.WriteLine("What's the breed of the animal you are looking for?: ");
        string breed = Console.ReadLine();
        Console.WriteLine("\n");

        for (int i = 0; i < 3; i++)
        {
            if (breed == animals[i, 1])
            {
                Console.WriteLine("We found him/her based on breed!\n");
            }
        }
    }

    public static void searchByAge()
    {
        Console.WriteLine("What's the age of the animal you are looking for?: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        for (int i = 0; i < 3; i++)
        {
            if (age == int.Parse(animals[i, 2]))
            {
                Console.WriteLine("We found him/her based on age!\n");
            }
        }
    }

    public static void searchByWeight()
    {
        Console.WriteLine("What's the weight of the animal you are looking for?: ");
        int weight = int.Parse(Console.ReadLine());
        string weightToString = weight.ToString();
        weightToString += "kg";
        Console.WriteLine("\n");

        for (int i = 0; i < 3; i++)
        {
            if (weightToString == animals[i, 3])
            {
                Console.WriteLine("We found him/her based on weight!\n");
            }
        }
    }

}
