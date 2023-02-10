// See https://aka.ms/new-console-template for more information
int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine("ДА");

}
else if (num2 == num1 * num1)
{
    Console.WriteLine("ДА");

}
else Console.WriteLine("НЕТ");

int day = Convert.ToInt16(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine($"Понедельник = {day}");

}
if (day == 2)
{
    Console.WriteLine($"Вторник = {day}");

}
if (day == 3)
{
    Console.WriteLine($"Среда = {day}");

}
if (day == 4)
{
    Console.WriteLine($"Четверг = {day}");

}
if (day == 5)
{
    Console.WriteLine($"Пятница = {day}");

}
if (day == 6)
{
    Console.WriteLine($"Суббота = {day}");

}
if (day == 7)
{
    Console.WriteLine($"Воскресенье ={day}");

}
if (day < 1 || day > 7)
{
    Console.WriteLine($"Ошибка ввода = {day}");
}
