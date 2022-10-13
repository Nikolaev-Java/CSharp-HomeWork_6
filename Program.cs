/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

int k1;
int b1;
int k2;
int b2;
Console.WriteLine("Введите k1");
while (!int.TryParse(Console.ReadLine(), out k1))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
Console.WriteLine("Введите k2");
while (!int.TryParse(Console.ReadLine(), out k2))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
Console.WriteLine("Введите b1");
while (!int.TryParse(Console.ReadLine(), out b1))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
Console.WriteLine("Введите b2");
while (!int.TryParse(Console.ReadLine(), out b2))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
double x = (double)(b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"({x}; {y})");