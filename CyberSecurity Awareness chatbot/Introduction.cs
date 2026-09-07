using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity_Awareness_chatbot
{
    public class Introduction
    {
        public string Name_User = "";
         public List<string> HowAreYouResponses = new List<string>
        {
            "I'm doing great and ready to help you learn about cybersecurity",
            "I'm doing well, Im ready to help you stay safe online.",
            "I'm good, Lets learn some cybersecurity tips together."
        };
        public Random random = new Random();
        public void Start_Introduction() 
        {  
            How_Are_You();
            Ask_User_Name(); 
        }
        public void Ask_User_Name()
        {
            Chatbot chat = new Chatbot();
            Console.WriteLine();
            Console.WriteLine("///////////>>User Names<<///////////");
            Console.Write("Bot:"); 
            chat.slow_Typing("Before we proceed let me get your Name "); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("You: ");
            Console.ResetColor();
            Name_User = Console.ReadLine();
            Console.Write("Bot:"); 
            chat.slow_Typing("Nice to meet you, " + Name_User + "!");
            Console.WriteLine("////////////////////////////////////");
            Console.WriteLine(); 
        }
        public void How_Are_You()
        {
            Chatbot chat = new Chatbot();
           Console.ForegroundColor = ConsoleColor.Cyan;
           Console.Write("Bot: ");
           Console.ResetColor();
           chat.slow_Typing("How are you?");
           Console.ForegroundColor = ConsoleColor.Green;
           Console.Write("You: ");
           Console.ResetColor();

           string answer = Console.ReadLine();

           int number = random.Next(HowAreYouResponses.Count);

           Console.ForegroundColor = ConsoleColor.Cyan;
           Console.Write("Bot: ");
           Console.ResetColor();
           chat.slow_Typing(HowAreYouResponses[number]);

           Console.WriteLine();
        }
       
    }
}
