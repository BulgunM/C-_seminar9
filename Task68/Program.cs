// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите два неотрицательных числа");
Console.Write("Число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Ackerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if (num2 == 0) return Ackerman(num1 - 1, 1);
    return Ackerman(num1 - 1, Ackerman(num1, num2 - 1));
}

int result = Ackerman(number1, number2);
Console.WriteLine(result);