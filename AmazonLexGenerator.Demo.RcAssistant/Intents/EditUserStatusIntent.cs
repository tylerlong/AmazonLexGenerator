namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class EditUserStatusIntent : Intent
    {
        public EditUserStatusIntent() : base("EditUserStatusIntent", null)
        {
            sampleUtterances = new[] {"edit", "change", "update", "set", "alter", "modify"}
                .Cartesian(new[] {"my", ""})
                .Cartesian(new[] {"user", ""})
                .Cartesian(new[] {"status"})
                .Cartesian(new[] {"to {userStatusType}", ""});
            slots = new[]
            {
                new Slot(new UserStatusType())
            };
        }
    }
}