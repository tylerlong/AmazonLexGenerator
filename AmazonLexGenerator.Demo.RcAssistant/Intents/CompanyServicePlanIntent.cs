namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class CompanyServicePlanIntent : Intent
    {
        public CompanyServicePlanIntent() : base("CompanyServicePlanIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"company service plan", "service plan for company"});
        }
    }
}