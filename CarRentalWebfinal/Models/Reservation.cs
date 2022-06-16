using System;
using System.ComponentModel.DataAnnotations;


namespace CarRentalWebfinal.Models
{
    public class Reservation
    {

        public int ReservationId { get; set; }

        public int ModelNumber { get; set; }
        public string LocationAddress { get; set; }

        public DateTime PickUpTime { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }


        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
