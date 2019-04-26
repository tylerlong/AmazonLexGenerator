namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class EditCallerIdIntent : Intent
    {
        public EditCallerIdIntent() : base("EditCallerIdIntent", null)
        {
            sampleUtterances = new[] {"edit", "change", "update", "set", "alter", "modify"}
                .Cartesian(new[]
                {
                    "caller ID",
                }).Cartesian(new[] {"", "settings", "information", "info"})
                .Variant("caller ID", "callerID");
        }
    }
}