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
                        
            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine(" CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("/////////////////////////////////////");
            Console.Write("Bot: Welcome to the Cybersecurity Awareness Chatbot," +
                " \nI am here to help you learn how to stay safe online. ");
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine();
            intro.Start_Introduction();
            string Name_User = intro.Name_User;
            Console.WriteLine("///////////....CyberSecurity Questions....///////////");
            Console.WriteLine("Bot: You can ask me questions about passwords,phishing,\n" +
                "malware,safe browsing,privacy");
            Console.WriteLine("/////////////////////////////////////////////////////");
            Console.WriteLine();

            Console.WriteLine("Bot: You can type 'exit' when you want to leave");
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
