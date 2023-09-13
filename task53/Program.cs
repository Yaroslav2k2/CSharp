/*53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
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
int[,] Result(int[,] UserArray)
{
    int rows=UserArray.GetLength(0);
    int cols=UserArray.GetLength(1);
    int temp=0;
    for(int i=0;i<rows;i++)
    {
        temp=UserArray[0,i];
        UserArray[0,i]=UserArray[rows-1,i];
        UserArray[rows-1,i]=temp;
    }
    return UserArray;
}
int[,] Array=Result(UserArray);
Console.WriteLine();
PrintArray(Array);