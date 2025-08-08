namespace C_ADV_04
{
    public delegate string BookDelegate(Book B);
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookDelegate fPtr)
        {
            foreach (Book b in bList)
            {
                Console.WriteLine(fPtr(b));
            }
        }

        public static void ProcessBooksFunc(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book b in bList)
            {
                Console.WriteLine(fPtr(b));
            }
        }
    }
}
