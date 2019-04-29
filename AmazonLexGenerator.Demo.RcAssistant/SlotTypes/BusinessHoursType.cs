namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class BusinessHoursType : SlotType
    {
        public BusinessHoursType() : base("BusinessHoursType", "Business Hours Type", null)
        {
            enumerationValues = new[]
            {
                new EnumerationValue(new[] {"personal", "my", "for me", "for myself"}),
                new EnumerationValue(new[]
                    {"company", "office", "enterprise", "organization", "institute", "institution"}
                )
            };
            promptMessage = "**personal** business hours or **company** business hours?";
            sampleUtterances = new[]
                    {"{businessHoursType} business hours", "business hours for {businessHoursType}"}
                .Variant("business hours", "business hour");
        }
    }
}