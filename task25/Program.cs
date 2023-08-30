/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine("Введите число и степегь в которую надо возвести число");
int NumberOne = Convert.ToInt32(Console.ReadLine());
int NumberTwo = Convert.ToInt32(Console.ReadLine());
int Degree(int NumberOne, int NumberTwo)
{
    int degree = (int)Math.Pow(NumberOne,NumberTwo);
    return degree;
}
Console.WriteLine($"стпень числа {NumberOne} равна {Degree(NumberOne,NumberTwo)}");