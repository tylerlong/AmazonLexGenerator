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
            slots = new[] {new BusinessHoursTypeSlot()};
        }
    }

    class BusinessHoursTypeSlot : Slot
    {
        public BusinessHoursTypeSlot() : base("businessHoursType", "BusinessHoursType", null, null)
        {
            sampleUtterances = new[]
                    {"{businessHoursType} business hours", "business hours for {businessHoursType}"}
                .Variant("hours", "hour");
            valueElicitationPrompt = new ValueElicitationPrompt(new[]
            {
                new Message("**personal** business hours or **company** business hours?")
            });
        }
    }
}