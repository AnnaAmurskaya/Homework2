using static System.Console;

Clear();

WriteLine("Введи цифру, обозначающую день недели");

int a = int.Parse(ReadLine()!);

if (a >= 1 && a <= 7)
{
    if (a == 6 || a == 7) Write("да");
    else Write("нет");
}
else WriteLine("нет такого дня недели");