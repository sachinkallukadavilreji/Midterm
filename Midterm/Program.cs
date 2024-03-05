public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.

        if (itemId >= 0)
        {
            ItemId = itemId;
        }
        else { Console.WriteLine("Enter a valid Item id"); }

        if (price >= 0)
        {
            Price = price;
        }
        else { Console.WriteLine("Enter a valid Price"); }

        if (quantityInStock >= 0)
        {
            QuantityInStock = quantityInStock;
        }
        else { Console.WriteLine("Enter a valid stock of the product"); }

        if (itemName != null)
        {
            ItemName = itemName;
        }
        else { Console.WriteLine("Enter a valid Product name"); }

    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.

        if (newPrice >= 0)
        {
            Price = newPrice;
        }
        else { Console.WriteLine("Price needs to be more than zero"); }
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.

        if (additionalQuantity > 0)
        {
            int newQuantity = QuantityInStock;
            newQuantity = newQuantity + additionalQuantity;
            QuantityInStock = newQuantity;
        }
        else { Console.WriteLine("Quantity needs to be more than zero"); }
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        int totalQuantity = QuantityInStock;
        if (totalQuantity >= quantitySold)
        {
            totalQuantity = totalQuantity - quantitySold;
            QuantityInStock = totalQuantity;
        }

        else if (quantitySold < 0) { Console.WriteLine("Quantity needs to be more than zero"); }
        else{ Console.WriteLine("For the item: " + ItemName + ", " + QuantityInStock + " units is only available!!"); }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.

        if (QuantityInStock > 0)
        {
            return true;
        }
        return false;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).

        Console.WriteLine("");
        Console.WriteLine("\n Product ID: " + this.ItemId);
        Console.WriteLine(" Product Name: " + this.ItemName);
        Console.WriteLine(" Product price: " + this.Price);
        Console.WriteLine(" Product stock available: " + this.QuantityInStock);
        Console.WriteLine("");

    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        int itemCount;

        // 1. Print details of all items.
        Console.WriteLine("// 1. Print details of all items.");
        item1.PrintDetails();
        item2.PrintDetails();

        // 2. Sell some items and then print the updated details.
        Console.WriteLine("// 2. Sell some items and then print the updated details.");
        Console.Write("Enter the number of items you want to sell: ");
        itemCount = Convert.ToInt32(Console.ReadLine()) ;
        item1.SellItem(itemCount);
        item1.PrintDetails();

        // 3. Restock an item and print the updated details.
        Console.WriteLine("// 3. Restock an item and print the updated details.");
        Console.Write("Enter the number of items you want to restock: ");
        itemCount = Convert.ToInt32(Console.ReadLine());
        item2.RestockItem(itemCount);
        item2.PrintDetails();

        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine("// 4. Check if an item is in stock and print a message accordingly.");
        Console.WriteLine("Sell all the stock of the product");
        item1.PrintDetails() ;
        Console.Write("Enter the number of items you want to sell: ");
        itemCount = Convert.ToInt32(Console.ReadLine());
        item1.SellItem(itemCount);
        item1.PrintDetails();
        if (item1.IsInStock()) { Console.WriteLine("Item is avaialable"); }
        else { Console.WriteLine("item is not avaialble"); }

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        // 2. Sell some items and then print the updated details.
        // 3. Restock an item and print the updated details.
        // 4. Check if an item is in stock and print a message accordingly.


    }
}
