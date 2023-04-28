using System;
using excecoes.Entities.Execeptions;

namespace excecoes.Entities
{
    internal class Reservation
    {
        public int RomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() 
        {
        }

        public Reservation(int romNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut < CheckIn)
            {
                throw new DomainExeption("Check-out date must be after check-in date");
            }

            RomNumber = romNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || CheckOut < now)
            {
                throw new DomainExeption ("Reservation dates for update must be future date");
            }
            if ( checkOut < CheckIn)
            {
                throw new DomainExeption ("Check-out date must be after check-in date");
            }
            CheckIn = checkIn; 
            CheckOut = checkOut; 
        }
    }
}
