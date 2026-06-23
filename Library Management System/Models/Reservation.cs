using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int MemberID { get; set; }
        public int BookID { get; set; }
        public string ReservarionDate { get; set; }
    }
}
