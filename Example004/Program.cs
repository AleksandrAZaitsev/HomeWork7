// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrix(int m, int n)
{
int[,] matrix = new int [m, n];
    for(int i = 0; i < m; i++)
    {
     for(int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(-10, 10);
        }
    }
return matrix;
}

int Number(int[,] matrix)
{
    int number = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        number += matrix[i,i];
    }
    return number;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        System.Console.Write(matrix[i,j] + "\t");;
        }
        System.Console.WriteLine();
        }
System.Console.WriteLine();
}



int m = ReadInt("Введите количетсво строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
int [,] matrix = CreateMatrix(m,n);
PrintMatrix(matrix);


System.Console.WriteLine("Сумма элементов главной диагонали: " + Number(matrix));