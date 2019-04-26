namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class CallerIdIntent : Intent
    {
        public CallerIdIntent() : base("CallerIdIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"caller ID", "callerId"})
                .Cartesian(new[] {"", "info", "information", "settings"});
        }
    }
}