namespace AmazonLexGenerator
{
    public class Message
    {
        public string contentType = "PlainText";
        public string content;

        public Message(string content)
        {
            this.content = content;
        }
    }
}