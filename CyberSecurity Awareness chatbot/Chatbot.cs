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
        public void Chatbot_Start()
        {
            Introduction intro = new Introduction();
            intro.Start_Introduction();                        
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine(" CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("/////////////////////////////////////");
            Console.ResetColor();
            Console.Write("Bot: ");
            slow_Typing("Welcome to the Cybersecurity Awareness Chatbot," +
                " \nI am here to help you learn how to stay safe online. ");
            Console.WriteLine("\n/////////////////////////////////////");
            Console.WriteLine();
            string Name_User = intro.Name_User;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("///////////....CyberSecurity Questions....///////////");
            Console.ResetColor();
            Console.WriteLine("Bot: You can ask me questions about:\n" +
                "passwords or What is a password,\n" +
                "phishing or What is phishing,\n" +
                "malware,\n" +
                "safe browsing,\n" +
                "privacy,\n" +
                "AntiVirus"
            );
            Console.WriteLine("\n/////////////////////////////////////////////////////");
            Console.WriteLine();

            Console.WriteLine("Bot: You can type 'exit' when you want to leave");
            Console.WriteLine();
            Communication responseSystem = new Communication(Name_User);

            while (true)
            {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.Write("You: ");
               Console.ResetColor();
               string question = Console.ReadLine();

                if (question.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Bot: ");
                    Console.ResetColor();

                    slow_Typing("Goodbye " + Name_User);
                    break;
                }
                string response = responseSystem.getResponse(question);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Bot: ");
                Console.ResetColor();
                slow_Typing(response);
                Console.WriteLine();

            }
        }
        public void slow_Typing(string text)
            {
               for (int i = 0; i < text.Length; i++)
                   {
                     Console.Write(text[i]);
                     Thread.Sleep(38);
                   }
                     Console.WriteLine();
           }
    }
}
