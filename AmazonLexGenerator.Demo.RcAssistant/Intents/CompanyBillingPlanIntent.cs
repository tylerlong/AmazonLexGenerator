namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class CompanyBillingPlanIntent : Intent
    {
        public CompanyBillingPlanIntent() : base("CompanyBillingPlanIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"company billing plan"});
        }
    }
}