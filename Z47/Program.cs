/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.*/

int rows = ReadInt("Введите количество строк:");
int columns = ReadInt("Введите количество столбцов:");
double[,] numbers = new double [rows, columns];
Fill2DArrayRandomNumbers(numbers);
Write2DArray(numbers);

void Fill2DArrayRandomNumbers(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
    {
    array[i,j] = Math.Round(Convert.ToDouble(new Random().Next(-10,10) + new Random().NextDouble()),2);
}
}}

void Write2DArray(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    Console.Write(array[i,j] + "  ");
    }
    Console.WriteLine();
}
    Console.WriteLine();
}


int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
