namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class BusinessHoursIntent : Intent
    {
        public BusinessHoursIntent() : base("BusinessHours", null)
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
                new Slot(
                    new BussinessHoursType(),
                    new[]
                            {"{businessHoursType} business hours", "business hours for {businessHoursType}"}
                        .Variant("hours", "hour"),
                    "**personal** business hours or **company** business hours?"
                )
            };
        }
    }
}