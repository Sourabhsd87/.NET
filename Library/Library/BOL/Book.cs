namespace BOL
{
    public class Book
    {
        private int id;
        private string bookName;
        private string author;
        private DateTime publishDate;
        private double price;

        public Book() { }

        public Book(int id, string bookName, string author, DateTime publishDate, double price)
        {
            this.id = id;
            this.bookName = bookName;
            this.author = author;
            this.publishDate = publishDate;
            this.price = price;
        }

        public int ID { get { return this.id; } set { this.id = value; } }
        public string BOOKNAME { get { return this.bookName; } set { this.bookName = value; } }

        public string AUTHOR { get { return this.author; } set { this.author = value; } }

        public DateTime PUBLISHDATE { get {  return this.publishDate; } set { this.publishDate = value; } }

        public double PRICE { get { return this.price; } set { this.price = value; } }

        public override string ToString()
        {
            return "id=" + this.id + ",Name=" + this.bookName + ",author=" + this.author + "," +
                "Publish Date=" + this.publishDate + ",price=" + this.price;
        }




    }
}