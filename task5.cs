// Task 5: Online Shopping Cart
// Task: Create a Product class with:
// Name, Price, and Quantity.
// A method TotalPrice() that returns Price * Quantity.
// In Main(), allow the user to add multiple products to a shopping cart and calculate the total cost.
// If more than 5 items are purchased, apply a 10% discount.

using System;

class Product{
    public string Name { get; set;}
    public int Price {get; set;}
    public int Quantity {get; set;}
    
    public Product (string name, int price, int quantity) {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    
    public void TotalPrice (int Product, int sum) {

        Console.WriteLine ("Your Total Price is  {0}", Product * sum);
    }

}
class Program {
    static void Main (string[] args) {
        
        Product [] Products = new Product [5];

        Console.WriteLine ("\nPlease Enter The product Name, Price and Quantity \n");
        for (int i = 0; i < Products.Length; ++i) {
            Console.Write ("Please Enter the product Nnme  ");
            string name = Console.ReadLine ();
            Console.Write ("Please Enter the product Price  ");
            int price = int.Parse (Console.ReadLine ());
            Console.Write ("Please Enter the product Quantity ");
            int quantity = int.Parse (Console.ReadLine());
            Products[i] = new Product (name, price, quantity);
            Console.WriteLine ("------------------------");
        }

        int sum = 0;
        int ProductsCount = 0;
        bool Flag = true;

        while (true) {
            Console.WriteLine ("which product you can by\nto finish the shoping press Exit");
            for (int i = 0; i < Products.Length; ++i) {
                Console.WriteLine ($"{Products[i].Name}");
            }
                Console.WriteLine ("\n");
            string name = Console.ReadLine ();
            if (name.Equals ("Exit")) {
                break;
            }

            for (int i = 0; i < Products.Length; ++i) {
                if (Products[i].Name.Equals(name)) {
                    Console.WriteLine("\n");
                    if (Products[i].Quantity == 0) {
                        Console.WriteLine ($"{Products[i].Name} is over");
                        Flag = false;
                        break; 
                    }
                    sum += Products[i].Price;
                    Products[i].Quantity--;
                    ++ProductsCount;
                    Flag = false;
                }
            }
            if (Flag) {
                Console.WriteLine ($"The name is {name} does not existed.");
            }
            Flag = true;
        }
        Products[0].TotalPrice (ProductsCount,sum);
    }
}