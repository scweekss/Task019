// программа, которая принимает на вход пятизначное число и проверяет, читается ли строка одинакого с двух сторон

//12312 -> нет

//12321 -> да

Console.WriteLine("Введите пятизначенное число");
string number = Console.ReadLine();
//int a1 = int.Parse(Console.ReadLine());
//int b1 = int.Parse(Console.ReadLine());

if (number[0] == number[4] && number[1] == number[3])
{
    //number = number / 10;
    //int a2 = number / 100;
    //int b2 = number % 10;
    //if (a2 == b2)
     Console.WriteLine("Число яляется палиндромом");
}
   
else
{
    Console.WriteLine("Число не яляется палиндромом");
}
