using System.Linq;

namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class EditDndStatusIntent : Intent
    {
        public EditDndStatusIntent() : base("EditDndStatusIntent", null)
        {
            sampleUtterances = new[] {"edit", "change", "update", "set", "alter", "modify"}
                .Cartesian(new[] {"", "my"})
                .Cartesian(new[] {"DnD status", "do not disturb status"})
                .Cartesian(new[] {"to {dndStatusType}", ""})
                .Concat(new[] {"{dndStatusType}", "{dndStatusType} right now"}).ToArray();
            slots = new[]
            {
                new Slot(new DndStatusType())
            };
        }
    }
}