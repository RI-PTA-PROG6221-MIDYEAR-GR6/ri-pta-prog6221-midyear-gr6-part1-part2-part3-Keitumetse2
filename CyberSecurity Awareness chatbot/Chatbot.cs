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
        public void chatbot_begin()
        {
            Introduction intro = new Introduction();

            intro.Start_Introduction();

            string Name_User = intro.Name_User;
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
}
