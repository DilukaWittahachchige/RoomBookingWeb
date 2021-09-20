using Common.Domain;
using IBusinessServices;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                var roomList = new List<Room>();
                var data = this._unityOfWork.RoomRepository().Get()
                               .ToList().Where(x => x.RoomStatus == (int)RoomStatus.Available);

                data.ToList().ForEach(x =>
                {
                    roomList.Add(ConvertToDomain(x));
                });

                return roomList;
            }
            catch (Exception ex)
            {
                //TODO: Global exception handling 
                throw ex.InnerException;
            }
        }

        private static Room ConvertToDomain(EF.Models.Room obj)
        {
            if (obj == null)
            {
                return new Room();
            }

            return new Room()
            {
                RoomId = obj.RoomId,
                RoomName = obj.RoomName,
                Floor = obj.Floor,
                RoomStatus = ToDomainRoomStatus(obj),
                IsActive = obj.IsActive,
                IsDeleted = obj.IsDeleted,
                CreatedUserId = obj.CreatedUserId,
                UpdatedUserId = obj.UpdatedUserId,
                CreatedDateTime = obj.CreatedDateTime,
                UpdatedDateTime = obj.UpdatedDateTime,
            };
        }

        private static RoomStatus ToDomainRoomStatus(EF.Models.Room obj)
        {
            // insert switch statement here
            switch (obj.RoomStatus)
            {
                case EF.Models.RoomStatus.Available:
                    return RoomStatus.Available;
                case EF.Models.RoomStatus.Occupied:
                    return RoomStatus.Occupied;
                case EF.Models.RoomStatus.Repair:
                    return RoomStatus.Repair;
                case EF.Models.RoomStatus.Vacant:
                    return RoomStatus.Vacant;
                default:
                    throw new InvalidEnumArgumentException($"Invalid RoomStatus: {obj.RoomStatus}");
            };
        }
    }
}
