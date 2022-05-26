/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9*/

int m = InputNumber ("Введите значение М ");
int n = InputNumber ("Введите значение N ");
int functionAkkerman = Akkerman (m, n);
Console.WriteLine($"Функция Аккермана = {functionAkkerman} ");

int InputNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 ) return Akkerman (m - 1, 1); 
    else return Akkerman (m -1, Akkerman(m, n - 1));
}
