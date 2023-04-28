using System;
using System.Collections.Generic;

// Example 1 data assign & display
var book1 = new Book("C# Developer Guide", 300, "English");
var book2 = new Book("Clean Code", 200, "English");
var book3 = new Book("Clean Code", 200, "English");
var book4 = book3 with { Language = "French" };

var likes = new Dictionary<Book, int> { [book1] = 10 };

var (name, pages, language) = book1;

Console.WriteLine("Example1");
Console.WriteLine(book1);
Console.WriteLine(book2);
Console.WriteLine(book3);
Console.WriteLine("book2 == book3: " + (book2 == book3));
Console.WriteLine("book2 == book3: " + (book3 == book4));
Console.WriteLine("Likes [book1] " + likes[book1]);
Console.WriteLine($"Book1: {name} {pages} {language} ");

// Example 2 data assign & display
var car1 = new IndianCars("Mahindra", "XUV 700", 25);
var car2 = new IndianCars("TATA", "Nexon", 15);
var car3 = new IndianCars("TATA", "Nexon", 15);
var car4 = car3 with { prices = 13 };

var carslikes = new Dictionary<IndianCars, int> { [car1] = 200 };

var (carBrand, carName, prices) = car1;

Console.WriteLine("Example2");
Console.WriteLine(car1);
Console.WriteLine(car2);
Console.WriteLine(car3);
Console.WriteLine("book2 == book3: " + (car2 == car3));
Console.WriteLine("book2 == book3: " + (car3 == car4));
Console.WriteLine("Likes [book1] " + carslikes[car1]);
Console.WriteLine($"Car1: {carBrand} {carName} {prices} ");

// Example 1
public record Book
{
    public string Name { get; init; }
    public int Pages { get; init; }
    public string Language { get; init; }

    public Book(string name, int pages, string language)
    {
        Name = name;
        Pages = pages;
        Language = language;
    }

    public void Deconstruct(out string name, out int pages, out string language)
    {
        name = Name;
        pages = Pages;
        language = Language;
    }
}

// Example 2
public record IndianCars(string carBrand, string carName, int prices);
