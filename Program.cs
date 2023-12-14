//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
//int[] arr = new int[10];
//     for (int i = 0; i < 10; i++)
//   {
//Console.Write("{0}>", i + 1);
//    arr[i] = System.Convert.ToInt32(Console.ReadLine());
//}

//       int count = 0;
//      for (int i = 0; i < 10; i++)
//     {
//        if (arr[i] >= 20 && arr[i] <= 90)
//       {
//          count++;
//        }
//    }
//   Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [20, 90]: " + count);


//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

//int[] arr = new int[10];
//int count = 0;
//  for (int i = 0; i < 10; i++)
//{
//  Console.Write("{0}>", i + 1);
//arr[i] = System.Convert.ToInt32(Console.ReadLine());
//if ((arr[i] % 2) == 0)
//            count++;
//}
//Console.Write(count);

//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.


//double[] array = new double[7];
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = new Random().NextDouble();
//    Console.Write(array[i].ToString("F2") + " ");
//}
//double max = array[0];
//double min = array[0];
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] > max)
//    {
//        max = array[i];
//    }
//    if (array[i] < min)
//    {
//        min = array[i];
//    }
//}
//Console.WriteLine();
//string smax = max.ToString("F2");
//string smin = min.ToString("F2");
//Console.WriteLine("максимум " + smax);
//Console.WriteLine("минимум " + smin);

//double result = max - min;
//string res = result.ToString("F2");
//Console.WriteLine("Разница между мексимальными и минимальным элементом равна " + 

//Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int[]array = new int[number+1];
array[0] = number/10;

for( int i=number; i<array.Length; i--)
{
    if(number>1 && number<100000)
    {
    array[i] = number%10;
    number = number/10;
    }
}
for( int i=0; i<array.Length; i++)
{
    Console.Write(array[i] +"  ");
}