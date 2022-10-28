//                     Задача 50.

//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


// Заполнение массива рандомными числами от 1 до 9

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//  Функция вывода массива в терминал

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
}

Console.Write("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

//Возвращение элемента массива

void ReturnValueElem(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0);)
    {
        for (int j = 0; j < numbers.GetLength(1);)
        {
            if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1))
                Console.WriteLine($"Значение элемента на этой позиции: {numbers[rows, colums]}");
            else Console.WriteLine($"{rows}, {colums} - такого элемента в массиве нет");
            break;
        }
        break;
    }
}

int[,] numbers = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(numbers);
ReturnValueElem(numbers);