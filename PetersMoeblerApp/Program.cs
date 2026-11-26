using Peter_Møbler_Lib;
using System;
using System.Collections.Generic;

// Create 5 Chair objects
var chair1 = new Chair(90, 45, 60, new List<string>{ "Wood" }, 101, 299, "Wooden Chair");
var chair2 = new Chair(85, 50, 55, new List<string>{ "Oak", "Steel" }, 102, 450, "Dining Chair");
var chair3 = new Chair(110, 60, 70, new List<string>{ "Mesh", "Plastic" }, 103, 150, "Office Pro");
var chair4 = new Chair(100, 80, 70, new List<string>{ "Leather", "Wood" }, 104, 899, "Leather Lounge");
var chair5 = new Chair(75, 40, 55, new List<string>{ "Plastic" }, 105, 199, "FoldingChair");

// Display the chairs
Console.WriteLine(chair1);
Console.WriteLine(chair2);
Console.WriteLine(chair3);
Console.WriteLine(chair4);
Console.WriteLine(chair5);

Product product1 = new Product(1, 299, "Wooden Chair");
Product product2 = new Product(2, 450, "Modern Table");
Product product3 = new Product(3, 180, "Office Desk");
Product product4 = new Product(4, 899, "Leather Sofa");
Product product5 = new Product(5, 199, "Bookshelf");

Console.WriteLine("Product 1: " + product1.Name + " - " + product1.Price + " DKK");
Console.WriteLine("Product 2: " + product2.Name + " - " + product2.Price + " DKK");
Console.WriteLine("Product 3: " + product3.Name + " - " + product3.Price + " DKK");
Console.WriteLine("Product 4: " + product4.Name + " - " + product4.Price + " DKK");
Console.WriteLine("Product 5: " + product5.Name + " - " + product5.Price + " DKK");


// Examples that trigger ArgumentException (each wrapped in try/catch)
try
{
	// Height too small (must be >=50)
	var badChair1 = new Chair(40, 45, 60, new List<string>{ "Wood" }, 201, 299, "TooShort");
}
catch (ArgumentException ex)
{
	Console.WriteLine("Caught expected exception (height): " + ex.Message);
}

try
{
	// Width too small (must be >=30)
	var badChair2 = new Chair(90, 20, 60, new List<string>{ "Wood" }, 202, 299, "TooNarrow");
}
catch (ArgumentException ex)
{
	Console.WriteLine("Caught expected exception (width): " + ex.Message);
}

try
{
	// Depth too large (must be <=140)
	var badChair3 = new Chair(90, 45, 150, new List<string>{ "Wood" }, 203, 299, "TooDeep");
}
catch (ArgumentException ex)
{
	Console.WriteLine("Caught expected exception (depth): " + ex.Message);
}

try
{
	// No materials (must have at least one)
	var badChair4 = new Chair(90, 45, 60, new List<string>(), 204, 299, "NoMats");
}
catch (ArgumentException ex)
{
	Console.WriteLine("Caught expected exception (materials): " + ex.Message);
}

try
{
	// Price too low (Product validation: must be >=10)
	var badChair5 = new Chair(90, 45, 60, new List<string>{ "Wood" }, 205, 5, "CheapOne");
}
catch (ArgumentException ex)
{
	Console.WriteLine("Caught expected exception (price): " + ex.Message);
}
