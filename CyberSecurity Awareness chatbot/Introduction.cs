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
        {  
          Ask_User_Name(); 
        }
       
        public void Ask_User_Name()
        {
            Console.WriteLine();
            Console.WriteLine("///////////>>User Names<<///////////");
            Console.WriteLine("Bot: What is your name or nickname?"); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("You: ");
            Console.ResetColor();
            Name_User = Console.ReadLine();
            Console.WriteLine("Bot: Nice to meet you, " + Name_User + "!");
            Console.WriteLine("////////////////////////////////////");
            Console.WriteLine(); 
        }
       
    }
}
