/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125  */
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 0;i > number;i++ )
{
    int numbers=(number*number*number);
    Console.WriteLine($"{numbers}");
}
Console.WriteLine($"{numbers}");