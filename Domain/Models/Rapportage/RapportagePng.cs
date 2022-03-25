namespace Domain.Models.Rapportage
{
    /// <summary>
    /// Template pattern
    /// </summary>
    public class RapportagePng : RapportageBase
    {
        public RapportagePng(Sprint sprint)
            : base(sprint) { }

        protected override bool AddFooter(string content)
        {
            return true;
        }

        protected override bool AddHeader(string content)
        {
            return true;
        }

        protected override bool Export()
        {
            return true;
        }
    }
}