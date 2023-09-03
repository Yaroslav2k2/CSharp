/* напишите на вход программу котоая принмает массив и меняет положительные значения на отрицательные*/
Console.Write("введите числа: ");
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
        Console.Write($"{arraytoprint[i]}, ");
    }
    Console.Write("]; ");
}
printArray(userArray);
Console.Write("Обратный массив:");
void reversprintArray(int[] reversarraytoprint)
{
    Console.Write("[");
    for(int i=0;i<reversarraytoprint.Length;i++)
    {
        reversarraytoprint[i]*=-1;
        Console.Write($"{reversarraytoprint[i]} ");
    }
    Console.Write("]");
}
reversprintArray(userArray);
