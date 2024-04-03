﻿


namespace Ders_ConsoleApp_
{
    public class Book
    {
        public string id { get; set; }

        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be empty");
                }
                else
                {
                    bookName = value;
                }
            }

        }

        private string writerName;
        public string WriterName
        {
            get { return writerName; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The writer name can not be empty");
                }
                else
                {
                    writerName = value;
                }
            }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value<0 || value>100)
                {
                    throw new ArgumentOutOfRangeException("The price must not be less than 0 or greater than 100");

                }
                else
                {
                    price = value;
                }
            }
        }

        private bool bestSeller;

        public bool BestSeller
        {
            get { return Price>20; }
        }

        public Book()
        {
            id = Guid.NewGuid().ToString();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Book Name: {BookName}");
            Console.WriteLine($"Writer Name: {WriterName}");
            Console.WriteLine($"Best Seller: {BestSeller}");
        }
    }


}
