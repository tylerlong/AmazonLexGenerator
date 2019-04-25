using Newtonsoft.Json;

namespace AmazonLexGenerator
{
    public class SlotType
    {
        public string description;
        public string name;
        public string version = "1";
        public EnumerationValue[] enumerationValues;
        public string valueSelectionStrategy = "TOP_RESOLUTION";

        [JsonIgnore] public string promptMessage;
        [JsonIgnore] public string[] sampleUtterances;

        public SlotType(string name, string description, EnumerationValue[] enumerationValues)
        {
            this.name = name;
            this.description = description;
            this.enumerationValues = enumerationValues;
        }
    }
}