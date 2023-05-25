// string[,] table = new string[2, 3];
// table[0, 0] = "слово";
// table[0, 1] = "пустота";
// table[0, 2] = "верх";
// table[1, 0] = "дворняга";
// table[1, 1] = "пилот";
// table[1, 2] = "слово";
// PrintArray(table, 2, 3);

int[,] matrix = new int[4, 6];
RandomFillArray(matrix);
PrintArray(matrix);

int[,] RandomFillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[,] array)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
