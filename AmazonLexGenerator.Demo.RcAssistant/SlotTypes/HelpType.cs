using System.Linq;

namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class HelpType : SlotType
    {
        public HelpType() : base("HelpType", "Help Type", null)
        {
            enumerationValues = new[]
            {
                new EnumerationValue(new[] {"company"}.Cartesian(new[] {"info", "information", "details"})),
                new EnumerationValue(new[] {"notification"}.Cartesian(new[] {"settings", "info", "information"})
                    .Concat(new[] {"notifications"}).ToArray().Variant("notification", "alert")),
                new EnumerationValue(new[] {"caller ID", "callerId"}
                    .Cartesian(new[] {"", "info", "information", "settings"})),
                new EnumerationValue(new[] {"personal"}.Cartesian(new[]
                    {"info", "information", "settings", "details"})),
                new EnumerationValue(new[] {"presence", "status"}
                    .Cartesian(new[] {"", "info", "information", "details"})
                    .Concat(new[] {"do not disturb", "dnd", "user"}.Cartesian(new[] {"status"})).ToArray()),
            };
            promptMessage =
                "I can help you with the following:\n* **Company Information**\n* **Notifications Settings**\n* **Personal Information**\n* **Presence information**\n* **Caller ID setting**\nWhat do you need help with?";
            sampleUtterances =
                new[] {"help me with", "show commands for", "show feature for"}.Cartesian(new[] {"{helpType}"});
        }
    }
}