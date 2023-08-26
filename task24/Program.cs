/*напишите программу, которая принимает на вход число (А)
и выдает сумму чисел от 1 до А
*/

Console.WriteLine("Введите число:");
int summa=0;
int numberA = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<numberA; i++)
{
    summa=summa+i;
}
Console.WriteLine($"Сумма равна {summa}");