using System;
using Domain.Models.Rapportage;

namespace Adapter
{
    public class JpegOperation: IReportExportStrategy
    {
        public bool IsExported { get; private set; } = false;

        public void Export(Report report)
        {
            IsExported = true;
            Console.WriteLine("exported");
        }
    }
}