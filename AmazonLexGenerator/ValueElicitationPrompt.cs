namespace AmazonLexGenerator
{
    public class ValueElicitationPrompt
    {
        public Message[] messages;
        public ResponseCard responseCard;
        public int maxAttempts = 2;

        public ValueElicitationPrompt(Message[] messages)
        {
            this.messages = messages;
        }
    }
}