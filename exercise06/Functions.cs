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

    public static void searchByName(string name)
    {
        for (int i = 0; i <= 3; i++)
        {
            if (name == animals[0, i])
            {
                Console.WriteLine("We found him/her based on name!");
            }
        }
    }

    public static void searchByBreed(string breed)
    {
        for (int i = 0; i <= 3; i++)
        {
            if (breed == animals[1, i])
            {
                Console.WriteLine("We found him/her based on breed!");
            }
        }
    }

    public static void searchByAge(string age)
    {
        for (int i = 0; i <= 3; i++)
        {
            if (age == animals[2, i])
            {
                Console.WriteLine("We found him/her based on age!");
            }
        }
    }

    public static void searchByWeight(string weight)
    {
        for (int i = 0; i <= 3; i++)
        {
            if (weight == animals[3, i])
            {
                Console.WriteLine("We found him/her based on weight!");
            }
        }
    }

}
