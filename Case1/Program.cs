// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите поочередно 2 числа, после каждого нажмите Enter: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberA > numberB) 
{
    max = numberA;
}
else 
{
     max = numberB;
}
Console.WriteLine(max);