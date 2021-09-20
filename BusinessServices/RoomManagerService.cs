using Common.Domain;
using IBusinessServices;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessServices
{
    public class RoomManagerService : IRoomManagerService
    {
        private readonly IUnitOfWork _unityOfWork;

        public RoomManagerService(IUnitOfWork unityOfWork)
        {
            this._unityOfWork = unityOfWork;
        }

        public IEnumerable<Room> LoadAllAvailableRooms()
        {
            try
            {
                return this._unityOfWork.RoomRepository().Get().ToList().Where(x => x.RoomStatus == RoomStatus.Available);
            }
            catch (Exception ex)
            {
                //TODO: Global exception handling 
                throw ex.InnerException;
            }
        }
    }
}
