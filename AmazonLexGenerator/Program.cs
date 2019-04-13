using System;
using Newtonsoft.Json;

namespace AmazonLexGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var intents = new Intent[]
            {
                new Intent("Hello",
                    new[] {"hello", "hi", "hey", "hi there", "good morning", "good afternoon", "good evening"},
                    null),
                new Intent("CallerId", null, null).AddCartesianUtterances(
                    new[] {"", "view", "see", "show", "get"}, new[] {"caller ID", "callerID"},
                    new[] {"", "info", "information", "settings"}),
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