﻿// string[,] table = new string[2, 3];
// table[0, 0] = "слово";
// table[0, 1] = "пустота";
// table[0, 2] = "верх";
// table[1, 0] = "дворняга";
// table[1, 1] = "пилот";
// table[1, 2] = "слово";
// PrintArray(table, 2, 3);

// int[,] matrix = new int[4, 6];
// RandomFillArray(matrix);
// PrintArray(matrix);

// int[,] RandomFillArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 10);
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < cols; j++) Console.Write($"{array[i, j]} ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] matrix = new int[,]
// {
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
//     {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
//     {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
//     {0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0},
//     {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//     {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//     {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
//     {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
//     {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
//     {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0},
//     {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
//     {0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
// };

// PrintPicture(matrix);
// FillPicture(12, 12);
// PrintPicture(matrix);

// void PrintPicture(int[,] array)
// {
//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);
//     Console.WriteLine();
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < cols; j++) 
//         if (array[i, j] == 1) Console.Write("+"); else Console.Write(" ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FillPicture(int row, int col)
// {
//     if(matrix[row, col] == 0)
//     {
//         matrix[row, col] = 1;
//         FillPicture(row - 1, col); // вверх
//         FillPicture(row, col - 1); // влево
//         FillPicture(row + 1, col); // вниз
//         FillPicture(row, col + 1); // вправо
//     }
// }

// for(int i = 1; i < 40; i++) Console.WriteLine($"{i}! = {Factorial(i)}");

// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n*Factorial(n - 1);
// }  

// f(1) = 1; f(2) = 1; f(n) = f(n - 1) + f(n - 2);

for(int i = 1; i < 50; i++) Console.WriteLine($"f({i}) = {Function(i)}");

int Function(int n)
{
    if(n < 3) return 1; 
    else return Function(n - 1) + Function (n - 2);
}