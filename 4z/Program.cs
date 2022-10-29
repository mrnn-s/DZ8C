// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

void FillArray(int[,] array)
{
    array[0,(array.GetLength(1)/2)]=1;
    for (int i = 1; i < array.GetLength(0); i++)
        for (int j = 1; j < array.GetLength(1)-1; j++)
        {   
            array[i, j] = array[i-1, j-1]+array[i-1, j+1];
        }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j]==0)
                {
                    Console.Write(" ");
                }
                else 
                {Console.Write($"{array[i,j]}" );}
            }Console.WriteLine();
    }
}

Console.Write("Введите количество строк:");
int n = int.Parse(Console.ReadLine()??"0");
int [,] Array = new int [n+1,((n+1)*2+1)];
FillArray(Array);
PrintArray(Array);