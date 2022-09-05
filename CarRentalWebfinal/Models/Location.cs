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
        // this code says that the city cannot be more than 20 characters//
        [StringLength(20, ErrorMessage = "The city cannot exceed 20 characters")]
        public string City { get; set; }
        // this code says that the state cannot be more than 20 characters//
        [StringLength(20, ErrorMessage = "The  state cannot exceed 20 characters")]
        public string State { get; set; }


        public ICollection<Reservation> Reservations { get; set; }

    }
}