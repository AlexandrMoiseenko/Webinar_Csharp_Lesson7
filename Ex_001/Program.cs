// Задайте двумерный массив размером m * n, заполненный
// случайными вещественными числами.

int Promt(string message)                        
{
    Console.Write(message);                 
    return Convert.ToInt32(Console.ReadLine());    
}

double[,] CreateArray(double[,] matrix, int m, int n)
{
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          matrix[i, j] = rand.Next(1, 10) + rand.NextDouble();; 
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // Console.Write("{0,6:F2}", array[i]);
            Console.Write("{0,6:F1}",matrix[i, j]);
        }
    Console.WriteLine();
    }
}


int m = Promt("Введите количество строк в массиве: ");
int n = Promt("Введите количество столбцов в массиве: ");
double[,] matrix = new double[m,n];
PrintArray(CreateArray(matrix, m, n));