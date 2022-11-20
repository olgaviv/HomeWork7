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