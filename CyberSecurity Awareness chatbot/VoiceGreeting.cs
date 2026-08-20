using System.Media;

namespace CyberSecurity_Awareness_chatbot
{
    public class VoiceGreeting
    {
        public void Voice_Greeting()
        {
            String file = "VoiceGreeting_Audio.wav";

            if (File.Exists(file))
            {
             SoundPlayer player = new SoundPlayer(file);
                player.Play();
            } else
            {
                Console.WriteLine("The voice greetinngs audio was not found");
            }
        }
    }
}
