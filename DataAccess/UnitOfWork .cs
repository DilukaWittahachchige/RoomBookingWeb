using EF.Data;
using EF.Models;
using IDataAccess;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private RoomBookingContext context = new RoomBookingContext(new DbContextOptions<RoomBookingContext>());
        private readonly ICodeRepository _codeRepository;
        private readonly IHotelBookingRepository _hotelBookingRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly IUserRepository _userRepository;

        public UnitOfWork(
            ICodeRepository codeRepository,
            IHotelBookingRepository hotelBookingRepository,
            IRoomRepository roomRepository,
            IUserRepository userRepository
            )
        {
            this._codeRepository = codeRepository;
            this._hotelBookingRepository = hotelBookingRepository;
            this._roomRepository = roomRepository;
            this._userRepository = userRepository;
        }

        public ICodeRepository CodeRepository()
        {
            return this._codeRepository;
        }

        public IHotelBookingRepository HotelBookingRepository()
        {
            return this._hotelBookingRepository;
        }

        public IRoomRepository RoomRepository()
        {
            return this._roomRepository;
        }

        public IUserRepository UserRepository()
        {
            return this._userRepository;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
