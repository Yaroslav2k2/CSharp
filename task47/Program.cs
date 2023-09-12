/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.Write("Введите Длнну: ");
int Len =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Ширину: ");
int Shirina= Convert.ToInt32(Console.ReadLine());
double[,] RandomArray(int Len,int Shirina)
{
    double[,] array=new double[Len,Shirina];
    for(int i=0;i<Len;i++)
    {
        for(int j=0;j<Shirina;j++)
        {
            array[i,j]= new Random().NextDouble() * 100 ;
        }
    }
    return array;
}
double[,] UserArray = RandomArray(Len,Shirina);
void PrintArray(double[,] UserArray)
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
            Console.Write(Math.Round(UserArray[i,j], 1) + "\t" );
        }
        System.Console.WriteLine();
    }
}
PrintArray(UserArray);