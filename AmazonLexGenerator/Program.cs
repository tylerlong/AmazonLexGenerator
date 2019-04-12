using System;
using Newtonsoft.Json;

namespace AmazonLexGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var intents = new Intent[] { };
            var slotTypes = new SlotType[] { };
            var lex = new Lex(new Resource("RcAssistant", intents, slotTypes));
            Console.WriteLine(JsonConvert.SerializeObject(lex, Formatting.Indented));
        }
    }
}