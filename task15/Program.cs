// Напишите програму, которая принимает на вход цифру, 
// обозначающую день недели и проверяет, является ли это день выходным

Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
if (0 < Num && Num < 8)
{
    if (Num == 6 || Num == 7)
    Console.WriteLine("Да");
    else
    Console.WriteLine("Нет");
}
