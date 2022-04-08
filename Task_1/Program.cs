// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива(в пределах всего массива).
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
void FillArray1 (int[,] array)
{
    int c = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"Введите {c} число: ");
            int a = Convert.ToInt16(Console.ReadLine());
            array[i, j] = a;
            c++;
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
void SortArray(int[,] array)  //сортируем массив от максимума к минимуму по строкам
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(1); a++)
            {
                if (array[i, a] < array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, a];
                    array[i, a] = temp;
                }
            }
        }
    }
}
M: Console.WriteLine("Выберите способ заполнения массива:");
Console.WriteLine("Для ручного ввода наберите 1");
Console.WriteLine("Для рандомного ввода наберите 2");
int sposob = Convert.ToInt16(Console.ReadLine());
if (sposob == 1)
{
    FillArray1(array);
}
else if (sposob == 2)
{
    FillArray(array);
}
else
{
    Console.WriteLine("Вы ввели что-то неправильно!!!!");
    goto M;
}
PrintArray(array);
Console.WriteLine("Отсортированный массив: ");
SortArray(array);
PrintArray(array);