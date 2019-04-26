namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class CompanyTimeZoneIntent : Intent
    {
        public CompanyTimeZoneIntent() : base("CompanyTimeZoneIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"company"}).Cartesian(new[] {"time zone", "timezone", "time-zone"});
        }
    }
}