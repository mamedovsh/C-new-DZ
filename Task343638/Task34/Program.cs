// Задача 34: Задайте массив заполненный случайными положительными 
// трехзначными числами.
// Напишите программу, которая покажет количество четных чисел 
// в массиве.

// Ввод массива.
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;

for (int j = 0; j < numbers.Length; j++)
if (numbers[j] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел,{count} из них четные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,999);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write(" ]");
    Console.WriteLine();
}