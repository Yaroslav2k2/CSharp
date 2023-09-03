/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Write("введите размер массива: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());
int[] Array(int SizeArray)
{
    int[] array = new int[SizeArray];
    for(int i=0;i<array.Length;i++)
    {
        Console.Write($"введите число для массива: ");
        array[i]= Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int[] userArray = Array(SizeArray);
void PrintArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write($"{array[i]}; ");
    }
}
PrintArray(userArray);
int CountOfPozitiveNumber(int[] array)
{
    int count=0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]>0)
        {
            count+=1;
        }
    }
    Console.WriteLine($"кол-во положительных цифр: {count} ");
    return count;
}
CountOfPozitiveNumber(userArray);

