// Уменьшаем сложность (О-Нотацию) алгоритма:
int Promt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
int[,] SymmetricMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = i; j < matrix.GetLength(1); j++){  // "j = i" - уменьшаем кол. прогонов, а соот и сложность.
            matrix[i, j] = (i + 1) * (j + 1);
            matrix[j, i] = (i + 1) * (j + 1);
        }
    }
    return matrix;
}
void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]:f1}\t");
        }
        Console.WriteLine();
    }
}

int n = Promt("Введите число N (длина таблицы): ");
int[,] matrix = new int[n, n];
int[,] resultMatrix = SymmetricMatrix(matrix);
PrintMatrix(resultMatrix);