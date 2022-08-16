// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if(num > 99999 || num < 10000)
{
    Console.WriteLine("Это число не пятизначное");
}
else if(num%10 == num/10000 && num/1000%10 == num/10%10)
{
    Console.WriteLine("Это число является палиндромом");
}
else
{
    Console.WriteLine("Это число НЕ является палиндромом");
}

