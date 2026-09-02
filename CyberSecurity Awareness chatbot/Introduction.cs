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
        public void Start_Introduction() 
        { Say_Hello(); 
          Ask_How_Are_You();
          Ask_User_Name(); 
          Ask_To_Proceed();
        }
        public void Say_Hello()
        { 
            Console.WriteLine("Bot: Hi!");
            Console.Write("You: "); 
            string answer = Console.ReadLine(); 
            Console.WriteLine("Bot: Hello!"); 
            Console.WriteLine(); 
        }
        public void Ask_How_Are_You() 
        {
            Console.WriteLine("Bot: How are you?"); 
            Console.Write("You: "); 
            string answer = Console.ReadLine(); 
            Console.WriteLine("Bot: That's good to hear!"); 
            Console.WriteLine(); 
        }
        public void Ask_User_Name()
        { 
            Console.WriteLine("Bot: What is your name or nickname?"); 
            Console.Write("You: ");
            Name_User = Console.ReadLine();
            Console.WriteLine("Bot: Nice to meet you, " + Name_User + "!");
            Console.WriteLine(); 
        }
        public void Ask_To_Proceed() 
        { 
            Console.WriteLine("Bot: Type 'proceed' to continue."); 
            Console.Write("You: "); 
            string answer = Console.ReadLine(); 
            while (answer.ToLower() != "proceed") {
                Console.WriteLine("Bot: Please type 'proceed' when you are ready."); 
                Console.Write("You: "); 
                answer = Console.ReadLine(); 
            } 
            Console.WriteLine(); 
        }
    }
}
