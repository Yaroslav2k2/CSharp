//таблица степеней
Console.Clear();
Console.Write("Введите число до которого будет созданна таблица: ");
int Len = int.Parse(Console.ReadLine());
Console.Write("Введите число до которого числа будут возводиться в степень: ");
int Shirina = int.Parse(Console.ReadLine());
int[,] Array(int Len,int Shirina)
{
    int[,] array = new int[Len,Shirina];
    for(int i=1;i<=Len;i++)
    {
        for(int j=1;j<=Shirina;j++)
        {
            array[i-1,j-1]=(int)Math.Pow(i,j);
        }
    }
    return array;
}
int[,] UserArray = Array(Len,Shirina);
void Print(int[,] UserArray)
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
Print(UserArray);