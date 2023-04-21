// Задача №1
// Напишите программу которая принимает на вход число А и выдает сумму чисел от 1 до А
// 7 ----> 28
// 4 ----> 10

// Console.WriteLine("Введите любое число А");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int count = 0;

// int GetSumNum()
// {
//     while (A > count)
//     {
//         count = count + 1;
//         // count++;
//         sum = sum + count;
//         // sum+ = count;
//     }
//     return sum;
// }

// Console.WriteLine(GetSumNum());


// Задача №2
// Написать программу которая принимает на вход число и выдает на выход кол-во цифр в числе
// 456 --->3
// 34 -----> 2
// 89594 ---> 5

// Console.WriteLine("Ввести любое число");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;


// int GetCountNum()
// {
//     while (number != 0)
//     {
//         number = number / 10;
//         count++;
//     }

//     return count;
// }

// Console.WriteLine(GetCountNum());

// Вариант решения №2
// Console.WriteLine("Ввести любое число");
// int number = Convert.ToInt32(Console.ReadLine());

// int NumCount()
// {
//     return Convert.ToString(number).Length;
// }

// Console.WriteLine(NumCount());

// Задача №3
// Напишите программу которая на вход принимает число N и выдает произведение чисел от 1 до N
// 4--->24
// 5--->120

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int Prod = 1;

// int ProdNum()
// {
//     while (N > count)
//     {
//         count++;
//         Prod = Prod * count;
//     }
//     return Prod;
// }
// Console.WriteLine(ProdNum());

// Задание №4
// Написать программу которая выводит массив из 8 цифр заполненный нулями и еденицами в случайном порядке

// int[] numArr = new int[8];

// for (int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(0, 2);
//     Console.WriteLine(numArr[i]);
// }

// Вариант №2 с выведением массива в одну строчку! Добавляем команду String.Join и выносим Console.WriteLine за цикл

// int[] numArr = new int[8];

// for (int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(0, 2);
// }
// Console.WriteLine(String.Join("", numArr));


// Home work

// Task #1
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Решение №1

// Console.WriteLine("Введите число А");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());

// A = Convert.ToInt32(Math.Pow(A, B));
// Console.WriteLine(A);


// Решение №2 (цикл)

// Console.WriteLine("Введите число А");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// int y = A;

// int NumPow()
// {
//     while (i < B)
//     {
//         i++;
//         y = y * A;
//     }

//     return y;
// }

// Console.WriteLine(NumPow());



// Задача №2

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int sum = 0;

// int NumSum()
// {
//     while (number > 0)
//     {
//         i = number % 10;
//         number = number / 10;
//         sum = i + sum;
//     }
//     return sum;
// }

// Console.WriteLine(NumSum());

