using System;

namespace Esr.Module.Funerary.Reports
{
    public class ProvidersView
    {
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string NumberOS { get; set; }
        public string ItemStock { get; set; }
        public int Quantity { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
    }
}