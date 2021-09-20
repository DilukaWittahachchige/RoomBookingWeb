using Common.Domain;
using EF.Data;
using IDataAccess;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class RoomRepository :GenericRepository<Room>, IRoomRepository
    {
        /// <summary>
        /// Load all available rooms
        /// </summary>
        /// <returns></returns>
  
        public RoomRepository(RoomBookingContext context)
            : base(context)
        {

        }


        public IEnumerable<Room> LoadAllAvailable()
        {
            throw new NotImplementedException();
        }
    }
}
