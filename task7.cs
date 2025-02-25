// Task 7: Ticket Booking System
// Task: Create a MovieTicket class with:
// MovieName, SeatNumber, IsBooked.
// A method BookTicket() that marks it as booked.
// In Main(), create 5 seats, allow the user to book one, and prevent double booking.
// Show all available seats before booking.

using System;

class MovieTicket {

    public string MovieName {get; set;}
    public int SeatNumber {get; set;}
    public bool IsBooked {get; set;}

    public MovieTicket (string Name, int Number, bool Booked) {
        MovieName = Name;
        SeatNumber = Number;
        IsBooked = Booked;
    }

    public void BookTicket (MovieTicket obj) {
        if (obj.IsBooked) {
            Console.WriteLine ($"The {obj.MovieName} Is Booked ");
            return;
        } 
        obj.IsBooked = true;
        Console.WriteLine ($"Ticket {obj.MovieName} is succsesfully Booked");
    }

}
class Program {
    static void Main (string[]args) {
        
        MovieTicket[] MovieTickets = new MovieTicket[5];
        MovieTickets[0] = new MovieTicket("Titanic", 1,false);
        MovieTickets[1] = new MovieTicket("Simba", 2, false);
        MovieTickets[2] = new MovieTicket("Terminator", 3, false);
        MovieTickets[3] = new MovieTicket("Knight", 4, false);
        MovieTickets[4] = new MovieTicket("Roki", 5, false);
        Console.WriteLine ("Choose your ticket");
        bool Flag = true;
        while (true) {
            
            for (int i = 0; i < 5; ++i) {
                Console.WriteLine($"Movie name is {MovieTickets[i].MovieName} Seatnumber is {MovieTickets[i].SeatNumber}");
            }
            Console.WriteLine ("If you finish Enter Exit");
            string command = Console.ReadLine ();

            if (command.Equals("Exit")) {
                break;
            }
            for (int i = 0; i < MovieTickets.Length; ++i) {
                if (command.Equals (MovieTickets[i].MovieName)) {
                    if (MovieTickets[i].IsBooked == true) {
                        Console.WriteLine ($"\nThe {MovieTickets[i].MovieName} is already Booked.");
                    }
                    else {
                        MovieTickets[i].IsBooked = true;
                        Console.WriteLine ($"\nThe tickets {MovieTickets[i].MovieName} is successfully Booked.");
                    } 
                    Flag = false;  
                }
            }
            if (Flag) {
                Console.WriteLine ($"The Movie name is {command} does not existed");
            }
            Flag = true;
                Console.WriteLine ("---------------------------------------------------");
        }
    }
}