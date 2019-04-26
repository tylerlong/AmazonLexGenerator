namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class NotifictaionSettingsIntent : Intent
    {
        public NotifictaionSettingsIntent() : base("NotifictaionSettingsIntent", null)
        {
            sampleUtterances = new[] {"", "view", "see", "show", "get", "list"}
                .Cartesian(new[]
                {
                    "notification settings",
                    "notification settings for {notificationSettingsType}",
                    "{notificationSettingsType} notification settings"
                }).Variant("notification settings", "alert settings");
            slots = new[]
            {
                new Slot(new NotificationSettingsType())
            };
        }
    }
}