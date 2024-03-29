﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Book : IComparable<Book>
{
    public Book(string title, int year,  params string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.Authors = authors.ToList();
    }

    public string Title { get; }

    public int Year { get; }

    public List<string> Authors { get; }

    public int CompareTo(Book other)
    {
        int result = this.Year.CompareTo(other.Year);

        if (result == 0)
        {
            return this.Title.CompareTo(other.Title);
        }
        return result;
    }

	public override string ToString()
	{
        return $"{this.Title} - {this.Year}";
	}
}