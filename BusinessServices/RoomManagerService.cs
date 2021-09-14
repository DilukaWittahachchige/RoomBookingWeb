using Common.Domain;
using IBusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class RoomManagerService : IRoomManagerService
    {
        public IEnumerable<Room> LoadAllAvailableRooms()
        {
            var allAvailableRooms = new List<Room>();

            return allAvailableRooms;
        }
    }
}
