using System;
using Newtonsoft.Json;

namespace AmazonLexGenerator.Demo.RcAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            var intents = new Intent[]
            {
                new BusinessHoursIntent(),
                new CallerIdIntent(),
                new CompanyBillingPlanIntent(),
                new CompanyGreetingIntent(),
                new CompanyInfoIntent(),
                new CompanyServicePlanIntent(),
                new CompanyTimeZoneIntent(),
                new EditBusinessHoursIntent(),
                new EditCallerIdIntent(),
                new EditDndStatusIntent(),
                new EditNotificationSettingsIntent(),
                new EditPersonalInfoIntent(),
                new EditUserStatusIntent(),
                new ServicesIntent(),
                new HelloIntent(),
                new HelpIntent(),
                new NotificationSettingsIntent(),
                new PersonalInfoIntent(),
                new PresenceInfoIntent(),
            };
            var slotTypes = new SlotType[]
            {
                new BusinessHoursType(),
                new NotificationSettingsType(),
                new HelpType(),
                new ServiceAvailabilityType(),
                new UserStatusType(),
                new DndStatusType(),
                new NotificationSettingsActionType(),
                new NotificationSettingsAlertType(),
            };
            var lex = new Lex(new Resource("RcAssistant", intents, slotTypes));
            lex.Prefixify(); // prefix intents and slot types with resource name to avoid naming collision
            Console.WriteLine(lex.ToJsonString());
        }
    }
}