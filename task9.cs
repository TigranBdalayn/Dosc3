// Task 9: Car Rental System
// Task: Create a Car class with:
// Model, Year, IsRented.
// Methods RentCar() and ReturnCar().
// In Main(), create a fleet of 5 cars, let users rent and return cars.
// Prevent renting an already rented car.



using System;

class Car {

    public string Model {get; set;}
    public int Year {get; set;}
    public bool IsRented {get; set;}

    public Car (string model, int year ) {
        Model = model;
        Year = year;
        IsRented = false;
    }

    public void RentCar (Car obj) {
        if (obj.IsRented) {
            Console.WriteLine ($"\nThe {obj.Model} is already rented\n");
            return;
        }
        obj.IsRented = true;
        Console.WriteLine ($"\nThe {obj.Model} is successfully rented\n");
        
    }
    public void ReturnCar (Car obj) {
        obj.IsRented = true;
        Console.WriteLine ("\nThe Car is successfully Returned\n");
    }
}

class Program {
    static void Main (string[]args) {

        bool Flag = true;

        Car [] Cars = new Car [] {
            new Car ("Mercedes", 2025),
            new Car ("BMW", 2008),
            new Car ("Volvo", 1999),
            new Car ("Toyota", 2008),
            new Car ("Volkswagen", 2023)
        };

        while (true) {
            for (int i = 0; i < Cars.Length; ++i) {
                Console.WriteLine ($"Model: {Cars[i].Model}  Year: {Cars[i].Year}");
            }
            Console.WriteLine("\nPlease Choose Your Car or Exit for Exit");
            string car = Console.ReadLine ();
            if (car.Equals ("Exit")) {
                break;
            }
            for (int i = 0; i < Cars.Length; ++i) {
                if (Cars[i].Model.Equals (car)) {
                    Console.WriteLine ("\nDo you  want to Return or Rent the car ");
                    string Command = Console.ReadLine ();
                    if (Command.Equals ("Return")) {
                        Cars[i].ReturnCar (Cars[i]);
                        Flag = false;        
                    }
                    else if (Command.Equals ("Rent")) {
                        Cars[i].RentCar (Cars[i]);
                        Flag = false;
                    }
                }
            }
            if (Flag) {
                Console.WriteLine ($"We dont have the model {car}");
            }
            Flag = true;
        }
    }
}