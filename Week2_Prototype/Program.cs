var chalk = new InventoryItem("Chalk Box", 20, 5);
var paper = new InventoryItem("Bond Paper Ream", 8, 3);

Console.WriteLine(chalk.RemoveStock(5));
Console.WriteLine(chalk.RemoveStock(100));
Console.WriteLine(chalk.Quantity);
Console.WriteLine(paper.AddStock(10));
Console.WriteLine(paper.Quantity);
Console.WriteLine(paper.NeedsReorder());