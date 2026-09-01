using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CyberSecurity_Awareness_chatbot
{
    public class Chatbot
    {
        public String Name_User = "";
        public void Chatbot_Start()
        {
            Ask_User_Name();
            chatbot_begin();
        }

        public void Ask_User_Name()
        {
            Console.WriteLine("Bot: What is your name?? or enter a nickname to proceed");
            Console.Write("You:");
            Name_User =  Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Bot: Nice to meet you " + Name_User + " !!");
        }

       public void chatbot_begin()
        {
            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine(" CYBERSECURITY AWARENESS BOT"); 
            Console.WriteLine("/////////////////////////////////////");

            Console.WriteLine("Bot: Welcome, " + Name_User + "!");
            Console.WriteLine("Bot: I am here to help you stay safe online.");
            Console.WriteLine("Bot: You can ask me about passwords,phishing,");
            Console.WriteLine("Bot: safe browsing,malware and privacy");
            Console.WriteLine("Type 'exit when you wany to leave'");
            Console.WriteLine(); 
            

          
            Communication responseSystem = new Communication(Name_User);

            while (true) 
            {
                Console.Write("You: ");
                string question = Console.ReadLine();

                if (question.ToLower() == "exit") 
                {
                    Console.WriteLine("Bot: Goodbye " + Name_User);
                    break;
                }
                string response = responseSystem.getResponse(question);

                Console.WriteLine("Bot: " + response);
                Console.WriteLine();

            }

        
    }
}
