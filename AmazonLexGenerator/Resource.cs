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

        public void Prefixify()
        {
            foreach (var intent in this.intents)
            {
                if (!intent.name.StartsWith(this.name))
                {
                    intent.name = $"{this.name}{intent.name}";
                }

                foreach (var intentSlot in intent.slots ?? new Slot[] { })
                {
                    if (!intentSlot.slotType.StartsWith(this.name))
                    {
                        intentSlot.slotType = $"{this.name}{intentSlot.slotType}";
                    }
                }
            }

            foreach (var slotType in this.slotTypes ?? new SlotType[] { })
            {
                if (!slotType.name.StartsWith(this.name))
                {
                    slotType.name = $"{this.name}{slotType.name}";
                }
            }
        }
    }
}