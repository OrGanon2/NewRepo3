using HackerWe.Entities;
using HackerWe.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HackerWe.UI
{
    public partial class BooksUserControl : UserControl
    {
        Book newbook = new Book();
        public event Action<Book> AddBook;
        public BooksUserControl()
        {
            InitializeComponent();
        }

        private void BooksUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            //Library.Books.Add(new Book() { Id = int.Parse(IdText.Text), IdentityNumber = IdentityNumberText.Text, Name = NameText.Text, Author = AuthorText.Text, NumberOfPages = int.Parse(NumberOfCopiesText.Text), DatePublished = DatePublishedPicker.Value });
            newbook.Id = int.Parse(IdText.Text);
            newbook.IdentityNumber = IdentityNumberText.Text;
            newbook.Name = NameText.Text;
            newbook.Author = AuthorText.Text;
            newbook.NumberOfPages = int.Parse(NumberOfPagesText.Text);
            newbook.DatePublished = DatePublishedPicker.Value;

            //Library.SaveBooksAsJSON();
            Library.Books.Insert(0, newbook);
            lblMessage.Text = "Added sucessesfully";
            Library.Books.Add(newbook);
            Library.SaveBooksAsJSON();
            AddBook(newbook); 
            


        }

        private void AuhthorText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
