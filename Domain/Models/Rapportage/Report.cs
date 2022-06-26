using System.Collections.Generic;

namespace Domain.Models.Rapportage
{
    public class Report
    {
        public IReportExportStrategy ExportStrategy { get; set; }
        
        public readonly Sprint Sprint;

        public readonly IList<Header> Headers = new List<Header>();
        
        public readonly IList<Footer> Footers = new List<Footer>();

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