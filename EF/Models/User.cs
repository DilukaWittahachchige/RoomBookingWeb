using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserEmailAddress { get; set; }
        public string UserNRIC { get; set; }
        public DateTime UserDateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }

        public ICollection<HotelBooking> HotelBookings { get; set; }
    }
}
