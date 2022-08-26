Console.Clear();
// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// int arraySize = 5;
// int[] array = new int[arraySize];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(11);
// }

// Console.WriteLine($"Array: {String.Join(", ", array)}");

// //1. Создать массив, в который мы скопируем текущий

// int[] resultArray = new int[arraySize];

// for (int i = 0; i < arraySize; i++)
// {
//     resultArray[i] = array[arraySize - 1 - i];
// }
// Console.WriteLine($"Array: {String.Join(", ", resultArray)}");

//================================================================================================
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// Console.WriteLine($"Введите длину сторон треугольника");
// int firstSide = Convert.ToInt32(Console.ReadLine());
// int secondSide = Convert.ToInt32(Console.ReadLine());
// int thirdSide = Convert.ToInt32(Console.ReadLine());

// if (firstSide + secondSide > thirdSide && secondSide + thirdSide > firstSide && thirdSide + firstSide > secondSide) Console.WriteLine("Такой треугольник существует");
// else Console.WriteLine("Такого треугольника не может существовать");

//================================================================================================
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine($"Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[number];

// array[0] = 0;
// array[1] = 1;

// for (int i = 2; i < number; i++)
// {
//     array[i] = array[i - 2] + array[i - 1];
// }
// Console.WriteLine($"Array: [{string.Join(", ", array)}]");
//===========================Without array=======================

// int N = 10;
// int firstElement = 0;
// int secondElement = 1;

// Console.Write($"{firstElement} {secondElement}");
// for (int i = 3; i <= N; i++)
// {
//     int nextElement = firstElement + secondElement;
//     Console.Write($" {nextElement}");
//     firstElement = secondElement;
//     secondElement = nextElement;
// }

//================================================================================================

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
// Console.WriteLine($"Введите длину массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(11);
// }

// Console.WriteLine($"Array: {String.Join(", ", array)}");



// int[] resultArray = new int[size];

// for (int i = 0; i < size; i++)
// {
//     resultArray[i] = array[i];
// }
// Console.WriteLine($"New array: {String.Join(", ", resultArray)}");

//================================================================================================
