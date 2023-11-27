using System;
// While loop som körs tills användaren väljer att avsluta programmet
while (true)
    {
        
        Console.WriteLine("Alexanders gästbok");
        Console.WriteLine("1. Skriv i gästboken");
        Console.WriteLine("2. Ta bort inlägg");
        Console.WriteLine("3. Visa alla inlägg");
        Console.WriteLine("x. Avsluta");

        string input = Console.ReadLine();
        // Switch som kör olika metoder beroende på input
        switch (input)
        {
            case "1":
            Console.Clear();
                Console.WriteLine("Skriv ditt namn");
                string name = Console.ReadLine();
                Console.WriteLine("Skriv ditt meddelande");
                string message = Console.ReadLine();
                GuestBook.AddPost(name, message);
                break;

            case "2":
            Console.Clear();
                Console.WriteLine("Vilket inlägg vill du ta bort?");
                var entry = Convert.ToInt32(Console.ReadLine());
                GuestBook.RemovePost(entry);
                break;

            case "3":
            Console.Clear();
            Console.WriteLine("Alla inlägg");
                  GuestBook.ShowAllPosts();
                break;

            case "x":
                return;

            default:
            Console.Clear();
                Console.WriteLine("Felaktig inmatning");
                break;
        }
    }

public class GuestBook 
{
    // Aryar som lagrar alla inlägg och räknar antalet inlägg upp till max 10
   private static GuestBookPost[] posts = new GuestBookPost[10];
    private static int count = 0;

    // Metod som lägger till post och en if sats som kollar så att det inte finns fler än 10 inlägg. Finns det färre än 10 läggs inlägget in och arrayen räknas upp med 1
    public static void AddPost(string name, string message)
    {
        if (count == 10)
        {
            Console.WriteLine("Gästboken är full");
            return;
        }
      
        else
        {
           posts[count] = new GuestBookPost(name, message);
              count++;
        }
    }

    public static void RemovePost(int index)
    {
      index--;
        if (index < 0 || index >= count)
        {
            Console.WriteLine("Inlägget finns inte");
            return;
        }
        else
        {
            for (int i = index; i < count; i++)
            {
            posts[i] = posts[i + 1];
            }
            count--;
        }
    }

    public static void ShowAllPosts()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}. {posts[i].Name} {posts[i].Message}");
        }
    }

}
public class GuestBookPost
{
    public string Name { get; set; }
    public string Message { get; set; }
    public GuestBookPost(string name, string message)
    {
        Name = name;
        Message = message;
    }
}
    
