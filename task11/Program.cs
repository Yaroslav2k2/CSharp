// напишите программу которая выдает рандомное трех значное число и удаляет вторую цифру

int number = new Random().Next(100,1000);
Console.WriteLine(number);
int number1 = number / 100;
int number3 = number % 10;
Console.WriteLine($"{number1}{number3}");
