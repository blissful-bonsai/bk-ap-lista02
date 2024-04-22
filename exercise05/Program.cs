// Crie uma matriz de 4x4 de numeros inteiros aleatorios e encontre o maior valor presente nela. 

Random random = new Random();

// array declaration
int[,] matrix = new int[4, 4];

// Integer that will aid us
int highestNumber = 0;

// Function that generates an array
void arrayGeneration()
{
    // Array number generation
    for (int i = 0; i <= 3; i++)
    {
        for (int j = 0; j <= 3; j++)
        {
            int randomNumber = random.Next(int.MinValue, int.MaxValue);
            matrix[i, j] = randomNumber;
        }
    }
}

arrayGeneration();

// Running a loop to determine the highest number in the generated array
for (int i = 0; i <= 3; i++)
{
    for (int j = 0; j <= 3; j++)
    {
        if (matrix[i, j] > highestNumber)
        {
            highestNumber = matrix[i, j];
            Console.WriteLine("The new highest number is: " + highestNumber);
        }
    }
}

Console.WriteLine(highestNumber);











