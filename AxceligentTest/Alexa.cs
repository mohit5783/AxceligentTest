using System;

namespace AxceligentTest
{
    public class Alexa
    {
        public AlexaConfiguration ac { get; set; } = new AlexaConfiguration();
        public string TalkingString { get; set; }

        public Alexa()
        {
            TalkingString = "hello, i am Alexa";
        }
        public string Talk()
        {
            return TalkingString;
        }
        public void Configure(Action<AlexaConfiguration> config)
        {
            config(ac);
            TalkingString = ac.GreetingMessage.Replace("{OwnerName}", ac.OwnerName);
        }
    }
    public class AlexaConfiguration
    {
        public string OwnerName { get; set; }
        public string GreetingMessage { get; set; }
    }
}