namespace AmazonLexGenerator
{
    public class Resource
    {
        public string name;
        public string version = "1";
        public Intent[] intents;
        public SlotType[] slotTypes;
        public string voiceId = "0";
        public bool childDirected = false;
        public string locale = "en-US";
        public int idleSessionTTLInSeconds = 600;
        public ClarificationPrompt clarificationPrompt = new ClarificationPrompt();
        public AbortStatement abortStatement = new AbortStatement();

        public Resource(string name, Intent[] intents, SlotType[] slotTypes)
        {
            this.name = name;
            this.intents = intents;
            this.slotTypes = slotTypes;
        }
    }
}