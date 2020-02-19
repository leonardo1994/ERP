using System;

namespace Esr.Module.Funerary.Reports
{
    public class DebitNoteView
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string CorporateName { get; set; }
        public string Cnpj { get; set; }
        public string ComercialPhone { get; set; }
        public string CellPhone { get; set; }
        public string LandLine { get; set; }
        public DateTime? DateRegistration { get; set; }
        public string Date { get; set; }
        public string DeadName { get; set; }
        public string NumberDebitNote { get; set; }
        public string ProcessNumber { get; set; }
        public string UserName { get; set; }
        public string Value { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public string Neighborhhod { get; set; }
        public string NumberStreet { get; set; }
        public string City { get; set; }
        public string InitialsState { get; set; }
    }
}
