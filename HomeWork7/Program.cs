// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,]CreateRandomArray(int rows, int columns)

{
    double[,] array = new double [rows, columns];
    for(int i = 0; i < rows; i++)
         for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().NextDouble();
                         
        return array;
}



void Show2Array(double [,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j], 3) + " ");
        Console.WriteLine();
    }

}

Console.Write("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomArray(m,n);

Show2Array(myArray);
*/

//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,]CreateRandom2Array(int rows, int columns, int minValue, int maxValue )
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
         for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue + 1);
             
        return array;
}

void Show2Array(int [,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }

}

int FindElements(int [,] array, int i, int j)
{
    int res = 0;
if (i > array.GetLength(0)-1 ||  j > array.GetLength(1)-1) 
    
    return res;
    
    else 
    res = array[i,j];
    
    return res;
}


Console.Write("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2Array(m, n, min, max);
Show2Array(myArray);
Console.Write("Input a number of rows:");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns:");
int j = Convert.ToInt32(Console.ReadLine());

 if ((FindElements(myArray, i, j)) == 0) 
    Console.Write(" Элемента с такими позициями не существует");
 
        else 

 Console.Write($"Элемент с позициями [{i}, {j}] = {myArray[i,j]}");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,]CreateRandom2Array(int rows, int columns, int minValue, int maxValue )
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
         for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue + 1);
             
        return array;
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void Show2Array(int [,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }

}
double[] SrAriph( int[,] array)
{   double [] array1 = new double [array.GetLength(1)];
        for(int j = 0; j< array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i=0; i < array.GetLength(0); i++)
            {
            sum+= array[i,j];
            
            }
            array1[j] = sum/array.GetLength(0);
            
    }
    return array1;
}

Console.Write("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2Array(m, n, min, max);
Show2Array(myArray);
Console.WriteLine();
ShowArray(SrAriph(myArray));
