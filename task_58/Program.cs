// Задача 58: Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.

Console.WriteLine("Введите число, которое будет соответствовать количеству строк и столбцов в матрице.");
int MatrixSize = Convert.ToInt32(Console.ReadLine());

void FillArrayRandomMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,3); //Для увеличения размера чисел в матрицах поменять число 5 на большее
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

Console.WriteLine("размерность матриц: ");
int[,] FirstMatrix = new int[MatrixSize, MatrixSize];
int[,] SecondMatrix = new int[MatrixSize, MatrixSize];
FillArrayRandomMatrix(FirstMatrix);
FillArrayRandomMatrix(SecondMatrix);
int[,] ProductMatrix = new int[MatrixSize, MatrixSize]; 

for (int i = 0; i < MatrixSize; i++)
{
    for (int j = 0; j < MatrixSize; j++)
    {
        for (int k = 0; k < MatrixSize; k++)
        {
            ProductMatrix[i, j] = ProductMatrix[i, j] + (FirstMatrix[i, k] * SecondMatrix[k, j]); 
        }
    }
}
Console.WriteLine("Первая матрица");
PrintArray(FirstMatrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintArray(SecondMatrix);
Console.WriteLine();
Console.WriteLine("Произведение первой и второй матрицы");
PrintArray(ProductMatrix);