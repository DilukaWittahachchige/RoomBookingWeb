using Common.Domain;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoomRepository : IRoomRepository
    {
        /// <summary>
        /// Load all available rooms
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Room> LoadAllAvailable()
        {

        }
    }
}
