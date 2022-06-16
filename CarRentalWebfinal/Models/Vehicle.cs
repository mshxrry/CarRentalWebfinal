using System.Collections.Generic;

namespace CarRentalWebfinal.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Transmission { get; set; }
        public string ModelNumber { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
