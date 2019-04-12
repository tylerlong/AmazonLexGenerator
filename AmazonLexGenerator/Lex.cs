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
    }
}