// В двумерном массиве целых чисел  Удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
void FillArray(int[,] array)
{
    Random num = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = num.Next(-90, 90);
        }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        System.Console.WriteLine();
    }
}

(int LineOfMin, int ColumnOfMin, int MinElement) Poisk(int[,] massiv)
{
    int min = 1;
    var res = (elin1: 0, elin2: 0, el: 0);
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (massiv[i, j] < min)
            {
                min = massiv[i, j];
                res.elin1 = i;
                res.elin2 = j;
                res.el = massiv[i, j];
            }
        }
    }
    return res;
}

int [,] SortMassiv(int[,] array, int Line, int Column)
{ int[,] res = new int [array.GetLength(0)-1,array.GetLength(1)-1];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i,j] = array[i,j];
            if (i>=Line && j>=Column)
            {
                res[i,j]=array[i+1,j+1];
            }
            else if (i>=Line)
            {
                res[i,j]=array[i+1,j];
            }
            else if (j>=Column)
            {
                res[i,j]=array[i,j+1];
            }
        }
    }
    return res;
}

Console.Write("Введите количество строк массива:");
int Line = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива:");
int Column = int.Parse(Console.ReadLine() ?? "0");
int[,] Array = new int[Line, Column];
FillArray(Array);
PrintArray(Array);
var result = Poisk(Array);
Console.WriteLine($"Минимальный элемент: {result.MinElement} на строке: {(result.LineOfMin)+1} в столбце: {(result.ColumnOfMin)+1}.");
int[,] ResMass = SortMassiv(Array,result.LineOfMin,result.ColumnOfMin);
PrintArray(ResMass);