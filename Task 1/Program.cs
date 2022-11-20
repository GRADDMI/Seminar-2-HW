// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = ReadInt("Введите трехзначное число: ");
int result = number % 100;
if(number>99 && number<1000)
{
    result=result/10;
    Console.WriteLine("Вторая цифра введенного числа " + result);
}
else 
{
    Console.WriteLine("Ошибка! Введите трехзначное число!");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}