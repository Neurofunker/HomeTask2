/*
	Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
	и на выходе показывает вторую цифру этого числа. 
	Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
	456 -> 5
	782 -> 8
	918 -> 1
	*/
	

	int GetNumber(int number)
	{
	    int firstNumber = number / 10;
	    int secondNumber = firstNumber % 10;
	   
	    int result = secondNumber;
	    return result;
	}
	

	Console.Write("Введите трехзначное число: ");
	int number = Convert.ToInt32(Console.ReadLine());
	 if (number < 0)
	    {
	        number = (number) * -1;
	    }
	if (number < 1000)
	{
	    int finishNumber = GetNumber(number);
	    Console.WriteLine($"Вторая цифра введенного числа => {finishNumber}");
	}
	else
	{
	    Console.WriteLine($"Вы ввели не трехзначное число");
	}
