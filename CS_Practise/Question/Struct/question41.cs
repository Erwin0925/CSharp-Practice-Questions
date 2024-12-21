namespace CS_Practise.Question.Struct
{
    public struct book
    {
        public required string title;
        public required string author;
    }
    internal class question41
    {
        public void ShowBook()
        {
            book[] arr = new book[3];
            arr[0] = new book { title = "Sample Title0", author = "Sample Author0" };
            arr[1] = new book { title = "Sample Title1", author = "Sample Author1" };
            arr[2] = new book { title = "Sample Title2", author = "Sample Author2" };

            foreach (book book in arr)
            {
                Console.WriteLine(book.title + " " + book.author);
            }

            List<book> list = new List<book>();
            list.Add(new book { title = "Sample Title0", author = "Sample Author0" });
            list.Add(new book { title = "Sample Title1", author = "Sample Author1" });
            list.Add(new book { title = "Sample Title2", author = "Sample Author2" });

            foreach (book book in list)
            {
                Console.WriteLine(book.title + " " + book.author);
            }

        }
    }
}
