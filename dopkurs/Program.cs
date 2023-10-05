Console.Clear();
Console.Write("Введите число до которого будет создана таблица квадратов: ");
int dlina = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число до какой степени будет таблица: ");
int shirina = Convert.ToInt32(Console.ReadLine()!); ;
int [,] Random(int dlina,int shirina)
{
    int[,] array = new int[dlina,shirina];
    for(int i=1;i<=dlina;i++)
    {
        for(int j=1;j<=shirina;j++)
        {
            array[i-1,j-1]=(int)Math.Pow(i,j);
        }
    }
    return array;
}
int[,] UserArray = Random(dlina,shirina);
void PrintArray(int[,] UserArray)
{
    Console.Write($"[ ]\t");
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

