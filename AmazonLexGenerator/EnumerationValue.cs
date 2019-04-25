using System.Linq;

namespace AmazonLexGenerator
{
    public class EnumerationValue
    {
        public string value;
        public string[] synonyms;

        public EnumerationValue(string[] values)
        {
            value = values[0];
            synonyms = values.Skip(1).ToArray();
        }

        public EnumerationValue(string value, string[] synonyms)
        {
            this.value = value;
            this.synonyms = synonyms;
        }
    }
}