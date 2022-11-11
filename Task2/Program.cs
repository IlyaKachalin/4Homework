// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

try
{
    int Number(int a)
    {
        int number = 0;
        if (a > 0)

            for (int i = 0; i < a; i++)
            {
                number = number + a % 10;
                a = a / 10;
            }
        else if (a < 0)
            for (int i = a; i < 0; i++)
            {
                number = number + a % 10;
                a = a / 10;
            }
        return number;
    }

    int result = Number(x);
    Console.WriteLine($"Сумма цифр в числе = {result}");
}

catch
{
    Console.WriteLine("Убедитесь, что вы ввели целые числа");
}