/*напишите программу, которая принимает на вход число (А)
и выдает сумму чисел от 1 до А
*/

Console.WriteLine("Введите число:");
//int summa=0;
int numberA = Convert.ToInt32(Console.ReadLine());
int DefSumma(int number)
{
    int summa=0;
    for(int i=1; i<=numberA; i++)
{
    summa+=i;
}
    return summa;
}
Console.WriteLine($"Сумма равна {DefSumma(numberA)}");