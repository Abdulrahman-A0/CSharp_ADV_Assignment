namespace C_ADV_04
{
    public partial class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}" +
                $"\nTitle: {Title}" +
                $"\nAuthors {string.Join(",", Authors)}" +
                $"\nPublicationDate: {PublicationDate}" +
                $"\nPrice: {Price.ToString("c")}";
        }
    }
}
