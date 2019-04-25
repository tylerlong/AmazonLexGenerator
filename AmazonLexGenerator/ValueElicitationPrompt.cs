namespace AmazonLexGenerator
{
    public class ValueElicitationPrompt
    {
        public Message[] messages;
        public string responseCard = "{\"version\":1,\"contentType\":\"application/vnd.amazonaws.card.generic\",\"genericAttachments\":[]}";
        public int maxAttempts = 2;

        public ValueElicitationPrompt(Message[] messages)
        {
            this.messages = messages;
        }
    }
}