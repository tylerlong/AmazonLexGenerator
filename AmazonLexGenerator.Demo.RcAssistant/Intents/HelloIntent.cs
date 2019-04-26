namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class HelloIntent : Intent
    {
        public HelloIntent() : base("HelloIntent", null)
        {
            sampleUtterances = new[]
            {
                "hello", "hi", "hey", "hi there",
                "good morning", "good afternoon", "good evening"
            };
        }
    }
}