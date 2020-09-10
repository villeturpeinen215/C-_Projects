using BooksReadApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksReadApp
{
    public partial class BookFrm : Form
    {
        BooksReadContext context = new BooksReadContext();
        public BookFrm()
        {
            InitializeComponent();
        }

        private void BookFrm_Load(object sender, EventArgs e)
        {
            //load books from database to the datagridview
            dataGridView1.DataSource = context.Books.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //set correct values to update/details textboxes when a row is clicked
                var row = dataGridView1.SelectedRows[0];
                var book = (Book)row.DataBoundItem;
                txtUpdateId.Text = book.Id.ToString();
                txtUpdateName.Text = book.Name;
                txtUpdateAuthor.Text = book.Author;
                txtUpdateLang.Text = book.Language;
                txtUpdatePages.Text = book.Pages.ToString();
                txtUpdatePublisher.Text = book.Publisher;
                txtUpdatePublDate.Text = book.Publication_date;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int pages;

            //check for empty fields
            if (!string.IsNullOrEmpty(txtAddName.Text) && !string.IsNullOrEmpty(txtAddAuthor.Text) &&
                !string.IsNullOrEmpty(txtAddLang.Text) && int.TryParse(txtAddPages.Text, out pages) &&
                !string.IsNullOrEmpty(txtAddPublisher.Text) && !string.IsNullOrEmpty(txtAddPublDate.Text))
            {

                //add a book to database
                context.Books.Add(new Book
                {
                    Name = txtAddName.Text,
                    Author = txtAddAuthor.Text,
                    Language = txtAddLang.Text,
                    Pages = pages,
                    Publisher = txtAddPublisher.Text,
                    Publication_date = txtAddPublDate.Text
                });               
                context.SaveChanges();
                //refresh datagridview content after adding a new book
                dataGridView1.DataSource = context.Books.ToList();
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int pages;

            //check for empty fields
            if (!string.IsNullOrEmpty(txtUpdateId.Text) && !string.IsNullOrEmpty(txtUpdateName.Text) && !string.IsNullOrEmpty(txtUpdateAuthor.Text) 
            && !string.IsNullOrEmpty(txtUpdateLang.Text) && int.TryParse(txtUpdatePages.Text, out pages) 
            && !string.IsNullOrEmpty(txtUpdatePublisher.Text) && !string.IsNullOrEmpty(txtUpdatePublDate.Text))
            {
                //get correct values to the correct textboxes
                var book = context.Books.Find(int.Parse(txtUpdateId.Text));
                book.Name = txtUpdateName.Text;
                book.Author = txtUpdateAuthor.Text;
                book.Language = txtUpdateLang.Text;
                book.Pages = pages;
                book.Publisher = txtUpdatePublisher.Text;
                book.Publication_date = txtUpdatePublDate.Text;
                context.SaveChanges();
                dataGridView1.DataSource = context.Books.ToList();
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            //show a confirmation message before deleting a book
            if(MessageBox.Show("Are you sure you want to delete this book?", "Delete confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var book = context.Books.Find(int.Parse(txtUpdateId.Text));
                //attach entity
                context.Books.Attach(book);
                //remove book
                context.Books.Remove(book);
                context.SaveChanges();
                //refresh datagridview after deletion
                dataGridView1.DataSource = context.Books.ToList();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all fields
            txtAddName.Clear();
            txtAddAuthor.Clear();
            txtAddLang.Clear();
            txtAddPages.Clear();
            txtAddPublisher.Clear();
            txtAddPublDate.Clear();
        }
    }
}
