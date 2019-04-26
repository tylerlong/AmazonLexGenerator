namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class EditPersonalInfoIntent : Intent
    {
        public EditPersonalInfoIntent() : base("EditPersonalInfoIntent", null)
        {
            sampleUtterances = new[] {"edit", "change", "update", "set", "alter", "modify"}
                .Cartesian(new[]
                {
                    "personal",
                }).Cartesian(new[] {"info", "information", "details"});
        }
    }
}