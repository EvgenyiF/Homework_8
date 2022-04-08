// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Задайте количество строк в массиве: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int n = Convert.ToInt16(Console.ReadLine());

int[,] array = new int[m, n];
void FillArray(int[,] array) // функция заполнения массива рандомно
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}
void PrintArray(int[,] array) //функция печати массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine("  ]");
    }
}
void SummaRow(int[,] array)  //сортируем массив от максимума к минимуму по строкам
{
    int Summ = 0;
    int MinSumm = 0;
    int a = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Summ += array[i, j];
            //Console.WriteLine(Summ);

        }
        Console.WriteLine($"Сумма элементов {i} строки равна {Summ}");
        if (MinSumm == 0) MinSumm = Summ;
        if (Summ < MinSumm)
        {
            MinSumm = Summ;
            a = i;
            //Console.WriteLine(MinSumm);
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с минимальной суммой - {a}");
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
SummaRow(array);