/*задайте одномерный масссив со случайными числами ,найти сумму 
элементов на нечетных позициях
*/
Console.WriteLine("Введите числа: ");
int Size = Convert.ToInt32(Console.ReadLine());
int Min = Convert.ToInt32(Console.ReadLine());
int Max = Convert.ToInt32(Console.ReadLine());
int[] Random(int Size,int Min,int Max)
{
    int[] array = new int[Size];
    for(int i=0;i<array.Length;i++)
    {
        array[i]= new Random().Next(Min,Max);
    }
    return array;
}
int[] userArray = Random(Size,Min,Max);
void printArray(int[] array)
{
    Console.Write("[");
    for(int i=0;i<array.Length;i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write("]");
}
printArray(userArray);
int SummaOfNegativeIndex(int[] array)
{
    int summa=0;
    for(int i=0;i<array.Length;i++)
    {
        if(i%2!=0)
        {
            summa+=userArray[i];
        }
        else
        {
            summa+=0;
        }
    }
    Console.WriteLine($"сумма чисел под нечетным индексом равна {summa}");
    return summa;
}
SummaOfNegativeIndex(userArray);