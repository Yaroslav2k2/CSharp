/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.Write("Введите натуральное число: ");
int UserNumber= Convert.ToInt32(Console.ReadLine());
void DefNaturalNumbers(int numbers)
{
    Console.Write($"N={numbers} -> '");
    for(int i=numbers+1; i>1; i--)
    {
        Console.Write(numbers);
        numbers-=1;
        Console.Write(";");
    }
    Console.WriteLine("'");
}
DefNaturalNumbers(UserNumber);