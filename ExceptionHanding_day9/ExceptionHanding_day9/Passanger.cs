using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHanding_day9
{
    class BookingException:ApplicationException
    {
        public BookingException(string msg) : base(msg)
        {

        }
    }
    class Passanger
    {
        public string Name;
        public int Age;
        public void TicketBooking(int no_of_tickets)
        {
            int No_of_tickets = no_of_tickets;
            if (No_of_tickets > 2)
            {
                throw (new BookingException("Cannot book more than 2 tickets"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }

    }
    class book
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name and age");
            Passanger passanger = new Passanger();
            passanger.Name = Console.ReadLine();
            passanger.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"name: {passanger.Name} Age: {passanger.Age} ");
            Console.WriteLine("enter the no of tickets to book");
            try
            {
                int t = Convert.ToInt32(Console.ReadLine());
                passanger.TicketBooking(t);
            }
            catch(BookingException bo)
            {
                Console.WriteLine(bo.Message);
            }
            Console.ReadLine();
        }
    }
}
