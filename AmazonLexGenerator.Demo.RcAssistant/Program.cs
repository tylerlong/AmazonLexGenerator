using System;
using Newtonsoft.Json;

namespace AmazonLexGenerator.Demo.RcAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyBillingPlanUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"company billing plan"});
            var companyBillingPlanIntent = new Intent("CompanyBillingPlan", companyBillingPlanUtterances, null);

            var companyGreetingsUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"company greetings"}).Variant("greetings", "greeting");
            var companyGreetingsIntent = new Intent("CompanyGreetings", companyGreetingsUtterances, null);

            var companyInfoUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"company"}).Cartesian(new[] {"info", "information", "details"});
            var companyInfoIntent = new Intent("CompanyInfoIntent", companyInfoUtterances, null);

            var intents = new[]
            {
                new HelloIntent(),
                new CallerIdIntent(),
                new BusinessHoursIntent(),
                companyBillingPlanIntent,
                companyGreetingsIntent,
                companyInfoIntent
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