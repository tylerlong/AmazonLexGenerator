namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class CompanyGreetingIntent : Intent
    {
        public CompanyGreetingIntent() : base("CompanyGreetingIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"company greetings"}).Variant("greetings", "greeting");
        }
    }
}