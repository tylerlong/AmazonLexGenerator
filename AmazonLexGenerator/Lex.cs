using Newtonsoft.Json;

namespace AmazonLexGenerator
{
    public class Lex
    {
        public Metadata metadata = new Metadata();
        public Resource resource;

        public Lex(Resource resource)
        {
            this.resource = resource;
        }

        public void Prefixify()
        {
            this.resource.Prefixify();
        }

        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}