﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelLibrary
{
    public enum Size
    {
        Single,
        Double,
        Triple,
        Suite
    }
    public enum maintenanceType
    {
        RoomService,
        Maintenance,
        Cleaning
    }
    public enum maintenanceStatus
    {
        Todo,
        Doing,
        Done
    }

    public enum Status
    {
        Booked,
        CheckedIn,
        CheckedOut
    }

    public class HotelRoom
    {
        public int nBeds { get; set; }
        public Size size { get; set; }
        public int roomId { get; set; }
        public HotelRoom(int roomId, Size size, int nBeds)
        {
            this.roomId = roomId;
            this.size = size;
            this.nBeds = nBeds;

        }
    }



    public class Booking
    {
        public int customerId { get; set; }
        public int roomId { get; set; }
        public DateTime to { get; set; }
        public DateTime from { get; set; }
        public Status status { get; set; }
        public string note { get; set; }
        public Booking(int customerId, int roomId, DateTime to, DateTime from, Status status, string note)
        {
            this.customerId = customerId;
            this.roomId = roomId;
            this.to = to;
            this.from = from;
            this.status = status;
            this.note = note;
        }
    }

    public class Maintenance
    {
        public maintenanceType mt { get;  set; }
        public int roomId { get;  set; }
        public string note { get;  set; }
        public maintenanceStatus ms { get;  set; }

        public Maintenance(maintenanceType mt, int roomId, maintenanceStatus ms, string note)
        {
            this.mt = mt;
            this.roomId = roomId;
            this.ms = ms;
            this.note = note;
        }
    }

    public class User
    {
        public int userId { get;  set; }
        public string firstName { get;  set; }
        public string surName { get;  set; }
        public User(int userId, string firstName, string surName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.surName = surName;
        }
    }

    public class bookingService
    {
        //TODO Get DB call
        public List<Booking> bookings { get; set; }
        public List<HotelRoom> rooms { get; set; }

        public bookingService()
        {
            bookings = new List<Booking> () ;//ServerKall();
            rooms = new List<HotelRoom>(); //ServerKall();   //bare tull etter = , errorfiks
        }
        public Booking newBooking(Size size, int nbeds, int customerId, DateTime to, DateTime from, Status status)
        {
            int roomId = firstValidRoomFromList(AvailableRooms(bookings, rooms, from, to, nbeds, size)).roomId;


            string s = "Customer Id: " + customerId.ToString() + " has booked this room";
            Booking b = new Booking(customerId, roomId, to, from, status, s);

            return b;
        }


        public T convertToEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }


        public bool DateCheck(List<Booking> bookings, DateTime dateFrom, DateTime dateTo, HotelRoom room)
        {

            for (DateTime date = dateFrom; date <= dateTo; date = date.AddDays(1))
            {

                foreach (Booking b in bookings)
                {
                    if (!(date >= b.from && date <= b.to))
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        public List<HotelRoom> AvailableRooms(List<Booking> bookings, List<HotelRoom> rooms, DateTime dateFrom, DateTime dateTo, int nBeds, Size size)
        {


            var validRooms = rooms.Where(i => i.nBeds == nBeds && i.size.Equals(size));

            List<HotelRoom> validR = validRooms.ToList();

            //loop through rooms and filter with date
            foreach (HotelRoom r in validR)
            {
                if (!DateCheck(bookings, dateFrom, dateTo, r))

                {
                    validR.Remove(r);
                }

            }
            return validR;

        }



        public HotelRoom firstValidRoomFromList(List<HotelRoom> availableRooms)
        {
            return availableRooms.First();
        }



    }

}
