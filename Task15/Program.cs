/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

bool Holyday(int number)
{
    return number == 7 || number == 6;
}

Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 8 && number > 0)
{

    bool result = Holyday(number);

    if (result == true) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else
{
    Console.Write("Вы ввели цифру, не обозначающую день недели!");
}