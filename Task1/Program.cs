// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

try
{

    Console.Write("Введите число (А). А = ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число (B). B = ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (b > 0)
    {
        int Power(int a, int b)
        {
            int power = 1;
            for (int i = 0; i < b; i++)
            {
                power = power * a;
            }

            return power;
        }

        int result = Power(a, b);
        Console.WriteLine($"{a} в степени {b} = {result}");
    }
    else Console.WriteLine("Число B должно быть натуральным");
}

catch
{
    Console.WriteLine("Нужно было ввести целые числа");
}