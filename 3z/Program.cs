// Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента
void FillArray(int[,,] array)
{
    int num1 = 10;
    int num2 = -100;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
         for (int k = 0; k < array.GetLength(2); k++)
            {   if (num1 >= 99 && num2<-9)
                {  
                   array[i, j, k] = num2++;
                }
                if (num1>=10 && num1<100)
                {
                    array[i, j, k] = num1++;
                }
                
            }
        

}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
                
            }
            Console.WriteLine();
        }
        
    }
}

int[,,] Array = new int[5,6,6];
FillArray(Array);
PrintArray(Array);