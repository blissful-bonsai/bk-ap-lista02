// Busca de Dados em uma Matriz de Animais.
// Suponha que você tenha uma matriz que representa uma lista de animais, onde cada linha contém as seguintes propriedades de um animal:
// Nome Espécie Idade Peso 
// Escreva um programa em C# que permita ao usuário buscar animais por uma determinada propriedade
// (nome, espécie, idade ou peso) e exibir os animais que correspondem à busca. 
// Matriz de animais [Nome, Espécie, Idade, Peso] string[,] animais = { { "Fido", "Cachorro", "5", "10kg" }, { "Whiskers", "Gato", "5", "5kg" }, { "Buddy", "Cachorro", "3", "8kg" }, { "Fluffy", "Gato", "2", "4kg" }, { "Spot", "Cachorro", "4", "12kg" } };
using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";

        while (userChoice != "exit")
        {
            Console.WriteLine("\nHello! Please specify how we should search for your pet: ");
            Console.WriteLine("name - Name\nbreed - Breed\nage - Age\nweight - Weight\nexit - Exit");
            Console.WriteLine("\n");

            userChoice = Console.ReadLine();

            while (userChoice != "name" && userChoice != "breed" && userChoice != "age" && userChoice != "weight" && userChoice != "exit")
            {
                Console.WriteLine("Specify a valid operation");
                userChoice = Console.ReadLine();
            }

            switch (userChoice)
            {
                case "name":
                    {
                        Functions.searchByName();
                    };
                    break;
                case "breed":
                    {
                        Functions.searchByBreed();
                    };
                    break;
                case "age":
                    {
                        Functions.searchByAge();
                    };
                    break;
                case "weight":
                    {
                        Functions.searchByWeight();
                    };
                    break;
            };

        }
        Console.WriteLine("Exiting program");
    }
}



