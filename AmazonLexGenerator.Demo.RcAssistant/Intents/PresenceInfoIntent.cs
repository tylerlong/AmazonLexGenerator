using System.Linq;

namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class PresenceInfoIntent : Intent
    {
        public PresenceInfoIntent() : base("PresenceInfoIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get", "list"}
                .Cartesian(
                    new[] {"presence", "status"}.Cartesian(new[] {"", "info", "information", "details"})
                        .Concat(new[] {"do not disturb", "dnd", "user"}.Cartesian(new[] {"status"})).ToArray()
                );
        }
    }
}