/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int rows = ReadInt("Введите количество строк:");
int columns = ReadInt("Введите количество столбцов:");
int[,] numbers = new int [rows, columns];
double result;
double[] sum = new double [numbers.GetLength(1)];
Fill2DArrayRandomNumbers(numbers);
Write2DArray(numbers);

for (int i = 0; i < numbers.GetLength(1); i++)
{   sum[i]=0;
    for (int j = 0; j<numbers.GetLength(0);j++)
{
    sum[i]+= Convert.ToDouble(numbers[j,i]);
}
Console.WriteLine("Сумма " + (i+1).ToString() + " столбца = " + sum[i].ToString());
}
Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < sum.Length; i++)
{
    result=Math.Round((sum[i]/rows),2);
    Console.Write(result + "; ");
}



void Fill2DArrayRandomNumbers(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    array[i,j] = new Random().Next(1,10);
    }
}
}

void Write2DArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    Console.Write(array[i,j] + " ");
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
