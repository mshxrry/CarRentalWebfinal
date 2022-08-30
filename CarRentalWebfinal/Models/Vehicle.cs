using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalWebfinal.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        [StringLength(20, ErrorMessage = "The brand name cannot exceed 20 characters")]
        public string Brand { get; set; }
        [StringLength(20, ErrorMessage = "The model name cannot exceed 20 characters")]
        public string Model { get; set; }
        [StringLength(20, ErrorMessage = "The type cannot exceed 20 characters")]
        public string Type { get; set; }

        [StringLength(20, ErrorMessage = "The transmission cannot exceed 20 characters")]
        public string Transmission { get; set; }
        public int ModelNumber { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
