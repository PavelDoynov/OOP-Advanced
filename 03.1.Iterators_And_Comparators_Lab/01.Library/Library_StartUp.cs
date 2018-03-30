﻿/*
 * 01. Library
 * 
 * Create a class Book which should have three public properties:
 * •   string Title
 * •   int Year
 * •   List<string> Authors
 * 
 * Authors can be anonymous, one or many. A Book should have only one constructor.
 * Create a class Library which should store a collection of books and implement the IEnumerable<Book> interface. 
 * •   List<Book> books
 * 
 * A Library should be could be intilized without books or with any number of books and should have only one constructor.
 * 
 * Example:
 * Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
 * Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
 * Book bookThree = new Book("The Documents in the Case", 1930);
 * Library libraryOne = new Library();
 * Library libraryTwo = new Library(bookOne, bookTwo, bookThree);
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

        Library libraryOne = new Library();
        Library libraryTwo = new Library(bookOne, bookTwo, bookThree);
    }
}