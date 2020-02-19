using System;

namespace Esr.Module.Funerary.Reports
{
    public class OsVehicleView
    {
        public int Id { get; set; }
        public string DriveName { get; set; }
        public string DeadName { get; set; }
        public string BurialPlace { get; set; }
        public string NumberOs { get; set; }
        public string WakeLocation { get; set; }
        public string Service { get; set; }
        public string ModelVehicle { get; set; }
        public string Color { get; set; }
        public string Plate { get; set; }
        public DateTime DateTimeInitial { get; set; }
        public DateTime DateTimeFinal { get; set; }
        public decimal ValueService { get; set; }
        public int DriveId { get; set; }
        public DateTime DateRegistration { get; set; }
    }
}
