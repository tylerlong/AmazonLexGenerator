namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class ServiceAvailabilityType : SlotType
    {
        public ServiceAvailabilityType() : base("ServiceAvailabilityType", "Service Availability Type", null)
        {
            enumerationValues = new[]
            {
                new EnumerationValue(new[] {"enabled", "active", "available", "accessible"}),
                new EnumerationValue(new[] {"disabled", "inactive", "unavailable", "inaccessible"}
                )
            };
            promptMessage = "**enabled** services or **disabled** services?";
            sampleUtterances = new[]
                {"{serviceAvailabilityType} services", "services {serviceAvailabilityType}"};
        }
    }
}