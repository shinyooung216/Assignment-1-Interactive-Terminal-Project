using System;

class Program
{
    static void Main()
    {
        List<string> todoList = new List<string>();
        string command;

        Console.WriteLine("Welcome to Shinyoung! Type 'exit' to end the conversation.");

        while (true)
        {
            Console.Write("\nYou: ");
            command = Console.ReadLine()?.ToLower();  // Read user input and convert it to lowercase

            if (command == "exit")
            {
                Console.WriteLine("Shinyoung: Goodbye! Have a great day.");
                break;
            }

            else if (command == "hello")
            {
                Console.WriteLine("Shinyoung: Hello! How can I assist you today?");
            }

            else if (command == "time")
            {
                Console.WriteLine($"Shinyoung: The current time is {DateTime.Now.ToString("hh:mm tt")}");
            }
            else if (command == "how are you?")
            {
                Console.WriteLine($"I'm very well. How about you?");
            }




            else
            {
                Console.WriteLine("Shinyoung: I didn't understand that command. Please try again.");
            }
        }
    }
}
