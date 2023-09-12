/*48. Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.*/
int[,] RandomArray(int Len,int Shirina,int Predel)
{
    int[,] array=new int[Len,Shirina];
    for(int i=0;i<Len;i++)
    {
        for(int j=0;j<Shirina;j++)
        {
            array[i,j] = i+j;
        }
    }
    return array;
}
int[,] UserArray = RandomArray(5,5,10);
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
            System.Console.Write(UserArray[i,j]+ "\t");
        }
        System.Console.WriteLine();
    }
}
PrintArray(UserArray);