// Crie um programa que preencha uma matriz 3x3 com valores inteiros informados pelo usuário e depois exiba essa matriz na tela.

int readNumber()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] matrix = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

for (int i = 0; i <= 2; i++)
{
    for (int j = 0; j <= 2; j++)
    {
        matrix[i, j] = readNumber();
    }
}

for (int i = 0; i <= 2; i++)
{
    for (int j = 0; j <= 2; j++)
    {
        Console.WriteLine(matrix[i, j]);
    }
}














