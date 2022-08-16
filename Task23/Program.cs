///Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int i = 1;
double result = 1;
Console.Write("Таблица кубов чисел от 1 до N: ");

while (i <= N)
{
    result = Math.Pow(i,3);
    Console.Write(result + " ");
    i++;
}
Console.WriteLine();
