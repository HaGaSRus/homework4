// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
// Вычисление суммы цифр числа 
int CalcSumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}
int number = Prompt("Введите число >");
int result = CalcSumDigits(number);
System.Console.WriteLine($"Сумма чисел равна {result}");
