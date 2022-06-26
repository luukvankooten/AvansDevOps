namespace Domain.Models.Rapportage
{
    public interface IReportExportStrategy
    {
        void Export(Report report);
    }
}
