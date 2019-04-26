namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class CompanyInfoIntent : Intent
    {
        public CompanyInfoIntent() : base("CompanyInfoIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"company"}).Cartesian(new[] {"info", "information", "details"});
        }
    }
}