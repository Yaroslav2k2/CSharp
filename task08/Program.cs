/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
int number = Convert.ToInt32(Console.ReadLine());
int chetnye=1;
while(chetnye != number + 1)
{
    if(chetnye % 2 == 0)
    {
        Console.WriteLine($"{chetnye}");
    }
    chetnye = chetnye + 1;
}
