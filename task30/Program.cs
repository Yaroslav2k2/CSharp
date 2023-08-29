/*напишите программу которая выводит массив из 8 эллементов заполненный нулями и еденицами в случайном порядке*/
int[] GetRandomArray()
{
    int[] array = new int[8];
    for(int i=0;i < array.Length;i++)
    {
        array[i] = new Random().Next(0,2);

    }
    
    return array;
}
int[] userArray= GetRandomArray();
void printarray(int[] arraytoprint)
{
    System.Console.Write("[");
    for(int i=0;i < arraytoprint.Length;i++)
    {
        System.Console.Write($"{arraytoprint[i]}");
    }
    Console.WriteLine("]");
}
printarray(userArray);