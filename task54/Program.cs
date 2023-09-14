/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
Console.WriteLine();
int[,] Result(int[,] UserArray)
{
    for(int i=0;i<UserArray.GetLength(0);i++)
    {
        for(int j=0;j<UserArray.GetLength(1);j++)
        {
            for(int k=0;k<UserArray.GetLength(1)-1;k++)
            {
                if(UserArray[i,k]<UserArray[i,k+1])
                {
                    int temp=UserArray[i,k+1];
                    UserArray[i,k+1]=UserArray[i,k];
                    UserArray[i,k]=temp;
                }
            }
        }
    }
    return UserArray;
}
int[,] UserResult=Result(UserArray);
PrintArray(UserResult);
