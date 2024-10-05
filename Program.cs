// See https://aka.ms/new-console-template for more information
using ConsoleEFLinq.Models;

Console.WriteLine("Hello, World!");
var context = new AdventureWorksContext();
var addresses = context.Addresses.Where(x=>x.PostalCode.Contains("4")).OrderByDescending(x=>x.PostalCode).ToList();
if (addresses.Any())
{
    foreach (var address in addresses)
    {
        Console.WriteLine(address.PostalCode);
    }
}