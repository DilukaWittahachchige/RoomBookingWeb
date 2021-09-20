using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccess
{
    public interface IUnitOfWork
    {
        ICodeRepository CodeRepository();
        IHotelBookingRepository HotelBookingRepository();
        IRoomRepository RoomRepository();
        IUserRepository UserRepository();
        void Save();
        void Dispose();
    }
}
