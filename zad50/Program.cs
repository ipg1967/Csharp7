// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int test(int rownumber, int colnumber, int[,] array)
{
    return array[rownumber-1, colnumber-1];
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

// --------------------
int[,] massiv = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

// PrintMatrix(massiv);

int rownum = ReadInt("Введите номер строки:  ");
int colnum = ReadInt("Введите номер столбца:  ");

if (massiv.GetLength(0) < rownum || massiv.GetLength(1) < colnum)
{
    System.Console.WriteLine("Такого элемента массива не существует");
}
else
{
    System.Console.WriteLine("Элемент массива равен " + test(rownum, colnum, massiv));
}