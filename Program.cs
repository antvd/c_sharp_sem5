//34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int[] FillArrayRandomNumbers(int size, int LeftRange, int RightRange) //Функция для заполнения массива
// {
//     int[] arr = new int[size];
//     LeftRange = 100;
//     RightRange = 1000;
//     Random rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(LeftRange,RightRange);
//     }
//     return arr;
// }
// void even(int[] arr, out int kolvo, out int count) // Функци для подсчета четных чисел в массиве
// {
//     kolvo = 0;
//     count = 0;
//     while (count != arr.Length)
//     {
//         if (arr[count] % 2 == 0)
//         {
//             kolvo++;
//         }
//         count++;
//     }
// }
// Console.WriteLine("Введите длину массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int left = 100;
// int right = 1000;
// int[] array = FillArrayRandomNumbers(size,left,right);
// even(array, out int kolvo, out int count);
// Console.WriteLine(kolvo);

//36.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// int[] FillArrayRandomNumbers(int size, int LeftRange, int RightRange)
// {
//      int[] arr = new int[size];
//      Random rand = new Random();
//      for (int i = 0; i < arr.Length; i++)
//      {
//          arr[i] = rand.Next(LeftRange,RightRange+1);
//      }
//      return arr;
// }
// void Sumofnumbersinoddpositions(int[] arr, out int sum, out int count)
// {
//     count = 1;
//     sum = 0;
//     while (count < arr.Length)
//     {
//     sum = sum + arr[count];
//     count = count + 2;
//     }
// }
// Console.WriteLine("Введите левую границу случайного числа массива");
// int left = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите правую границу случайного числа массива");
// int right = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayRandomNumbers(size,left,right);
// Sumofnumbersinoddpositions(array, out int sum, out int count);
// Console.WriteLine(sum);

// 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] FillArrayRandomNumbers(int size, int LeftRange, int RightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(LeftRange,RightRange+1) + rand.NextDouble(),2);

    }
    return arr;
}


double minimum(double[] arr)
{
    double min = arr[0];
    int count = 1;
    while (count != arr.Length)
    {
        if (min > arr[count])
        {
            min = arr[count];
        }
        count++;
    }
    return min;
}

double maximum(double[] arr)
{
    double max = arr[0];
    int count = 1;
    while (count != arr.Length)
    {
        if (max < arr[count])
        {
            max = arr[count];
        }
        count++;
    }
    return max;
}

Console.WriteLine("Введите левую границу случайного числа массива");
int left = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите правую границу случайного числа массива");
int right = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayRandomNumbers(size,left,right);
Console.WriteLine(Math.Round(maximum(array)-minimum(array),2));
//Console.WriteLine(String.Join(",", array));