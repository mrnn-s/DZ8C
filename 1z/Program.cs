// Найти произведение двух матриц
void FillArray(int[,] array)
{
    int num = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = num + 1;
            num++;
        }

}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
int[,] UmnMatr(int[,] array1, int[,] array2)
{
    int[,] res = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int x = 0; x < array2.GetLength(0); x++)
            {
                res[i, j] += (array1[i, x]) * (array2[x, j]);
            }
        }
        
    }
    return res;
}

Console.Write("Введите количество строк 1-й матрицы:");
int Line1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите количество столбцов 1-й матрицы:");
int Column1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите количество строк 2-й матрицы:");
int Line2 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите количество столбцов 2-й матрицы:");
int Column2 = int.Parse(Console.ReadLine()??"0");
int[,] Array1 = new int[Line1, Column1];
int[,] Array2 = new int[Line2, Column2];

FillArray(Array1);
FillArray(Array2);
PrintArray(Array1);
Console.WriteLine();
PrintArray(Array2);
Console.WriteLine();

if (Column1 == Line2)
{
    int[,] Array3 = UmnMatr(Array1, Array2);
    Console.WriteLine("Произведение матриц равно:");
    PrintArray(Array3);
}
else Console.WriteLine("ERROR");