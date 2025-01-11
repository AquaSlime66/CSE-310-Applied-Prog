// See https://aka.ms/new-console-template for more information

//Clean up the console
Console.Clear();

//Write to the console, and set the user's input to a var variable
Console.Write("What is your name? ");
var user_name = Console.ReadLine();

//clean up the console again, and then display a welcome message with the user's input
Console.Clear();
Console.WriteLine($"Hello {user_name}, welcome to C#!");
