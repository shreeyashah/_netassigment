using System;
using System.Collections.Generic;
using System.Linq;

namespace Switchprogram
{
    class Program
    {
        class ProductList
        {
            String name;
            double price;
            int quantity;
            String type;

            //initializing the instance variables
            ProductList(String name, double price, int quantity, String type)
            {
                this.name = name;
                this.price = price;
                this.quantity = quantity;
                this.type = type;
            }
            static void Main(string[] args)
            {
                var products = new List<ProductList>{
           new ProductList( "lettuce",10.5,50,"Leafy green"),
           new ProductList("cabbage",20,100,"Cruciferous"),
           new ProductList("pumpkin", 30,30, "Marrow"),
           new ProductList( "cauliflower", 10 , 25, "Cruciferous"),
           new ProductList( "zucchini", 20.5 , 50, "Marrow"),
           new ProductList( "yam", 30 , 50, "Root"),
           new ProductList( "spinach", 10 , 100, "Leafy green"),
           new ProductList( "broccoli", 20.2, 75, "Cruciferous"),
           new ProductList( "Garlic", 30 , 20, "Leafy green"),
           new ProductList( "silverbeet", 10 , 50, "Marrow")
           };
                int ch = 0;
                while (ch <= 3)
                {
                    Console.WriteLine(" Enter your choice: \n  0 for type finding" +
                                       " \n 1. for calculate price  " +
                                       " \n 2. for finding avregpric " +
                                       "\n 3.for findind cheap or costly" +
                                       "\n  4 for exit ");
                    ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 0:
                            FindTypeMatch();
                            break;
                        case 1:
                            CalculatePrize();
                            break;
                        case 2:
                            FindAVG();
                            break;
                        case 3:
                            cost();
                            break;
                        default:
                            Console.WriteLine("Wrong Choice");
                            break;
                    }
                }

                //type finding function
                void FindTypeMatch()
                {
                    var first = products.Where(x => x.type == "Leafy green").ToList();
                    var second = products.Where(x => x.type == "Cruciferous").ToList();
                    var third = products.Where(x => x.type == "Marrow").ToList();
                    var fourth = products.Where(x => x.type == "Root").ToList();
                    foreach (var f in first)
                        Console.WriteLine("The product and types are:" + " " + f.name + " " + f.type);
                    foreach (var g in second)
                        Console.WriteLine("The product and types are:" + " " + g.name + " " + g.type);
                    foreach (var h in third)
                        Console.WriteLine("The product and types are:" + " " + h.name + " " + h.type);
                    foreach (var i in fourth)
                        Console.WriteLine("The product and types are:" + " " + i.name + " " + i.type);
                }

                //calculating price

                void CalculatePrize()
                {
                    double total_price = 0;
                    foreach (var s in products)
                        total_price+=(s.price * s.quantity);
                    Console.WriteLine("The total price of the inventory is:" + total_price);
                }

                //finding average
                void FindAVG()
                {
                    double avg_price = 0;
                    foreach (var t in products)
                        avg_price = avg_price + (t.price * t.quantity);
                    Console.WriteLine("The average price of the inventory is:" + avg_price / products.Count);
                }
                void cost()
                {
                    var costly = products.Where(X => X.price > 50).ToList();
                    var cheap = products.Where(Y => Y.price  < 50).ToList();
                    Console.WriteLine("The list of costly products are:");
                    foreach (var s in costly)
                    {
                        Console.WriteLine(s.name ,s.price);
                    }
                    Console.WriteLine("The list of cheap products are:");
                    foreach (var p in cheap)
                        Console.WriteLine( p.name , p.price);
                }

            }


        }
    }
}
           
