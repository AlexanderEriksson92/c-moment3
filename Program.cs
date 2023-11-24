


while (true)
{
Console.WriteLine("Alexanders gästbok");
Console.WriteLine("1. Skriv i gästboken");
Console.WriteLine("2. Ta bort inlägg");
Console.WriteLine("3. Visa alla inlägg");
Console.WriteLine("x. Avsluta");


string input = Console.ReadLine();

switch (input)
{

case "1":
Console.WriteLine("Skriv ditt namn");
string name = Console.ReadLine();
Console.WriteLine("Skriv ditt meddelande");
string message = Console.ReadLine();
GuestBook.AddEntry(name, message);
break;

case "2":
Console.WriteLine("Vilket inlägg vill du ta bort?");

var entrie = Convert.ToInt32(Console.ReadLine());
GuestBook.RemoveEntry(entrie);
break;

case "3":
GuestBook.PrintAllEntries();
break;

case "x":   
return;

default:
Console.WriteLine("Felaktig inmatning");
break;

}

}