// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от М до N. 

int numberStart = InputNumber ("Введите значение М ");
int numberEnd = InputNumber ("Введите значение N ");

Console.WriteLine("Сумма элементов в промежутке от М до N: " + SumNumber (numberStart, numberEnd));
int InputNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int SumNumber(int numberStart, int numberEnd)
{
    if (numberEnd == numberStart) return numberEnd;
    return numberStart + SumNumber(numberStart + 1, numberEnd);
}

