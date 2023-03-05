// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(-10, 10);
        }
    }
    return matrix;
}

double[] ArithmeticMean(int[,] matrix, int n)
{
    double[] ArMe = new double[n];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            avarage = (avarage + matrix[i, j]);
        }
        avarage = avarage / n;
        ArMe[j] = Math.Round(avarage,2);
      //  System.Console.WriteLine(Math.Round(ArMe[j],2) + "\t");
    }
    return ArMe;
    
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int m = ReadInt("Введите количетсво строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
double[] ArMe = ArithmeticMean(myMatrix, n);
PrintMatrix(myMatrix);
System.Console.Write("[" + string.Join(", ",(ArMe)) + "]");