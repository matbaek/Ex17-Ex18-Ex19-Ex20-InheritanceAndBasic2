﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class BookRepository 
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ItemId == itemId)
                {
                    return books[i];
                }
                
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            for (int i = 0; i < books.Count; i++)
            {
                totalValue += Utility.GetValueOfBook(books[i]);
            }

            return totalValue;
        }

    }
}
