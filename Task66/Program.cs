// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два натуральных числа");
Console.Write("Число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num1, int num2)
{
    if (num1 > num2) return 0;
    return num1 += SumNumbers(num1 + 1, num2);
}

if (number1 < number2)
{
    int result = SumNumbers(number1, number2);
    Console.WriteLine(result);
}
Console.WriteLine("Число M должно быть меньше, чем N");