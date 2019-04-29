namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class NotificationSettingsActionType : SlotType
    {
        public NotificationSettingsActionType()
            : base("NotificationSettingsActionType", "Notification Settings Action Type", null)
        {
            enumerationValues = new[]
            {
                new EnumerationValue(new[] {"enable", "send", "receive", "start"}),
                new EnumerationValue(new[] {"disable", "stop", "don't send", "don't receive"}),
            };
            promptMessage = "Do you want to **enable** or **disable** notifications?";
            sampleUtterances = new[]
                {
                    "{notificationSettingsActionType} notifications",
                    "{notificationSettingsActionType} notification",
                }
                .Variant(" notification", " alert");
        }
    }
}