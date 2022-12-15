// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого или же указание,
// что такого элемента нет.


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

int SearchNumber(int[,] matrix, int positionElement1, int positionElement2)
{
    int number = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == positionElement1 && j == positionElement2)
            {
                number = matrix[i,j];
                return matrix[i,j];
            }
        }
    }
    return number;
}

void Answer(int[,] matrix, int m, int n, int positionElement1, int positionElement2)
{
    if(m >positionElement1 && n > positionElement2)
    {
        Console.WriteLine($"искомое число равно {SearchNumber(matrix, positionElement1, positionElement2)}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }
}

int m = Promt("Введите количество строк в массиве: ");
int n = Promt("Введите количество столбцов в массиве: ");
int positionElement1 = Promt("Введите искомый номер строки: ");
int positionElement2 = Promt("Введите искомый номер столбца: ");
int[,] matrix = new int[m,n];
PrintArray(CreateArray(matrix, m, n));
Answer(matrix, m, n, positionElement1, positionElement2);