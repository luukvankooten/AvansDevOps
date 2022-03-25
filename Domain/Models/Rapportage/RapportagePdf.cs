namespace Domain.Models.Rapportage
{
    /// <summary>
    /// Template pattern
    /// </summary>
    public class RapportagePdf : RapportageBase
    {
        public RapportagePdf(Sprint sprint) 
            : base(sprint){ }

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