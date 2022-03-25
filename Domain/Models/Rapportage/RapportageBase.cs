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

        public abstract bool AddHeader(string content);
        public abstract bool AddFooter(string content);
        public abstract bool Export();
    }
}