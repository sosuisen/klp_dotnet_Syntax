namespace Syntax
{
    internal class Book
    {
        private string _author;
        private string _title;
        private int _pages;

        public Book(string author, string title, int pages)
        {
            _author = author;
            _title = title;
            _pages = pages;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"Author: {_author}, Title: {_title}, Pages: {_pages}");
        }
    }
}