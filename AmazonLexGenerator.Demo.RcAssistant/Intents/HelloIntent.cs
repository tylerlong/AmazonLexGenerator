namespace AmazonLexGenerator.Demo.RcAssistant
{
    public class HelloIntent : Intent
    {
        public HelloIntent() : base("Hello", null)
        {
            sampleUtterances = new[]
            {
                "hello", "hi", "hey", "hi there",
                "good morning", "good afternoon", "good evening"
            };
        }
    }
}