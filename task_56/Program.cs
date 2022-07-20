// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("введите размер прямоугольного массива");
int RectangularArray = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[RectangularArray, RectangularArray];
FillArrayRandomMatrix(Matrix);
PrintArray(Matrix);
int min = Int32.MaxValue;
int TheRowWithTheSmallestSumOfElements = 0;

for (int i = 0; i < Matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        sum = sum + Matrix[i, j];        
    }
    if (sum < min)
    {
        min = sum;
        TheRowWithTheSmallestSumOfElements++;
    }
}

Console.WriteLine
($"Cтрока с наименьшей суммой елементов : {TheRowWithTheSmallestSumOfElements}, Cумма елементов: {min}");

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