using System.Collections.Generic;

namespace Domain.Models.Rapportage
{
    public class Report
    {
        public IReportExportStrategy ExportStrategy { get; set; }
        
        public readonly Sprint Sprint;

        public IList<Header> Headers { get; private set; }  = new List<Header>();

        public IList<Footer> Footers { get; private set; } = new List<Footer>();

        public Report(Sprint sprint, IReportExportStrategy exportStrategy)
        {
            ExportStrategy = exportStrategy;
            Sprint = sprint;
        }
        
        public void AddHeader(Header header)
        {
            Headers.Add(header);
        }

        public void AddFooter(Footer footer)
        {
            Footers.Add(footer);
        }

        public void Export()
        {
            
            ExportStrategy.Export(this);
        }
        
    }
}