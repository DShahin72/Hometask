// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 100 == 0)
{
    System.Console.WriteLine($"В числе {num} нет третьей цифры");
}

int N = num;
int fig3 = num % 10;
int fig2 = (num / 10) % 10;
int fig1 = (num / 100) % 10;
//System.Console.WriteLine($"{fig1}, {fig2}, {fig3}");

while (num / 1000 != 0)
{
    num = num / 10;
    fig1 = fig2;
    fig2 = fig3;
    fig3 = num % 10;
}

System.Console.WriteLine($"Третья цифра числа {N} равна {fig3}");