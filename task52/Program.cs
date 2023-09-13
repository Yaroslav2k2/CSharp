/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
int[,] UserArray=RandomArray(Len,Shirina,Predel);
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
        System.Console.Write($"[{i+1}]\t");
        for(int j=0;j<UserArray.GetLength(1);j++)
        {
            System.Console.Write(UserArray[i,j]+"\t");
        }
        System.Console.WriteLine();
    }
}
PrintArray(UserArray);
double summa=0;
int numberstolb=0;
double Summa(int[,] UserArray,int Len,int Shirina)
{
    double srednee=0;
    double arifm=0;
    for(int i=0;i<Len;i++)
    {
        numberstolb+=1;
        for(int j=0;j<Shirina;j++)
        {
            summa+=UserArray[j,i];
            srednee+=1;
        }
        Console.WriteLine($"Среднее арифметическое cтолбца {numberstolb} = {arifm=summa/srednee} ");
    }
    return arifm;
}
Summa(UserArray,Len,Shirina);