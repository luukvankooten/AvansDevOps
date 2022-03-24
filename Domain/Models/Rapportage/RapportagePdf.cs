namespace Domain.Models.Rapportage
{
    /// <summary>
    /// Template pattern
    /// </summary>
    public class RapportagePdf : RapportageBase
    {
        public RapportagePdf(Sprints.Sprint sprint) 
            : base(sprint){ }

        public override bool AddFooter(string content)
        {
            return true;
        }

        public override bool AddHeader(string content)
        {
            return true;
        }

        public override bool Export()
        {
            return true;
        }
    }
}