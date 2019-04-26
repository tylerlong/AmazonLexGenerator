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
                // todo: edit user status intent
                // todo: get services intent
                new HelloIntent(),
                // todo: help intent
                new NotificationSettingsIntent(),
                new PersonalInfoIntent(),
                new PresenceInfoIntent(),
            };
            var slotTypes = new SlotType[]
            {
                new BusinessHoursType(),
                new NotificationSettingsType(),
            };
            var lex = new Lex(new Resource("RcAssistant", intents, slotTypes));
            Console.WriteLine(JsonConvert.SerializeObject(lex, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }));
        }
    }
}