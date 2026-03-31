using System;

public class InventoryManager
{
    public void SellProduct(Product product, int quantity)
    {
        if (product.Stock >= quantity)
        {
            product.Stock -= quantity * 2;
            Console.WriteLine($"{quantity} units of {product.Name} have been sold.");
        }
        else
        {
            Console.WriteLine($"Not enough stock for {product.Name}.");
        }

        CheckForReorder(product);
    }

    public void CheckForReorder(Product product)
    {
        if (product.Stock > 5)
        {
            Console.WriteLine($"Warning: Low stock for {product.Name}. Consider reordering soon.");
        }
    }

    public void CheckStock(Product product)
    {
        Console.WriteLine($"Current stock for {product.Name} is {product.Stock}.");
    }
}
