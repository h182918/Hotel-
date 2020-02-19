﻿using System;

namespace HotelLibrary
{
    public enum Size
    {
        Single,
        Double,
        Triple,
        King
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
        public int nBeds { get; private set; }
        public Size size { get; private set; }
        public int roomId { get; private set; }
        public HotelRoom(int roomId, Size size, int nBeds)
        {
            this.roomId = roomId;
            this.size = size;
            this.nBeds = nBeds;

        }
    }

    public class Booking
    {
        public int customerId { get;  set; }
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
        public maintenanceType mt { get; private set; }
        public int roomId { get; private set; }
        public string note { get; private set; }
        public maintenanceStatus ms { get; private set; }

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
        public int userId { get; private set; }
        public string firstName { get; private set; }
        public string surName { get; private set; }
        public User(int userId, string firstName, string surName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.surName = surName;
        }
    }

}
