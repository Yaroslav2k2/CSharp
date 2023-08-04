/*
# Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
*/

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number2 * number2;
if(result == number1)
{
    Console.WriteLine("первое число квадрат второго");
}
else
{
    Console.WriteLine("первое число не является квадратом второго");
}