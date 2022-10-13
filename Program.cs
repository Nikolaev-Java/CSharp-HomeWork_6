/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

List<int> userNumber = new List<int>();
Console.WriteLine("Введите числа. Введите ноль чтобы закончить");
int temp;
do
{
	int.TryParse(Console.ReadLine(), out temp);
	userNumber.Add(temp);
} while (temp != 0);
int countPositive = 0;
foreach (var item in userNumber)
{
	if (item > 0)
	{
		countPositive++;
	}
}
Console.WriteLine($"Количество полижительных - {countPositive}");