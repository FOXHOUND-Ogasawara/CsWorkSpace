class Program
{
    static void Main()
    {
        // "Example Product"という名前と100という在庫数を持つ商品を作成します。
        var product1 = new Product("Example Product", 100);
        // 在庫管理マネージャーのインスタンスを作成します。
        var inventoryManager = new InventoryManager();

        Console.WriteLine("1回目の購入");
        // 商品の現在の在庫数をチェックします。
        inventoryManager.CheckStock(product1);
        // 商品を3つ売ります。
        inventoryManager.SellProduct(product1, 3);
        // 商品の在庫数をチェックします。
        inventoryManager.CheckStock(product1);

        Console.WriteLine();
        Console.WriteLine("2回目の購入");
        // 商品をさらに7つ売ります。
        inventoryManager.SellProduct(product1, 7);
        Console.WriteLine();
        Console.WriteLine("現在の在庫数");
        // 最終的な商品の在庫数をチェックします。
        inventoryManager.CheckStock(product1);
    }
}
