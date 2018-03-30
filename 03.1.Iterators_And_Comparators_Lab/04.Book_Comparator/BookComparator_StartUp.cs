/*
 * 04. Book Comparator
 * 
 * Extend your solution from the prevoius task. Create a class BookComparator which should implement the 
 * IComparer<Book> interface and thus include the following method: 
 * •   int Compare(Book, Book) 
 * 
 * BookComparator must compare two books by:
 * 1.  Book title - alphabetical order
 * 2.  Year of publishing a book - from the newest to the oldest
 * 
 * Modify your Library class once again to implement the new sorting.
 * 
 * Example:
 * Input:
 * Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
 * Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
 * Book bookThree = new Book("The Documents in the Case", 1930);
 * 
 * Output:
 * Animal Farm - 2003
 * The Documents in the Case - 2002
 * The Documents in the Case - 1930
 * 
 * https://github.com/PavelDoynov
 */


using System;

class Program
{
    static void Main(string[] args)
    {
        Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
        Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
        Book bookThree = new Book("The Documents in the Case", 1930);

        Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

        foreach (var book in libraryTwo)
        {
            Console.WriteLine(book);
        }
    }
}
