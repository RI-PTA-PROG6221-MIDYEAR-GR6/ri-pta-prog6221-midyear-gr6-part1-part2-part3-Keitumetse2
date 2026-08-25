using System.Media;

namespace CyberSecurity_Awareness_chatbot
{
    public class VoiceGreeting
    {
        public void Voice_Greeting()
        {
           SoundPlayer player = new SoundPlayer("VoiceGreeting_Audio.wav"); 
            player.Play();

            
        }
    }
}
