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
                // todo: edit dnd status intent
                // todo: edit notification settings intent
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
            };
            var lex = new Lex(new Resource("RcAssistant", intents, slotTypes));
            Console.WriteLine(JsonConvert.SerializeObject(lex, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }));
        }
    }
}