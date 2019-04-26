namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class EditBusinessHoursIntent : Intent
    {
        public EditBusinessHoursIntent() : base("EditBusinessHoursIntent", null)
        {
            sampleUtterances = new[] {"edit", "change", "update", "set", "alter", "modify"}
                .Cartesian(new[]
                {
                    "business hours",
                    "office hours",
                    "working hours",
                    "operating hours",
                    "hours of operation",
                }).Variant("hours", "hour");
        }
    }
}