using System.Linq;

namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class UserStatusType : SlotType
    {
        public UserStatusType() : base("UserStatusType", "User Status Type", null)
        {
            enumerationValues = new[]
            {
                new EnumerationValue(new[] {"available", "free"}),
                new EnumerationValue(new[] {"busy"}),
                new EnumerationValue(new[] {"offline"}),
            };
            promptMessage = "Do you want to update your status to **available**, **busy** or **offline**?";
            sampleUtterances = new[] {"edit", "change", "update", "set", "alter", "modify"}
                .Cartesian(new[] {"status to {userStatusType}"}).Take(10).ToArray();
        }
    }
}