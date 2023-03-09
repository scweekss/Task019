// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine("Введите пятизначенное число");
int number = Convert.ToInt32(Console.ReadLine());
int a1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
if(a1 == b1)
{
    number = number / 10;
    int a2 = number / 100;
    int b2 = number % 10;
    if(a2 == b2)
     Console.WriteLine("Число яляется палиндромом");
}
   
else
{
    Console.WriteLine("Число не яляется палиндромом");
}
