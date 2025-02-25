// Task 4: Book Library
// Task: Create a Book class with:
// Title, Author, IsAvailable properties.
// A method BorrowBook() that sets IsAvailable = false.
// A method ReturnBook() that sets IsAvailable = true.
// In Main(), create 3 books, borrow one, and display availability status.
// Allow user interaction (choose which book to borrow/return).

using System;

class BookLibrary {

    public string Title {get; set;}
    public string Author {get; set;}
    public bool IsAvailable {get; set;}

    public BookLibrary (string title, string author ) {
        Title = title;
        Author = author;
        IsAvailable = true;
    }
    public void BorrowBook (BookLibrary Book) {
        if (Book.IsAvailable == false) {
            Console.WriteLine ($"Now the Book {Book.Title} is  Not available");
            return;
        }
        Book.IsAvailable = false;
        Console.WriteLine ("\nThe book has been successfully borrowed\n");    
    }
    public void ReturnBook (BookLibrary Book) {

        Book.IsAvailable = true;
        Console.WriteLine ("The book has been successfully Returned");
    } 


}
class Program {
    static void Main (string[] args) {
    
        BookLibrary [] Books = new BookLibrary[3];
        bool Flag = true;

        for (int i = 0; i < Books.Length; ++i) {

            Console.Write ("Pleasse Enter Book Tittle ");
            string Tittle = Console.ReadLine ();
            Console.Write ("Please Enter Book Author  ");
            string Author = Console.ReadLine ();
            Books[i] = new BookLibrary(Tittle, Author);
            Console.WriteLine ("\n");

        }

        while (true) {
            Console.WriteLine ("You can Borrow book or Return book or Exit to exit\n\nPlease write your command ");
            string command = Console.ReadLine ();
            if (command.Equals ("Borrow")) {
                Console.WriteLine ("Please Enter book's title");
                string Title = Console.ReadLine ();
                for (int i = 0; i < Books.Length; ++i) {
                    if (Books[i].Title.Equals(Title)) {
                        Books[i].BorrowBook (Books[i]);
                        Flag = false;
                        break;
                    }
                }
                if (Flag) {
                    Console.WriteLine ($"The name is {Title} does not exist");
                } 
                Flag = true;
            }
            else if (command.Equals ("Return")) {
                Console.WriteLine ("Please Enter book's title");
                string Title = Console.ReadLine ();
                for (int i = 0; i < Books.Length; ++i) {
                    if (Books[i].Title.Equals(Title)) {
                        Books[i].ReturnBook(Books[i]);
                        Flag = false;
                    }
                }
                if (Flag) {
                    Console.WriteLine ($"The name is {Title} does not exist");
                }
                Flag = true;

            }

            else if (command.Equals("Exit")) {
                break;
            }

            else {
                Console.WriteLine ("This command does not exist");
            }

         }

    }
}