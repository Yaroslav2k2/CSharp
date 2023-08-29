/* yапишите программу которая на входе берет число и выдает кол-во цифр в числе*/
Console.WriteLine("Введите число");
int usernumber = Convert.ToInt32(Console.ReadLine());
int CountOFNumbers(int number)
{
    int count=0;
    for(int i=usernumber;i>0;i/=10)
{
    count+=1;
}
    return count;
}
Console.WriteLine($"количество цифр в числе {usernumber} равно {CountOFNumbers(usernumber)}");