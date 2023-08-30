/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.WriteLine("Введите число:");
Console.WriteLine("1.Размер массива;  2. от какого числа происходит генерация чисел; 3. до какого числа происходит генерация чисел");
int Size = Convert.ToInt32(Console.ReadLine());
int Start = Convert.ToInt32(Console.ReadLine());
int End = Convert.ToInt32(Console.ReadLine());
int[] Random(int Size, int Start, int End)
{
    int[] randomArray = new int[Size];
    for(int i=0; i<randomArray.Length;i++)
    {
        randomArray[i]= new Random().Next(Start,End);
    }
    return randomArray;
}
int[] UserArray= Random(Size,Start,End);
void Prints(int[] arraytoprint)
{
    Console.Write("[");
    for(int i =0; i<arraytoprint.Length;i++)
    {
        Console.Write($"{arraytoprint[i]},");
    }
    Console.Write("]");
}
Prints(UserArray);
