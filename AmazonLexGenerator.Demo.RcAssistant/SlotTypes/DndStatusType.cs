using System.Linq;

namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class DndStatusType : SlotType
    {
        public DndStatusType() : base("DndStatusType", "DnD Status Type", null)
        {
            enumerationValues = new[]
            {
                new EnumerationValue("TakeAllCalls",
                    new[] {"take", "accept", "answer", ""}.Cartesian(new[] {"all calls"})),
                new EnumerationValue("DoNotAcceptAnyCalls",
                    new[] {"do not"}.Cartesian(new[] {"take", "accept", "answer"}).Cartesian(new[] {"any calls"})
                        .Concat(new[] {"no calls"}).ToArray()),
                new EnumerationValue("TakeDepartmentCallsOnly", new[] {"", "take", "accept", "answer"}
                    .Cartesian(new[] {"department calls only"})),
                new EnumerationValue("DoNotAcceptDepartmentCalls", new[] {"do not"}
                    .Cartesian(new[] {"take", "accept", "answer"})
                    .Cartesian(new[] {"department calls"}).Concat(new[] {"no department calls"}).ToArray()),
            };
            promptMessage =
                "Do you want to set your Do Not Disturb to **Take All Calls**, **Do Not Accept Any Calls**, **Take Department Calls Only** or **Do Not Accept Department Calls**?";
            sampleUtterances = new[] {"edit", "change", "update", "set", "alter", "modify"}
                .Cartesian(new[] {"it to {dndStatusType}"}).Take(10).ToArray();
        }
    }
}