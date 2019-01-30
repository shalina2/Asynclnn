using Async.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asynclnn.Data
{
    public class AsyncDbContext:DbContext
    {
        public AsyncDbContext(DbContextOptions<AsyncDbContext> options) : base(options)

        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Async seattle",
                    Address = "seattle,wA",
                    phone = "425-344-6390"

                },
                 new Hotel
                 {
                     ID = 2,
                     Name = "Async Newyork",
                     Address = "1123 newyork st",
                     phone = "425-344-6290"

                 },
                 new Hotel
                 {
                     ID = 3,
                     Name = "Async Boston",
                     Address = "278 california st",
                     phone = "206-344-6390"

                 },
                  new Hotel
                  {
                      ID = 4,
                      Name = "Async Portland",
                      Address = "1234 madison st",
                      phone = "371-344-6390"

                  },
                   new Hotel
                   {
                       ID = 5,
                       Name = "Async Edmonds",
                       Address = "Edmonds,wA",
                       phone = "425-344-6790"

                   }


                );
               
            modelBuilder.Entity<Amenities>().HasData(
                    new Amenities
                     {
                         ID = 1,
                         Name="coffeeMachine"
                    },
                      new Amenities
                      {
                          ID = 2,
                          Name = "Aircondition"
                      },
                        new Amenities
                        {
                            ID = 3,
                            Name = "Microwave"
                        },
                          new Amenities
                          {
                              ID = 4,
                              Name = "Stove"
                          },
                            new Amenities
                            {
                                ID = 5,
                                Name = "washer"
                            }
                );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "Kingfu",
                    Layouts = "layout.onebed"
                },
                  new Room
                  {
                      ID = 2,
                      Name = "Queenann",
                      Layouts = "layout.onebed"
                  },
                    new Room
                    {
                        ID = 3,
                        Name = "suit",
                        Layouts = "layout.studio"
                    },
                      new Room
                      {
                          ID = 4,
                          Name = "double",
                          Layouts = "layout.twobed"
                      },
                        new Room
                        {
                            ID = 5,
                            Name = "shalom",
                            Layouts = "layout.onebed"
                        },
                        new Room
                        {
                            ID = 6,
                            Name = "ocean",
                            Layouts = "layout.onebed"
                        }
               );
        }


        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
    }

    
}
