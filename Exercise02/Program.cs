// - Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.

int[] numbers = [2321, 42, -48, 354, -4317];
int shortNumber = numbers[0];
int bigNumber = numbers[0];

    for (int i = 0; i < numbers.Length; i++)
    {
        // Bigger number determination
        if (numbers[i] > bigNumber)
        {
            bigNumber = numbers[i];
        }
        // Shorter/smaller number determination
        if (numbers[i] < shortNumber)
        {
            shortNumber = numbers[i];
        }
    }

Console.WriteLine(bigNumber);
Console.WriteLine(shortNumber);
























