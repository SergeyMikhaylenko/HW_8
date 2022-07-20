// Задача 54:  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.


Console.WriteLine("введите количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов массива");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];

FillArrayRandomMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Исходный массив");
PrintArray(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            if (matrix[i, k] < matrix[i, k + 1]) 
            {
                int temp = 0;
                temp = matrix[i, k];
                matrix[i, k] = matrix[i, k + 1];
                matrix[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными элементами");
PrintArray(matrix);

void FillArrayRandomMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        
        Console.WriteLine();
    }
}