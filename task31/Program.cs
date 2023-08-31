/* задайте массив из 12 эллементов зполненый случайными числами от -9 до 9 
найти сумму отрицательных и положительных элементов массива.
*/

int Size= Convert.ToInt32(Console.ReadLine());
int Start= Convert.ToInt32(Console.ReadLine());
int End= Convert.ToInt32(Console.ReadLine());
int[] Random(int Size, int Start, int End)
{
    int[] array = new int[Size];
    for(int i=0;i<array.Length;i++)
    {
        array[i] = new Random().Next(Start,End);
    }
    return array;
}   
int[] userArray = Random(Size,Start,End);
void printArray(int[] arraytoprint)
{
    Console.Write("[");
    for(int i=0;i<arraytoprint.Length;i++)
    {
        Console.Write($"{arraytoprint[i]} ");
    }
    Console.Write("]");
}
printArray(userArray);
int Summa(int[] summa)
{
    int pozitiveNumbersumma=0;
    int negativeNumbersumma=0;
    for(int i=0;i<summa.Length;i++)
    {
        if(summa[i]>0)
        {
            pozitiveNumbersumma+=summa[i];
        }
        else
        {
            negativeNumbersumma+=summa[i];
        }
    }
    Console.WriteLine($"сумма положительных {pozitiveNumbersumma}, сумма отрицательных {negativeNumbersumma}.");
    return pozitiveNumbersumma;
    return negativeNumbersumma;
}
Summa(userArray);