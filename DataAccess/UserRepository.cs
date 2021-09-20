using EF.Data;
using EF.Models;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
