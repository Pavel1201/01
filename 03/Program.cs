
Console.WriteLine("Введите номер  ");
string input = Console.ReadLine();

int DayofTheWeek = int.Parse(input);

if (DayofTheWeek == 1)
{
    Console.WriteLine("Это понедельник");

}

if (DayofTheWeek == 2)
{
    Console.WriteLine("Это вторник");

}

if (DayofTheWeek == 3)
{
    Console.WriteLine("Это среда");

}

if (DayofTheWeek == 4)
{
    Console.WriteLine("Это четверг");

}

if (DayofTheWeek == 5)
{
    Console.WriteLine("Это пятница");

}

if (DayofTheWeek == 6)
{
    Console.WriteLine("Это суббота");

}

if (DayofTheWeek == 7)
{
    Console.WriteLine("Это воскресенье");

}

if (DayofTheWeek > 7)
{
    Console.WriteLine("Такого дня недели нет");

}