﻿using HackerWe.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using static System.Reflection.Metadata.BlobBuilder;

namespace HackerWe.Logic
{
    public static class Library
    {
        #region Properties
        public static List<Book> Books { get; set; } = new List<Book>();
        public static List<Client> Clients { get; set; } = new List<Client>();
        public static List<Borowing> Borowings { get; set; } = new List<Borowing>();

        #endregion

        #region Ctor's

        static Library()
        {

        }
        public static void SaveBorrowingToFIXED()
        {
            using (var StreamWriter = new StreamWriter(@"D:\תיקיית לימודים\borrowing.gil29"))
            {
                foreach (var item in Borowings)
                {
                    StreamWriter.WriteLine(item.WriteFixedLength());
                }
                
            }
        }

        #endregion

        public static List<Book> RelevantBooks => Books.Where(x => x.NumberOfBorrowedOut < x.NumberOfCopies).ToList();

        #region File Managament
        #region Save Methods
        public static void SaveBooks()
        {
            var s = "";
            foreach (var book in Library.Books)
            {
                s += book.ToCSV() + Environment.NewLine;

            }
            File.WriteAllText(@"D:\תיקיית לימודים\b.csv", s);
        }
        public static void ReadBooksFromCSV()
        {
            using (var reader = new StreamReader(""))
            {

            }
            var s = "";
            foreach (var book in Library.Books)
            {
                s += book.ToCSV() + Environment.NewLine;

            }
            File.WriteAllText(@"D:\תיקיית לימודים\b.csv", s);
        }


        public static void SaveBooksAsJSON()
        {
            var jsonSTR = JsonSerializer.Serialize(Library.Books);

            File.WriteAllText(@"D:\תיקיית לימודים\HackerWe-master\HackerWe.UI\books.json", jsonSTR);
        }
        public static void SaveBorrowings()
        {
            var jsonSTR = JsonSerializer.Serialize(Library.Borowings);
            File.WriteAllText(@"D:\תיקיית לימודים\HackerWe-master\HackerWe.UI\borrowings.json", jsonSTR);
        }
        #endregion

        public static void ReadBooksFromJSON()
        {
            var jsonSTR = File.ReadAllText(@"books.json");
            Library.Books = JsonSerializer.Deserialize<List<Book>>(jsonSTR);
        }

        public static void ReadClientsFromJSON()
        {
            var jsonSTR = File.ReadAllText(@"clients.json");
            Library.Clients = JsonSerializer.Deserialize<List<Client>>(jsonSTR);
        }
        public static void SaveClientAsJSON()
        {
            var jsonSTR = JsonSerializer.Serialize(Library.Clients);

            File.WriteAllText(@"D:\תיקיית לימודים\HackerWe-master\HackerWe.UI\books.json", jsonSTR);
        }
        #endregion



    }
}
