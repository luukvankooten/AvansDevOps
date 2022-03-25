namespace Domain.Models.Rapportage
{
    /// <summary>
    /// Template pattern
    /// </summary>
    public abstract class RapportageBase
    {
        protected Sprint _sprint;

        public RapportageBase(Sprint sprint)
        {
            _sprint = sprint;
        }

        public bool Generate(Header header, Footer footer)
        {
            return AddHeader(header.Content) && AddFooter(footer.Content) && Export();
        }

        public bool Generate(Header header)
        {
            return AddHeader(header.Content) && Export();
        }

        public bool Generate(Footer footer)
        {
            return AddFooter(footer.Content) && Export();
        }

        protected virtual bool AddHeader(string content) { return true; }
        protected virtual bool AddFooter(string content) { return true; }

        protected abstract bool Export();
    }
}