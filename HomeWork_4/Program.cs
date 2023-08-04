// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }



// void DegreeNum(int num, int count)
// {   
//     int pos = 0;
//     int res = 1;
//     while (pos < count)
//     {
//         res = res * num;
//         pos++;
//     }

// Console.WriteLine(res);
// }


// int first = InputNum("Введите первое число: ");
// int second = InputNum("Введите второе число: ");
// DegreeNum(first, second);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int SumNum(int number)
// {
//     int SumNum = 0;
//     while (number != 0)
//     {
//     int del = number % 10;
//     SumNum = del + SumNum;
//     number /= 10;
//     }
//     return SumNum;
// }


// int num = InputNum("Введите число: ");
// int res = SumNum(num);
// Console.WriteLine(res);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputNum(string message)
{
Console.WriteLine(message);
return int.Parse(Console.ReadLine()!);
}

int[] ArrayRand(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(1, 100);
}
return array;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write(".");
        }
}
}

int len = InputNum("Введите длину массива: ");
int[] arr = ArrayRand(len);
PrintArray(arr);
