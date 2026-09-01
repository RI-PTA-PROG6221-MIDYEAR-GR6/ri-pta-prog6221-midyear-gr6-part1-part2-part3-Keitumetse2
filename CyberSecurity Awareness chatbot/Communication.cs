using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity_Awareness_chatbot
{
    public class Communication
    {
        public Dictionary<string, string> responses = new Dictionary<string, string>()
        {
             { "how are you", "I'm doing great! I'm ready to help you stay safe online." },
            { "purpose", "My purpose is to help you learn about cybersecurity." },
            { "what can i ask", "You can ask me about passwords, phishing and safe browsing." },
            { "password", "Use a strong password and avoid using the same password on different accounts." },
            { "phishing", "Phishing is when someone tries to trick you into giving away personal information." },
            { "safe browsing", "For safe browsing, avoid suspicious websites and never click unknown links." }
        };
        public string GetAnswer(string question, string name)
        {
            question = question.ToLower();
            foreach (var response in responses)
            {
                if (question.Contains(response.Key))
                {
                    return response.Value + " " + name + ".";
                }
            }
            return "Sorry " + name + ", I don't have an answer for that yet.";
        }
    }
}
