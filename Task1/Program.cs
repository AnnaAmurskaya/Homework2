using static System.Console;

Write("Введите число:");
int n = int.Parse(ReadLine()!);

if(n>=100 && n <=999)
{
    n /= 10;
    n %= 10;
    WriteLine(n);
}
else WriteLine("Введено не трехзначное число");

