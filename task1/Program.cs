// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int A = Prompt("Введите число A => ");
int B = Prompt("Введите число B => ");

int result = (int)Math.Pow(A,B);
System.Console.WriteLine($" Число {result}");
