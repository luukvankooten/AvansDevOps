namespace Domain.Models.Rapportage
{
    /// <summary>
    /// Template pattern
    /// </summary>
    public abstract class RapportageBase
    {
        protected Sprints.Sprint _sprint;

        public RapportageBase(Sprints.Sprint sprint)
        {
            _sprint = sprint;
        }

        public abstract bool AddHeader(string content);
        public abstract bool AddFooter(string content);
        public abstract bool Export();
    }
}