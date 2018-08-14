using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventorysystem1
{
    public class Item
    {
        public string Name { get; set; } 
        public float price { get; set; } 
        public int qty { get; set; }
        public string type { get; set; }
       public Item(string name,float price,int qty,string type)
        {
            this.Name = name;
            this.price = price;
            this.qty = qty;
            this.type = type;
        }
        public void display()
        {
            Console.WriteLine($"name : {Name}    price {price}    quntity : {qty}    type : {type}");
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0,newcount=0;
            var items = new List<Item>();
            var i = new Item("lettuce", 10.5f, 50, "Leafy green");
            items.Add(i);
            var a= new Item("cabbage", 20f, 100, "Cruciferous");
            items.Add(a);
            var b = new Item("pumpkin", 30f, 30,"Marrow");
            items.Add(b);
            var c = new Item("cauliflower", 10f, 25, "Cruciferous");
            items.Add(c);
            var d= new Item("zucchini", 20.5f, 50,"Marrow");
            items.Add(d);
            var e= new Item("yam", 30f, 50, "Root");
            items.Add(e);
            var f = new Item("spinach", 10f, 100, "Leafy green");
            items.Add(f);
            var g= new Item("broccoli", 20.2f, 75, "Cruciferous");
            items.Add(g);
            var h = new Item("Garlic", 30f, 20, "Leafy green");
            items.Add(h);
            var j = new Item("silverbeet", 10f, 50, "Marrow");
            items.Add(j);
            foreach(var q in items)
            {
                count++;
                q.display();
            }
            Console.WriteLine($"\n \ntotal number of item in list is : {count}");

            //ADDING ITEM 
            var x = new Item("Potato",10f, 50, "Root");
            items.Add(x);


            foreach (var q in items)
            {
                newcount++;
                q.display();
            }
            Console.WriteLine($"\n \n total number of item in list is after addind new item : {newcount}");
            
            //checking leafy green
            Console.WriteLine("\n \n The Type leafy are:");
            var leafy = items.Where(X => X.type == "Leafy green").ToList();
            foreach (var pr in leafy)
            {
                Console.WriteLine(pr.Name);
            }

            //ALL GARLIC SOLDOUT
            items.RemoveAt(8);
            Console.WriteLine("\n \n After removing Garlic:");
            foreach (var pr in items)
            {
                Console.WriteLine(pr.Name);
            }
            Console.WriteLine("\n \nTotal no of products after garlic deletion=" + items.Count);

            //  Console.WriteLine("Quantity of cabbages after adding: ");
            var cab = items.Where(X => X.Name == "cabbage").ToList();
            foreach (var z in cab)
            {
                Console.WriteLine($"\n \n after addind 5o cabbge qunityty is {z.qty + 50}");
            }
            double total = 0;
            Console.WriteLine("The total cost of items is:");
            foreach (var item in items)
            {
                if (item.Name == "lettuce")
                    total = total + item.price;
                if (item.Name == "zucchini")
                    total = total + item.price;
                if (item.Name == "broccoli")
                    total = total + (2 * item.price);
            }
            Console.WriteLine($"total price is : {total}");


            Console.ReadKey(true);
        }
       

  
}
}
