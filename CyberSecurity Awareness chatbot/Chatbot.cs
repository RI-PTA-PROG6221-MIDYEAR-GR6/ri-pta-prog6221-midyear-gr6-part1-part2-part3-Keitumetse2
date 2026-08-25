using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity_Awareness_chatbot
{
    public class Chatbot
    {
        public String Name_User;
        public void Chatbot_Start()
        {
            Ask_User_Name();
        }

        public void Ask_User_Name()
        {
            Console.WriteLine("What is your name?? or write a nickname to proceed");
            Name_User = Console.ReadLine();

            Console.WriteLine("Bot: Nice to meet you " + Name_User + " !!");
        }

        
    }
}
