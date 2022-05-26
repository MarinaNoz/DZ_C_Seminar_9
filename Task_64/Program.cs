// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.WriteLine("Задайте число N ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumber(n);

void PrintNumber(int n)
{
    if(n < 1) 
    return;
    Console.Write(n + ", ");
    PrintNumber(n - 1);
}
