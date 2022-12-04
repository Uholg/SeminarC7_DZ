/*Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

int rows = ReadInt("Введите количество строк:");
int columns = ReadInt("Введите количество столбцов:");
int[,] numbers = new int [rows, columns];
Fill2DArrayRandomNumbers(numbers);
Write2DArray(numbers);
Console.Write("Введите позицию элемента: ");
int pos = Convert.ToInt32(Console.ReadLine());
int posrow=0;
int poscolumn=0;

if (pos<=99)
{
 posrow=pos/10;
 poscolumn=pos%10;
 if (posrow<rows && poscolumn<columns)
{Console.Write("-> " + numbers[posrow,poscolumn] + " ");}
else 
{Console.WriteLine("Такого элемента нет.");}
}
else 
{Console.WriteLine("Такого элемента нет.");}


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