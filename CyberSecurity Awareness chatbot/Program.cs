namespace CyberSecurity_Awareness_chatbot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String themedSymbol = "CyberSecurity Awareness Chatbot";
            Console.WriteLine(themedSymbol);
            VoiceGreeting VG = new VoiceGreeting();
            VG.Voice_Greeting();
        }
    }
}
