using System.Linq;

namespace AmazonLexGenerator
{
    public class Intent
    {
        public string name;
        public string version = "1";
        public FulfillmentActivity fulfillmentActivity = new FulfillmentActivity();
        public string[] sampleUtterances;
        public Slot[] slots;

        public Intent(string name, string[] sampleUtterances, Slot[] slots)
        {
            this.name = name;
            this.sampleUtterances = sampleUtterances;
            this.slots = slots;
        }

        public Intent AddUtterances(string[] utterances)
        {
            if (sampleUtterances == null)
            {
                sampleUtterances = new string[] { };
            }

            sampleUtterances = sampleUtterances.Concat(utterances).ToArray();
            return this;
        }
    }
}