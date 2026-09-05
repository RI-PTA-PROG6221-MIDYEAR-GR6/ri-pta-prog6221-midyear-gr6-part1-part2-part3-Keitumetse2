using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity_Awareness_chatbot
{
    public class Communication
    {
        public string Name;
        public Dictionary<string, List<string>> responses;
        public Random random = new Random();

        public Communication(string name)
        {
            Name = name;

            responses = new Dictionary<string, List<string>>();
                   
            responses.Add("purpose", new List<string> 
            {
                "My purpose is to help you learn about cybersecurity " + Name + ".",
                "I help users understand how to stay safe online " + Name + "." 
            });
            
            responses.Add("what can i ask", new List<string> {
                "You can ask me about passwords, phishing, safe browsing, malware and privacy " + Name + "."
            });
            
            responses.Add("password", new List<string> 
            {
                "Use a strong password that is difficult to guess, " + Name + ".",
                "Do not use the same password for every account, " + Name + ".",
                "A password manager can help you create and store strong passwords, " + Name + "."
            });
            responses.Add("what is a password", new List<string>
            {
                "A password is a secret combination used to protect an account, " + userName + ".",
                "A password helps prevent other people from accessing your account, " + userName + "."
            });

            responses.Add("how do i make a strong password", new List<string>
            {
                "Use a long password with a mix of letters, numbers and symbols, " + userName + ".",
                "Avoid using easy information such as your name or birthday in a password, " + userName + "."
            });
            
            responses.Add("phishing", new List<string> 
            {
                "Phishing is when criminals try to trick you into giving them personal information, " + Name + ".",
                "Be careful when clicking links in suspicious emails or messages, " + Name + ".",
                "Always check who sent a message before clicking on links, " + Name + "." 
            });
            
            responses.Add("safe browsing", new List<string>
            { 
                "Keep your web browser updated, " + Name + ".",
                "Do not enter personal information on suspicious websites, " + Name + ".",
                "Check that a website is secure before entering sensitive information, " + Name + "."
            });
            
            responses.Add("malware", new List<string> 
            {
                "Malware is harmful software that can damage your computer or steal information, " + Name + ".",
                "Only download software from trusted websites, " + Name + "."
            });
           
            responses.Add("privacy", new List<string>
            {
                "Protect your privacy by being careful about what personal information you share online," +
                " " + Name + ".", 
                "Check the privacy settings on your social media accounts, " + Name + "."
            });
            responses.Add("thank you", new List<string>
            {
                "You re welcome "+ Name + ".",
                "No problem "+ Name + ".",
                "Youre welcome Im happy to help "+ Name + "."
            });
        }
        public string getResponse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                {
                  return "I didn't quite understand that. Could you rephrase?";
                }
            input = input.ToLower();
            foreach (var item in responses)
            {
                if (input.Contains(item.Key))
                {
                    return getRandom_response(item.Value);
                }
            } 
            return "I'm not sure about that, " + Name + ". Try asking about passwords, phishing, safe browsing, malware or privacy."; 

        }
        public string getRandom_response(List<string> responseList)
        {
            int number = random.Next(responseList.Count);

            return responseList[number];
        }
    }
}
