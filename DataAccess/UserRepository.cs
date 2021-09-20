using EF.Data;
using EF.Models;
using IDataAccess;

namespace DataAccess
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        /// <summary>
        /// Load all available rooms
        /// </summary>
        /// <returns></returns>

        public UserRepository(RoomBookingContext context)
            : base(context)
        {

        }
    }
}
