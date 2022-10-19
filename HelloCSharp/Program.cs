// See https://aka.ms/new-console-template for more information
Console.WriteLine("What's your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine} Hello {name}, Im your computer! it is {currentDate:t} on {currentDate:d}.");
Console.Write($"{Environment.NewLine}Press any key to quit. ");
Console.ReadKey(true);