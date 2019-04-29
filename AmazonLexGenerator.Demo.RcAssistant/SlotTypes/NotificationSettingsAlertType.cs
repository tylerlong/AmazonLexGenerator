namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class NotificationSettingsAlertType : SlotType
    {
        public NotificationSettingsAlertType()
            : base("NotificationSettingsAlertType", "Notification Settings Alert Type", null)
        {
            enumerationValues = new[]
            {
                new EnumerationValue(new[] {"sms", "short message", "text message"}),
                new EnumerationValue(new[] {"email", "e-mail"}),
            };
            promptMessage = "Do you want to change **sms** or **email** notifications?";
            sampleUtterances = new[]
                {
                    "{NotificationSettingsAlertType} notifications",
                    "{NotificationSettingsAlertType} notification",
                }
                .Variant("notification", "alert");
        }
    }
}