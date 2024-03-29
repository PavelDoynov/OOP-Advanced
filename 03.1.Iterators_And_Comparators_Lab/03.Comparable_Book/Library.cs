﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Library :IEnumerable<Book>
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.Books = books.ToList();
    }

    public List<Book> Books
    {
        get { return this.books; }
        private set 
        {
            value.Sort();
            this.books = value; 
        }
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.books = books.ToList();
            this.Reset();

        }

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            this.currentIndex++;
            return this.currentIndex < this.books.Count;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }
    }
}