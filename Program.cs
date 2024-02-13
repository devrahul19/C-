using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of integers
        List<int> numbers = new List<int>();

        // Add some numbers to the list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        // Create a list of names
        List<string> names = new List<string>();
        names.Add("Rahul");
        names.Add("Goransh");
        names.Add("Ketan");
        names.Add("Udit");
        names.Add("Vasudha");
        names.Add("Vriti");
        names.Add("Aryan");

        // Create a list of books
        List<string> books = new List<string>();
        books.Add("To Kill a Mockingbird");
        books.Add("1984");
        books.Add("The Great Gatsby");
        books.Add("Pride and Prejudice");
        books.Add("The Catcher in the Rye");

        // Print out the numbers in the list
        Console.WriteLine("Numbers in the list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Print out the names in the list
        Console.WriteLine("\nNames in the list:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Print out the books in the list
        Console.WriteLine("\nBooks in the list:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }
    }
}
