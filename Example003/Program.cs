// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


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

void NewMatrix (int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 1; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] *= matrix[i,j]; 
        }
    }
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
NewMatrix(matrix);
PrintMatrix(matrix);