using System.Collections.Generic;

namespace Esr.Core.Component
{
    public class SReports
    {
        public string Nome { get; set; }
        public string LocalPath { get; set; }
        public Dictionary<string, SInvokeMethod> DataSet { get; set; }
    }
}
