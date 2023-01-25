// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();

Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine());
int number2=0;
int number3=number;

while (number > 0)
{
    number2 = (number%10)+number2*10;
    number = number/10;
}

if (number3 == number2)
{
    Console.WriteLine("Число является полиндромом");
}
else Console.WriteLine("Число НЕ является полиндромом");

