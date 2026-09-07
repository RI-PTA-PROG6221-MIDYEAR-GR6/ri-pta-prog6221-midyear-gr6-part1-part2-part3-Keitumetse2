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
        public List<string> positive_Responses = new List<string>
        {
            "Thats great to hear, Im ready to help you learn about cybersecurity.",
            "Im glad you're doing well. Lets learn some cybersecurity tips together.",
            "Thats good to hear. Im ready to help you stay safe online."
        };

        public List<string> negative_Responses = new List<string>
        {
            "Im sorry to hear that. I hope you feel better soon.",
            "Im sorry you are not feeling well. Lets take the cybersecurity session one step at a time.",
            "I hope things get better for you. I will still be here to help you learn about cybersecurity."
        };

        public List<string> normal_Responses = new List<string>
        {
            "Thanks for letting me know. Lets continue with the cybersecurity awareness session.",
            "I understand. Lets continue and learn some cybersecurity tips.",
            "Okay, thank you for sharing that. Lets continue with the session."
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
           Communication communication = new Communication("");
            
           Console.ForegroundColor = ConsoleColor.Cyan;
           Console.Write("Bot: ");
           Console.ResetColor();
           chat.slow_Typing("How are you?");
           Console.ForegroundColor = ConsoleColor.Green;
           Console.Write("You: ");
           Console.ResetColor();

           string answer = Console.ReadLine();
           string answers = get_All_responses(answer,communication);

           Console.ForegroundColor = ConsoleColor.Cyan;
           Console.Write("Bot: ");
           Console.ResetColor();
           chat.slow_Typing(answers);

           Console.WriteLine();
        }
        
         public string get_All_responses(string answer, Communication communication)
        {
            if (string.IsNullOrWhiteSpace(answer))
            {
                return "Thats okay. Lets continue with the cybersecurity progress.";
            }

            answer = answer.ToLower().Trim();

            string[] Words_1 = {"good","great","fine","well","okay","ok"};

            string[] Words_2 = {"bad","sad","tired","sick","not good","not well","stressed"};

            foreach (string word in Words_1)
            {
                if (answer.Contains(word))
                {
                    return communication.getRandom_response(positive_Responses);
                }
            }

            foreach (string words in Words_2)
            {
                if (answer.Contains(words))
                {
                    return communication.getRandom_response(negative_Responses);
                }
            }

            return communication.getRandom_response(normal_Responses);
        }
       
    }
}
