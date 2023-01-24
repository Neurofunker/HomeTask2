/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int GetNumber(int number)
{
    int thirstNumber = number % 10;
    int result = thirstNumber;
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}
while (number > 1000)
{
    number = number / 10;
}
if (number > 100)
{
    int finishNumber = GetNumber(number);
    Console.WriteLine($"Третья цифра введенного числа => {finishNumber}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}