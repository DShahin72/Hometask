// Напишите програму, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа

int N = new Random().Next(100, 1000);
System.Console.WriteLine(N);
System.Console.WriteLine((N-N/100*100-N%10)/10);
