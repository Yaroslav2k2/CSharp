using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадаю число от 1 до 100, а вы должны угадать его.");

        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int attempts = 0;

        while (true)
        {
            Console.Write("Введите вашу догадку: ");
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int guess) || guess < 1 || guess > 100)
            {
                Console.WriteLine("Пожалуйста, введите корректное число от 1 до 100.");
                continue;
            }

            attempts++;

            if (guess < secretNumber)
            {
                Console.WriteLine("Число больше. Попробуйте снова.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Число меньше. Попробуйте снова.");
            }
            else
            {
                Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток.");
                break;
            }
        }

        Console.WriteLine("Спасибо за игру!");
    }
}
