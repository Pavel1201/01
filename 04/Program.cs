
Console.WriteLine("Введите число ");

string input = Console.ReadLine();

int number = int.Parse(input);

Console.WriteLine($"Последняя цифра трехзначного числа это: {number%10}");