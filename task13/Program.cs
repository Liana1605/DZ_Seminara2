// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int Num1 = Num;
while (Num > 1000)
Num = Num / 10;
if (Num < 100)
Console.WriteLine("В введенном числе нет третьей цифры");
else
{
    int Num2 = Num % 10;
    Console.WriteLine($"третья цифра заданного числа: {Num2}");
}