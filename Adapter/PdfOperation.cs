using System;
using Domain.Models.Rapportage;

namespace Adapter
{
    public class PdfOperation: IReportExportStrategy
    {
        public void Export(Report report)
        {
            Console.WriteLine("exported");
        }
    }
}