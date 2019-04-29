namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class NotificationSettingsType : SlotType
    {
        public NotificationSettingsType() : base("NotificationSettingsType", "Notification Settings Type", null)
        {
            enumerationValues = new[]
            {
                new EnumerationValue(new[] {"voicemail", "voicemails", "voice mail", "voice mails"}),
                new EnumerationValue(new[] {"in-fax", "in fax", "incoming fax", "inbound fax"}),
                new EnumerationValue(new[] {"in-text", "in text", "incoming text", "inbound text"}),
                new EnumerationValue(new[] {"out-fax", "out fax", "outgoing fax", "outbound fax"}),
                new EnumerationValue(new[] {"missed call", "missed calls"}),
            };
            promptMessage =
                "notification settings for **voicemail**, **in-fax**, **out-fax**, **in-text** or **missed call**?";
            sampleUtterances = new[]
                {
                    "notification settings for {notificationSettingsType}",
                    "{notificationSettingsType} notification settings",
                }
                .Variant("notification", "alert");
        }
    }
}