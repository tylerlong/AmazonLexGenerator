namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class BussinessHoursType : SlotType
    {
        public BussinessHoursType() : base("BusinessHoursType", "Business Hours Type", null)
        {
            enumerationValues = new[]
            {
                new EnumerationValue(new[] {"personal", "my", "for me", "for myself"}),
                new EnumerationValue(new[]
                    {"company", "office", "enterprise", "organization", "institute", "institution"}
                )
            };
        }
    }
}