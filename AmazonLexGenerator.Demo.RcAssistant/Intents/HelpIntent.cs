using System.Linq;

namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class HelpIntent : Intent
    {
        public HelpIntent() : base("HelpIntent", null)
        {
            var utterances1 = new[] {"show", "list"}
                .Cartesian(new[] {"commands"}).Cartesian(new[] {"for {helpType}", ""})
                .Variant(" commands", " command");
            var utterances2 = new[] {"help me with", "show features for"}.Cartesian(new[] {"{helpType}"})
                .Variant(" features", " feature");
            var utterances3 = new[] {"help", "help me", "I need help"};
            sampleUtterances = utterances1.Concat(utterances2).Concat(utterances3).ToArray();
            slots = new[]
            {
                new Slot(new HelpType())
            };
        }
    }
}