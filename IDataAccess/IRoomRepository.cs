using EF.Models;
using System.Collections.Generic;

namespace IDataAccess
{
    public interface IRoomRepository: IGenericRepository<Room>
    {
        IEnumerable<Room> LoadAllAvailable();
    }
}
