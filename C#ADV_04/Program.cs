namespace C_ADV_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("123", "Book1", ["ali", "ahmed"], DateTime.Now, 500),
                new Book("456", "Book2", ["ahmed", "ali"], DateTime.Now, 500),
                new Book("789", "Book3", ["mohamed", "ahmed"], DateTime.Now, 500)
            };

            #region User Defined Delegate
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle); 
            #endregion

            #region BCL
            //Func<Book, string> func = BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooksFunc(books, func); 
            #endregion

            #region Anonymous Method
            //Func<Book, string> func = delegate (Book book)
            //{
            //    return book.ISBN;
            //};
            //LibraryEngine.ProcessBooksFunc(books, func); 
            #endregion

            #region Lambda Expression 
            //Func<Book, string> func = b => b.PublicationDate.ToString();
            //LibraryEngine.ProcessBooksFunc(books, func); 
            #endregion

        }
    }
}
