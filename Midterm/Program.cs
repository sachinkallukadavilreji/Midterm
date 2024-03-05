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
        else
        {
            Console.WriteLine("For the item: " + ItemName + ", " + QuantityInStock + " units is only available!!");
        }
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

        Console.WriteLine("\n Product ID: " + this.ItemId);
        Console.WriteLine(" Product Name: " + this.ItemName);
        Console.WriteLine(" Product price: " + this.Price);
        Console.WriteLine(" Product stock available: " + this.QuantityInStock);

    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);
        item1.SellItem(10);
        item1.PrintDetails();

        Console.WriteLine("Hello" + item1.IsInStock());

        item1.PrintDetails();

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        // 2. Sell some items and then print the updated details.
        // 3. Restock an item and print the updated details.
        // 4. Check if an item is in stock and print a message accordingly.


    }
}
