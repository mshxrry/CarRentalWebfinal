using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalWebfinal.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        // this code means that the brand name cannot be more than 20 characters//
        [StringLength(20, ErrorMessage = "The brand name cannot exceed 20 characters")]
        public string Brand { get; set; }
        // this code means that the model name cannot be more than 20 characters//
        [StringLength(20, ErrorMessage = "The model name cannot exceed 20 characters")]
        public string Model { get; set; }
        // this code means that the car type field cannot be more than 20 characters//
        [StringLength(20, ErrorMessage = "The type cannot exceed 20 characters")]
        public string Type { get; set; }

        [StringLength(20, ErrorMessage = "The transmission cannot exceed 20 characters")]
        public string Transmission { get; set; }
        public int ModelNumber { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
