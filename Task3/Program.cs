// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);