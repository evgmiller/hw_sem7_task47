// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] GetArray1( int m, int n, int minValue, int maxValue)
{
    double[,] result=new double[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]= new Random().Next(minValue,maxValue);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}  ");
            
        }
        Console.WriteLine();
    }
}

double[,] array1= GetArray1(4,4,0,10);
PrintArray(array1);
Console.WriteLine();
