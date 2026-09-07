namespace CyberSecurity_Awareness_chatbot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string themedSymbol = @" ███▀██       ██                 ███▀█▄                                             ▄██▀█▄                                                          ███▀██ █▄               ██                   
▄███    ▄█ █▄ ██▀█▄ ▄█▀█▄ ▄█▀▀▄ ▀███▄▄  ▄█▀█▄ ▄█▀█▄ ██ ▄▄ ▄█▀▀▄ ▀▀ ▄██▄ ▄█ █▄       ███ ██ ██ ▄▄ ▄▄ ▄█▀█▄ ▄█▀▀▄ ▄█▀█▄ ██▀█▄ ▄█▀█▄ ▄█▀▀▀ ▄█▀▀▀      ▄███    ██▀█▄ ▄█▀█▄ ▄██▄ ██▀█▄ ▄█▀▄▄ ▄██▄     
 ███ ▄▄ ██ ██ ██ ██ ██▀▀  ██     ▄▄▄ ██ ██▀▀  ██ ▄▄ ██ ██ ██    █▄  ██  ██ ██      ▀███▀██ ██ ██ ██ ██▀██ ██    ██▀▀  ██ ██ ██▀▀   ▀▀█▄  ▀▀█▄       ███ ▄▄ ██ ██ ██▀██  ██  ██ ██ ██ ██  ██      
  ▀▀▀▀▀  ▀▀██ ▀▀▀▀   ▀▀▀  ▀▀     ▀▀▀▀▀▀  ▀▀▀   ▀▀▀   ▀▀▀  ▀▀    ▀▀  ▀▀   ▀▀██       ▀▀▀ ▀▀  ▀▀ ▀▀▀  ▀▀ ▀▀ ▀▀     ▀▀▀  ▀▀ ▀▀  ▀▀▀  ▀▀▀▀  ▀▀▀▀         ▀▀▀▀▀ ▀▀ ▀▀ ▀▀ ▀▀  ▀▀  ▀▀▀▀   ▀▀▀   ▀▀      
         ▀▀▀                                                             ▀▀▀                                                                                                                     ";
            Console.WriteLine(themedSymbol);
            VoiceGreeting VG = new VoiceGreeting();
            VG.Voice_Greeting();

            Chatbot chatbot = new Chatbot();
            chatbot.Chatbot_Start();
        }
    }
}
