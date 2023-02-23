// Задача №19 Напишите программу,которая на вход принимает пятизначное 
// число и проверяет является ли оно палиндромом.


Console.WriteLine(" Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if(len == 5)
{
	if(number[0] ==number[4]&&number[1]==number[3])
	{
		Console.WriteLine("(number) - Палиндром");
	}
	else
	{
		Console.WriteLine("(number) -не палиндром");
	}
}
else
{
	Console.WriteLine("вы ввели не пятизначное число");
}