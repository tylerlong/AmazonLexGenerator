namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class ServicesIntent : Intent
    {
        public ServicesIntent() : base("ServicesIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get", "list"}
                .Cartesian(new[]
                {
                    "services",
                    "{serviceAvailabilityType} services",
                    "services {serviceAvailabilityType}"
                });
            slots = new[]
            {
                new Slot(new ServiceAvailabilityType())
            };
        }
    }
}