using System.Media;

namespace CyberSecurity_Awareness_chatbot
{
    public class VoiceGreeting
    {
        public void Voice_Greeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\OneDrive - ADvTECH Ltd\\Documents\\GitHub\\POE\\ri-pta-prog6221-midyear-gr6-part1-part2-part3-Keitumetse2\\CyberSecurity Awareness chatbot\\Voice Greetings Audio.wav");
                player.Play();
            }
            catch (Exception Audio)
            {
                Console.WriteLine("Error!!. Greetings Audio not found "+ Audio.Message);
            }
            
        }
    }
}
