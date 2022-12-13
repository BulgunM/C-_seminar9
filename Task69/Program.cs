// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

Console.Write("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
number2 = Math.Abs(number2);

int Degree(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * Degree(num1, num2 - 1);
}

int res = Degree(number1, number2);
Console.WriteLine(res);