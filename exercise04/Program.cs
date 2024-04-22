// Crie um programa que declare doi svetores de mesmo tamanho e calcule a soma dos lemeentos correspondentes de ambos os vetores, armazenando o resultado em um terceiro vetor. Em seguida, exiba o vetor resultante

int[,] matrixOne = new int[2, 2]
{
    {10, 20},
    {30, 40}
};

int[,] matrixTwo = new int[2, 2]
{
    {1, 2},
    {3, 4}
};

int[,] matrixThree = new int[2, 2]
{
    {0, 0},
    {0, 0}
};

for (int i = 0; i <= 1; i++)
{
    for (int j = 0; j <= 1; j++)
    {
        matrixThree[i, j] = matrixOne[i, j] + matrixTwo[i, j];
    }
}

for (int i = 0; i <= 1; i++)
{
    for (int j = 0; j <= 1; j++)
    {
        Console.WriteLine(matrixThree[i, j]);
    }
}













