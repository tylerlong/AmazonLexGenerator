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

                new HelloIntent(),
            };
            var slotTypes = new[]
            {
                new BussinessHoursType()
            };
            var lex = new Lex(new Resource("RcAssistant", intents, slotTypes));
            Console.WriteLine(JsonConvert.SerializeObject(lex, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }));
        }
    }
}