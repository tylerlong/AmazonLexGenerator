namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class PersonalInfoIntent : Intent
    {
        public PersonalInfoIntent() : base("PersonalInfoIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"", "my"})
                .Cartesian(new[] {"personal"}).Cartesian(new[] {"info", "information", "details"});
        }
    }
}