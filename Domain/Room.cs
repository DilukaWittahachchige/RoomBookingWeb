using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public enum RoomStatus { Available, Occupied, Vacant, Repair }

    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int Floor { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
