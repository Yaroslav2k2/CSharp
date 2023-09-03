/* создать массив вещественных чисел и найти разницу между максимальным и минимальным */
Console.WriteLine("Введите числа: ");
int Size = Convert.ToInt32(Console.ReadLine());
int Min = Convert.ToInt32(Console.ReadLine());
int Max = Convert.ToInt32(Console.ReadLine());
double[] Random(int Size,int Min,int Max)
{
    double[] array = new double[Size];
    for(int i=0;i<array.Length;i++)
    {
        array[i] =new Random().NextDouble() * 100;
    }
    return array;
}
double[] userArray = Random(Size,Min,Max);
void printArray(double[] array)
{
    Console.Write("[");
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(Math.Round(array[i], 1) );
        Console.Write("; ");
    }
    Console.Write("]");
}
printArray(userArray);
double Raznost(double[] array)
{
    double min=array[0];
    double max=array[0];
    double raznost=0;
    for(int i=0;i<userArray.Length;i++)
    {
        if(max<array[i])
        {
            min=array[i];
        }
        if(min>userArray[i])
        {
            max=array[i];
        }
    }
    raznost = min-max;
    Console.WriteLine($"разность {min} и {max} равна {raznost}");
    return raznost;
}
Raznost(userArray);
