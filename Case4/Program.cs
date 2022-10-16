// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите любое число, которое больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (number < 0)
{
    Console.WriteLine("Сказано БОЛЬШЕ нуля.");
    return;
}
while (count <= number)
{
    Console.Write(count);
    if (count == number)
    {
        Console.Write(".");
    }
    else
    {
        Console.Write(", ");
    }
        count = count + 2;
}