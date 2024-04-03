// See https://aka.ms/new-console-template for more information
using EF.Models;

Console.WriteLine("Hello, World!");
diskShoshiFContext context = new diskShoshiFContext();
//foreach(var item in context.DiskInShops)
//{
//    Console.WriteLine(item.DiCost);
//}
DiskInShop newDisk = new DiskInShop() { DiDDiskId = 11111, DiShopId = 11111, DiCost = 11111 };
context.DiskInShops.Add(newDisk);
context.SaveChanges();
Console.ReadLine();