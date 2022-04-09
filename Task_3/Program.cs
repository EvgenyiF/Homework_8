//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Write("Задайте количество строк в массиве 1: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве 1: ");
int n = Convert.ToInt16(Console.ReadLine());


Console.Write("Задайте количество строк в массиве 2: ");
int k = Convert.ToInt16(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве 2: ");
int l = Convert.ToInt16(Console.ReadLine());

int[,] array = new int[m, n];
int[,] array1 = new int[k,l];
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
int[,] MultiplyingArrays(int[,] array,int[,] array1)  //произведение 2-х матриц
{
    if (m<k) k = m;
    if (n<l) l=n;
    int[,] array2 = new int[k,l];
       for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < l; j++)
        {
            array2[i,j] = array[i,j]*array1[i,j];
        }
    }
    return array2;
}



FillArray(array);
FillArray(array1);
Console.WriteLine();
Console.WriteLine("Заполненый первый массив: ");
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Заполненый второй массив: ");
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Результат перемножения массивов: ");
Console.WriteLine();int[,] array2 = MultiplyingArrays(array, array1);
PrintArray(array2);