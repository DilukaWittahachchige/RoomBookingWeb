using EF.Data;
using EF.Models;
using IDataAccess;

namespace DataAccess
{
    public class HotelBookingRepository : GenericRepository<HotelBooking>, IHotelBookingRepository
    {
        /// <summary>
        /// Load all available rooms
        /// </summary>
        /// <returns></returns>

        public HotelBookingRepository(RoomBookingContext context)
            : base(context)
        {

        }
    }
}
