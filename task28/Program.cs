/* напишите программу которая принимает на вход число n и выдает произведение чисел от 1 до n
*/
Console.WriteLine("Введите число");
int usernumber = Convert.ToInt32(Console.ReadLine());
int Proizvedenie(int number)
{
    int proizvedenie=1;
    for(int i=1;i<=usernumber;i+=1)
{
    proizvedenie*=i;
}
    return proizvedenie;
}
Console.WriteLine($"произведение цифр равно {Proizvedenie(usernumber)}");