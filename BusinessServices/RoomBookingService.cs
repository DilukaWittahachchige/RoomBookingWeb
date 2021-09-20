using Common.Domain;
using IBusinessServices;
using IDataAccess;

using System.Collections.Generic;
using System.Linq;

namespace BusinessServices
{
    //• A method for requesting for room assignment, which reply with the assigned
    //room number upon success.
    public class RoomBookingService : IRoomBookingService
    {
        private readonly IUnitOfWork _unityOfWork;

        public RoomBookingService(IUnitOfWork unityOfWork)
        {
            this._unityOfWork = unityOfWork;
        }

    }
}
