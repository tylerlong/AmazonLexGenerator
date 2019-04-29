using System.Linq;

namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class EditNotificationSettingsIntent : Intent
    {
        public EditNotificationSettingsIntent() : base("EditNotificationSettingsIntent", null)
        {
            var utterances1 = new[] {"edit", "change", "update", "set", "alter", "modify"}
                .Cartesian(new[] {"", "{notificationSettingsAlertType}"})
                .Cartesian(new[] {"notification settings"})
                .Cartesian(new[] {"", "for {notificationSettingsType}"});
            var utterances2 = new[] {"{notificationSettingsActionType}"}
                .Cartesian(new[] {"", "{notificationSettingsAlertType}"})
                .Cartesian(new[] {"notifications"})
                .Cartesian(new[] {"", "for {notificationSettingsType}"});
            sampleUtterances = utterances1.Concat(utterances2).ToArray()
                .Variant(" notification", " alert");
            slots = new[]
            {
                new Slot(new NotificationSettingsActionType()),
                new Slot(new NotificationSettingsAlertType()),
                new Slot(new NotificationSettingsType()),
            };
        }
    }
}