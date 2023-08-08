using System;

namespace HotelReservation.Model
{
    public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomnumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomnumber;
        }
        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID &&
                FloorNumber == roomID.FloorNumber &&
                RoomNumber == roomID.RoomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }
    }
}
