using System;

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

        public Slot(SlotType slotType, string[] sampleUtterances, ValueElicitationPrompt valueElicitationPrompt) : this(
            Char.ToLowerInvariant(slotType.name[0]) + slotType.name.Substring(1),
            slotType.name, sampleUtterances, valueElicitationPrompt
        )
        {
        }

        public Slot(SlotType slotType, string[] sampleUtterances, string promptMessage) : this(
            slotType,
            sampleUtterances,
            new ValueElicitationPrompt(new[]
            {
                new Message(promptMessage)
            })
        )
        {
        }

        public Slot(SlotType slotType) : this(slotType, slotType.sampleUtterances, slotType.promptMessage)
        {
        }
    }
}