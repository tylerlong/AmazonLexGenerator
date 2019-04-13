using System;
using Newtonsoft.Json;

namespace AmazonLexGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var helloUtterances = new[]
            {
                "hello", "hi", "hey", "hi there",
                "good morning", "good afternoon", "good evening"
            };
            var helloIntent = new Intent("Hello", helloUtterances, null);

            var callerIDUtterances = new[] {"", "view", "see", "show", "get"}
                .Cartesian(new[] {"caller ID", "callerID"})
                .Cartesian(new[] {"", "info", "information", "settings"});
            var callerIDIntent = new Intent("CallerID", callerIDUtterances, null);

            var businessHoursUtterances = new[] {"", "view", "see", "show", "get", "list"}
                .Cartesian(new[]
                {
                    "business hours",
                    "{businessHoursType} business hours",
                    "business hours for {businessHoursType}"
                }).Variant("hours", "hour");
            var businessHoursSlotUtterances = new[]
                    {"{businessHoursType} business hours", "business hours for {businessHoursType}"}
                .Variant("hours", "hour");
            var valueElicitationPrompt = new ValueElicitationPrompt(new[]
            {
                new Message("**personal** business hours or **company** company hours?")
            });
            var businessHoursSlots = new[]
            {
                new Slot("businessHoursType", "BusinessHoursType",
                    businessHoursSlotUtterances, valueElicitationPrompt)
            };
            var businessHoursIntent = new Intent("BusinessHours", businessHoursUtterances, businessHoursSlots);

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
                helloIntent,
                callerIDIntent,
                businessHoursIntent,
                companyBillingPlanIntent,
                companyGreetingsIntent,
                companyInfoIntent
            };
            var slotTypes = new SlotType[] { };
            var lex = new Lex(new Resource("RcAssistant", intents, slotTypes));
            Console.WriteLine(JsonConvert.SerializeObject(lex, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }));
        }
    }
}