// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintAverageCol(int[,] matrixForPrint)
{
    int rownum = matrixForPrint.GetLength(0);

    for (int i = 0; i < matrixForPrint.GetLength(1); i++)
    {
        float sum = 0;
        for (int j = 0; j < rownum; j++)
        {
            sum = sum + matrixForPrint[j, i];
        }
        System.Console.Write(Math.Round(sum / rownum, 1) + ";");
    }
}

// --------------------
int[,] massiv = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
System.Console.WriteLine("Среденее арифметическое каждого столбца:");
PrintAverageCol(massiv);
System.Console.WriteLine();