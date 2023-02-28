namespace Book
{
    abstract class Books
    {
        
        public abstract string Author { get; set; }
        public abstract string Title { get; set; }
        
        public abstract string Describe();
        public string Category()
        {
            return "Fiction Category";
        }
    }
    class Program
    {
        class Fiction : Books
        {
            
            public override string Author { get; set; }
            public override string Title { get; set; }
            public string Type { get; set; }

            public Fiction()
            {
                Author = string.Empty;
                Title = string.Empty;
            }
            public Fiction(string author, string title)
            {
                Author = author;
                Title = title;
            }
            
            public override string Describe()
            {
                return "The books is called " + Title + "by " + Author;
            }

        }
        static void Main(string[] args)
        {
            
            Fiction book = new Fiction();
            book.Author = "Rick Riorden";
            book.Title = "Percy Jackson";
            Console.WriteLine(book.Category());
            Console.WriteLine(book.Describe());
        }
    }
}