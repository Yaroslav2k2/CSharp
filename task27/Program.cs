/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число");
int NumberUser = Convert.ToInt32(Console.ReadLine());
int DefSummaOfNumbers(int number)
{
    int summa = 0;
    int numbers = 0;
    for(int i=NumberUser;i>0;i/=10)
    {
        numbers = i%10;
        summa+= numbers;
    }   
    return summa;
}
Console.WriteLine($"Сумма цифр числа {NumberUser} равна {DefSummaOfNumbers(NumberUser)}");