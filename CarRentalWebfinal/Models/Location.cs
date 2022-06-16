using CarRentalWebfinal.Models;
using System;
using System.Collections.Generic;

namespace CarRentalWebfinal.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string State { get; set; }


        public ICollection<Reservation> Reservations { get; set; }

    }
}