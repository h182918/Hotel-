using System;

namespace HotelLibrary
{
    public enum Size
    {
        Single,
        Double,
        Triple,
        King
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
        public int customerId { get; private set; }
        public int roomId { get; private set; }
        public DateTime to { get; private set; }
        public DateTime from { get; private set; }
        public string note { get; private set; }
        public Booking(int customerId, int roomId, DateTime to, DateTime from, string note)
        {
            this.customerId = customerId;
            this.roomId = roomId;
            this.to = to;
            this.from = from;
            this.note = note;
        }
    }

}
