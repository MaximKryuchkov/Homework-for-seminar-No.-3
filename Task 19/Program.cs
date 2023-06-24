// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите пятизначное число: ");
string str = Console.ReadLine()!;

if (str.Length != 5)
{
    System.Console.WriteLine("Ошибка, введите пятизначное число !");
}
else if (str[0] == str[4] | str[1] == str[3])
{
    System.Console.WriteLine("Данное число является полиндромом");
}
else
{
    System.Console.WriteLine("Данное число НЕ является полиндромом");
}