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

        public Intent AddCartesianUtterances(string[] first, string[] second)
        {
            if (sampleUtterances == null)
            {
                sampleUtterances = new string[] { };
            }

            sampleUtterances = sampleUtterances.Concat(from f in first from s in second select $"{f} {s}".Trim())
                .ToArray();
            return this;
        }

        public Intent AddCartesianUtterances(string[] first, string[] second, string[] third)
        {
            if (sampleUtterances == null)
            {
                sampleUtterances = new string[] { };
            }

            sampleUtterances = sampleUtterances
                .Concat(from f in first from s in second from t in third select $"{f} {s} {t}".Trim()).ToArray();
            return this;
        }
    }
}