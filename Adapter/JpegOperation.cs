using System;
using Domain.Models.Rapportage;

namespace Adapter
{
    public class JpegOperation: IReportExportStrategy
    {
        public void Export(Report report)
        {
            Console.WriteLine("exported");
        }
    }
}