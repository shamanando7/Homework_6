 // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4


Console.WriteLine($"Введи число М(количество чисел): ");
if (!int.TryParse(Console.ReadLine()!, out int number))
{
    Console.WriteLine("Введите число!");
    return;
}
else if (number < 0)
{
    Console.WriteLine("Введите положительное число!");
    return;
}
int[] ArrayNumbers = new int[number];

void InputNumbers(int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        // ArrayNumbers[i] = int.Parse(Console.ReadLine()!);
        if (!int.TryParse(Console.ReadLine()!, out ArrayNumbers[i]))
        {
            Console.WriteLine("Введите число!");
        }
    }
}

int AboveZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
InputNumbers(number);

Console.WriteLine($"Введено чисел больше 0: {AboveZero(ArrayNumbers)} ");