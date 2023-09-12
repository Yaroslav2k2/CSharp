/*Задача 50. Напишите программу, которая на вход
 принимает позиции элемента в двумерном массиве, и 
 возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Write("Введите Длнну: ");
int Len =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Ширину: ");
int Shirina= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Предел чисел: ");
int Predel= Convert.ToInt32(Console.ReadLine());
int[,] RandomArray(int Len,int Shirina,int Predel)
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
int[,] UserArray= RandomArray(Len,Shirina,Predel);
void PrintArray(int[,] UserArray)
{
    System.Console.Write($"[ ]\t");
    for(int i=0;i<UserArray.GetLength(1);i++)
    {
        System.Console.Write($"[{i+1}]\t");
    }
    System.Console.WriteLine();
    for(int i=0;i<UserArray.GetLength(0);i++)
    {
        System.Console.Write($"[{i}]\t");
        for(int j=0;j<UserArray.GetLength(1);j++)
        {
            System.Console.Write(UserArray[i,j]+"\t");
        }
        System.Console.WriteLine();
    }
}
PrintArray(UserArray);
Console.Write("Введите ваше число: ");
int UserNumber=Convert.ToInt32(Console.ReadLine());
int count=0;
for(int i=0;i<UserArray.GetLength(0);i++)
{
    for(int j=0;j<UserArray.GetLength(1);j++)
    {
        if(UserArray[i,j]==UserNumber)
        {
            count+=1;
        }
    }
}
if(count>0)
{
    Console.WriteLine("Ваше число есть в массиве");
}
else
{
    Console.WriteLine("Такого числа в вашем массиве нет");
}
    