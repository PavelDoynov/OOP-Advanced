/*
 * 03. Comparable Book
 * 
 * Extend your solution from the prevoius task. Implement the IComparable<Book> interface in the existing class Book.
 * 
 * The comparison between two books should happen in the following order:
 * •   First sort them in ascending chronological order (by year)
 * •   If two books are published in the same year, sort them alphabetically
 * 
 * Override the ToString() method in your Book class so it returns a string in the format:
 * •   {title} - {year}
 * 
 * Change your Library class so that it stores the books in the correct order.
 * You don’t need to change anything in your Main method from the previous task except for the way to print a book on 
 * the Console. 
 * 
 * Example
 * Output:
 * The Documents in the Case - 1930
 * The Documents in the Case - 2002
 * Animal Farm - 2003
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
        Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
        Book bookThree = new Book("The Documents in the Case", 1930);

        Library libraryOne = new Library();
        Library libraryTwo = new Library(bookOne, bookTwo, bookThree); 

        foreach (var book in libraryTwo)
        {
            Console.WriteLine(book);
        }
    }
}
