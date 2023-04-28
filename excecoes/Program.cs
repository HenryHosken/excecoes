using excecoes.Entities;
using excecoes.Entities.Execeptions;

namespace excecoes
{
    internal class ProcessFile
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime CheckIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime CheckOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, CheckIn, CheckOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.Write("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                CheckIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MMm/yyyy)");
                CheckOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(CheckIn, CheckOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainExeption e)
            { 
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unesxpect error: " + e.Message);
            }
        }
        
    }
}