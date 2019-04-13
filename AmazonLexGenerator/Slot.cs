namespace AmazonLexGenerator
{
    public class Slot
    {
        public string[] sampleUtterances;
        public string slotType;
        public string slotTypeVersion = "1";
        public string slotConstraint = "Required";
        public ValueElicitationPrompt valueElicitationPrompt;
        public int priority = 1;
        public string name;

        public Slot(string name, string slotType, string[] sampleUtterances,
            ValueElicitationPrompt valueElicitationPrompt)
        {
            this.name = name;
            this.slotType = slotType;
            this.sampleUtterances = sampleUtterances;
            this.valueElicitationPrompt = valueElicitationPrompt;
        }
    }
}