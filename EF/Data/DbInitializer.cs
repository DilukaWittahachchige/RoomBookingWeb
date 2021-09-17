using EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RoomBookingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Rooms.
            if (context.Rooms.Any())
            {
                return;   // DB has been seeded
            }

            var rooms = new Room[]
            {
                new Room{RoomName="1A",Floor=1,RoomStatus=RoomStatus.Occupied,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="1B",Floor=1,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="1C",Floor=1,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="1D",Floor=1,RoomStatus=RoomStatus.Vacant,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="1E",Floor=1,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},

                new Room{RoomName="2A",Floor=2,RoomStatus=RoomStatus.Occupied,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="2B",Floor=2,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="2C",Floor=2,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="2D",Floor=2,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="2E",Floor=2,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},

                new Room{RoomName="3A",Floor=3,RoomStatus=RoomStatus.Occupied,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="3B",Floor=3,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="3C",Floor=3,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="3D",Floor=3,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="3E",Floor=3,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},

                new Room{RoomName="4A",Floor=4,RoomStatus=RoomStatus.Repair,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="4B",Floor=4,RoomStatus=RoomStatus.Occupied,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="4C",Floor=4,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="4D",Floor=4,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new Room{RoomName="4E",Floor=4,RoomStatus=RoomStatus.Available,IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
            };
            foreach (Room r in rooms)
            {
                context.Rooms.Add(r);
            }
            context.SaveChanges();

            var users = new User[]
             {
                new User{UserName="UserA",Type= UserType.Admin,UserPhoneNumber="+6576435089",UserEmailAddress="abc@gmail.com",UserNRIC="P6387362727",UserDateOfBirth=DateTime.Parse("1996-09-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
                new User{UserName="UserB",Type= UserType.Guest,UserPhoneNumber="+6574435089",UserEmailAddress="abc@gmail.com",UserNRIC="P6387362727",UserDateOfBirth=DateTime.Parse("1996-09-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01") },
                new User{UserName="UserC",Type= UserType.HouseKeeper,UserPhoneNumber="+6576455689",UserEmailAddress="abc@gmail.com",UserNRIC="P6387362727",UserDateOfBirth=DateTime.Parse("1996-09-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01") },
                new User{UserName="UserD",Type= UserType.Technician,UserPhoneNumber="+6576477889",UserEmailAddress="abc@gmail.com",UserNRIC="P6387362727",UserDateOfBirth=DateTime.Parse("1996-09-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01") },
                new User{UserName="UserE",Type= UserType.Admin,UserPhoneNumber="+6576435990",UserEmailAddress="abc@gmail.com",UserNRIC="P6387362727",UserDateOfBirth=DateTime.Parse("1996-09-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01") },
             };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

                                                  
        var hotelBookings = new HotelBooking[]
            {
            new HotelBooking{RoomId=1,UserId=2,CheckInTime=DateTime.Parse("2002-09-01") ,CheckOutTime=DateTime.Parse("2002-09-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
            new HotelBooking{RoomId=6,UserId=2,CheckInTime=DateTime.Parse("2002-09-01") ,CheckOutTime=DateTime.Parse("2002-09-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
            new HotelBooking{RoomId=11,UserId=2,CheckInTime=DateTime.Parse("2002-09-01") ,CheckOutTime=DateTime.Parse("2002-09-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
            new HotelBooking{RoomId=16,UserId=2,CheckInTime=DateTime.Parse("2002-09-01") ,CheckOutTime=DateTime.Parse("2002-09-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
            new HotelBooking{RoomId=22,UserId=2,CheckInTime=DateTime.Parse("2002-09-01") ,CheckOutTime=DateTime.Parse("2002-09-01"),IsActive=true,IsDeleted=false,CreatedUserId =1,UpdatedUserId =1,CreatedDateTime=DateTime.Parse("2002-09-01"),UpdatedDateTime=DateTime.Parse("2002-09-01")},
            };
            foreach (HotelBooking h in hotelBookings)
            {
                context.HotelBookings.Add(h);
            }
            context.SaveChanges();
        }
    }
}
