using CarRentalWebfinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalWebfinal.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Address { get; set; }
        [StringLength(20, ErrorMessage = "The first name cannot exceed 20 characters")]
        public string City { get; set; }
        [StringLength(20, ErrorMessage = "The first name cannot exceed 20 characters")]
        public string State { get; set; }


        public ICollection<Reservation> Reservations { get; set; }

    }
}