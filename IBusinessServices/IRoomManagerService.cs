using Common.Domain;
using System.Collections.Generic;

namespace IBusinessServices
{
      // A method to check out of a room.
     // A method to mark a room cleaned(Available).
     // A method to mark a room for repair.
     // A method to list all the available rooms.
    public interface IRoomManagerService
    {
        IEnumerable<Room> LoadAllAvailableRooms();
    }
}
