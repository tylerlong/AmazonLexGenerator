namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class NotificationSettingsIntent : Intent
    {
        public NotificationSettingsIntent() : base("NotificationSettingsIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get", "list"}
                .Cartesian(new[]
                {
                    "notification settings",
                    "notification settings for {notificationSettingsType}",
                    "{notificationSettingsType} notification settings"
                }).Variant(" notification settings", " alert settings");
            slots = new[]
            {
                new Slot(new NotificationSettingsType())
            };
        }
    }
}