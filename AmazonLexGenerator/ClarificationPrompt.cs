namespace AmazonLexGenerator
{
    public class ClarificationPrompt
    {
        public Message[] messages = {new Message("Sorry, I did not understand, can you rephrase that?")};

        public int maxAttempts = 5;
    }
}