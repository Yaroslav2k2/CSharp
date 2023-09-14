/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Write("Введите Длнну: ");
int Len =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Ширину: ");
int Shirina= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Предел чисел: ");
int Predel= Convert.ToInt32(Console.ReadLine());
int[,] Random(int Len,int Shirina,int Predel)
{
    int[,] array = new int[Len,Shirina];
    for(int i=0;i<Len;i++)
    {
        for(int j=0;j<Shirina;j++)
        {
            array[i,j]=new Random().Next(-Predel,Predel);
        }
    }
    return array;
}
int[,] UserArray=Random(Len,Shirina,Predel);
void PrintArray(int[,] UserArray)
{
    Console.Write("[ ]\t");
    for(int i=0;i<UserArray.GetLength(1);i++)
    {
        Console.Write($"[{i+1}]\t");
    }
    Console.WriteLine();
    for(int i=0;i<UserArray.GetLength(0);i++)
    {
        Console.Write($"[{i+1}]\t");
        for(int j=0;j<UserArray.GetLength(1);j++)
        {
            Console.Write(UserArray[i,j]+"\t");
        }
        Console.WriteLine();
    }
}
PrintArray(UserArray);
void SummaMin(int[,] UserArray)
{
    int summa=0;
    int temp=0;
    int min=0;
    int minrow=0;
    for(int i=0;i<UserArray.GetLength(1);i++)
    {
        for(int j=0;j<UserArray.GetLength(1);j++)
        {
            summa+=UserArray[i,j];
            temp=i;
        }
        if(summa<min)
        {
            min=summa;
            minrow=temp;
        }
        summa=0;
    }
    Console.WriteLine($"Минимальная сумма равна {min}; строка {minrow+1}");
}
SummaMin(UserArray);