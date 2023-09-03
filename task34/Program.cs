/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Write("Введите числа: ");
int Size = Convert.ToInt32(Console.ReadLine());
int Min = Convert.ToInt32(Console.ReadLine());
int Max = Convert.ToInt32(Console.ReadLine());
int[] Random(int Size,int Min, int Max)
{
    int[] array= new int[Size];
    for(int i=0;i<array.Length;i++)
    {
        array[i]= new Random().Next(Min,Max);
    }
    return array;
}
int[] userArray = Random(Size,Min,Max);
void printArray(int[] arraytoprint)
{
    Console.Write("[");
    for(int i=0;i<arraytoprint.Length;i++)
    {
        Console.Write($"{arraytoprint[i]}; ");
    }
    Console.Write("]");
}
printArray(userArray);
int CountPozitiveNumbers(int[] array)
{
    int count = 0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]%2==0)
        {
            count+=1;
        }
        else
        {
            count+=0;
        }
    }
    Console.WriteLine($"кол-во четных чисел равно {count}");
    return count;
}
CountPozitiveNumbers(userArray);



