using System;

namespace HotelReservation.Model
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string UserName { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        public TimeSpan Length => EndTime.Subtract(StartTime);

        public Reservation(RoomID roomID, string userName, DateTime startTime, DateTime endTime) 
        {
            RoomID = roomID;
            UserName = userName;
            StartTime = startTime;
            EndTime = endTime;
        }

    }
}
