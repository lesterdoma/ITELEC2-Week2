class InventoryItem
{
    public string Name { get; }
    public int Quantity { get; private set; }
    public int ReorderLevel { get; }

    public InventoryItem(string name, int quantity, int reorderLevel)
    {
        Name = name;
        Quantity = Math.Max(0, quantity);   // never start negative
        ReorderLevel = reorderLevel;
    }

    public bool AddStock(int amount)
    {
        if (amount <= 0) return false;
        Quantity += amount;
        return true;
    }

    // THE RULE: stock can never go below zero
    public bool RemoveStock(int amount)
    {
        if (amount <= 0 || amount > Quantity) return false;
        Quantity -= amount;
        return true;
    }

    public bool NeedsReorder() => Quantity <= ReorderLevel;
}
