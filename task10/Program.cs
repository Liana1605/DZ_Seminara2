// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
if ((99 < Num) && (Num < 1000))
{
    int Num2 = (Num / 10) % 10;
    Console.WriteLine($"Вторая цифра числа - {Num2}");
}
else
    Console.WriteLine("Неподходящее число");
