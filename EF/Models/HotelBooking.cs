using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class HotelBooking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
