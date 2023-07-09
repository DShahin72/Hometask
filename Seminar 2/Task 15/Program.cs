// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным

System.Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
{
    System.Console.WriteLine("Это выходной день!");
}
else if (num >= 1 && num <= 5)
{
    System.Console.WriteLine("Это рабочий день");
}
else
{
    System.Console.WriteLine("Вы ввели неправильный номер. В неделе 7 дней.");
}