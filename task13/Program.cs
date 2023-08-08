/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int number = Convert.ToInt32(Console.ReadLine());
if(number / 100 > 0)
{
    int numbertwo= number %100;
    Console.WriteLine($"{numbertwo % 10}");
}
else
{
    Console.WriteLine("Третьего числа нет");
}