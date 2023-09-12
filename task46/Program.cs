//двумерный массив м на н
int[,] NewRandomArray(int m, int n, int deviation)
{
    int[,] result= new int[m,n];
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            result[i,j]=new Random().Next(-deviation,deviation);
        }
    }
    return result;
}
void PrintArray(int[,] arraytoprint)
{
    System.Console.Write($"[ ]\t");
    for(int i=0;i<arraytoprint.GetLength(1);i++)
    {
        Console.Write($"[{i+1}]\t");
    }
    System.Console.WriteLine();
    for(int i=0;i<arraytoprint.GetLength(0);i++)
    {
        Console.Write($"[{i+1}]\t");
        for(int j=0;j<arraytoprint.GetLength(1);j++)
        {
            System.Console.Write(arraytoprint[i,j]+ "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] userArray=NewRandomArray(5, 5, 10);
PrintArray(userArray);
