Console.Clear();
// ДОП.ЗАДАЧА:
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
//Пришлось изучить коллекции
List<int> resultList = new List<int>();
while (N > 0)
{
    result = N % 2;
    N = N / 2;
    resultList.Add(result);
}
resultList.Reverse();

foreach (int i in resultList)
{
    Console.Write($"{i}");
}

