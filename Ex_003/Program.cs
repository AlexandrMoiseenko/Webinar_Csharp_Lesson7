// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое в каждом столбце.


int Promt(string message)                        
{
    Console.Write(message);                 
    return Convert.ToInt32(Console.ReadLine());    
}

int[,] CreateArray(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          matrix[i, j] = new Random().Next(1, 30); 
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
    Console.WriteLine();
    }
}

void ArithmaticAverage(int[,] matrix, int m)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)           
        {                                                       
            sum += matrix[i,j];
        }
    Console.Write("{0:F1}", sum/m);
    Console.Write("\t");
    }
}


int m = Promt("Введите количество строк в массиве: ");
int n = Promt("Введите количество столбцов в массиве: ");
int[,] matrix = new int[m,n];
PrintArray(CreateArray(matrix, m, n));
Console.WriteLine("Среднее арифметическое каждого столбца равно:");
ArithmaticAverage(matrix, m);