// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

void GenerateMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = new Random().Next(1, 10);
        }
}
}

void Number(int[,] matrix, int n, int m)
{
    int number = matrix[0,0];
    if (n < matrix.GetLength(0) && m < matrix.GetLength(1)) 
    {
        number = matrix[n, m];
    }
    else
    {

    }
}

void PrintMatrix(int[,] matrix, int n, int m)
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
    if (n < matrix.GetLength(0) && m < matrix.GetLength(1)) 
    {
        Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {matrix[n-1,m-1]}");
    }
    else
    {
        Console.WriteLine($"значение элемента {n} строки и {m} столбца в матрице не существует");
    }
}


int m = ReadInt("Введите индекс строки матрицы: ");
int n = ReadInt("Введите индекс столбца матрицы: ");
int[,] matrix = new int [7, 5];

GenerateMatrix(matrix);
PrintMatrix(matrix, n, m);
