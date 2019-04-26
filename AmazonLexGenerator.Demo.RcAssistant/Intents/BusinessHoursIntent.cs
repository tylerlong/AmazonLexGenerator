namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class BusinessHoursIntent : Intent
    {
        public BusinessHoursIntent() : base("BusinessHoursIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get", "list"}
                .Cartesian(new[]
                {
                    "business hours",
                    "{businessHoursType} business hours",
                    "business hours for {businessHoursType}"
                }).Variant("hours", "hour");
            slots = new[]
            {
                new Slot(new BusinessHoursType())
            };
        }
    }
}