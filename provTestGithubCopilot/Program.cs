using System;

namespace provTestGithubCopilot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string title = "Hello World!";
            string author = "John Doe";
            string isbn = "1234567890";
            string numberOfCopies = "10";
            string publishingYear = "2020";
            //get user input to set all variables
            Console.WriteLine("Please enter the title of the book: ");
            title = Console.ReadLine();
            Console.WriteLine("Please enter the author of the book: ");
            author = Console.ReadLine();
            Console.WriteLine("Please enter the ISBN of the book: ");
            isbn = Console.ReadLine();
            Console.WriteLine("Please enter the number of copies of the book: ");
            numberOfCopies = Console.ReadLine();
            Console.WriteLine("Please enter the publishing year of the book: ");
            publishingYear = Console.ReadLine();
            //call the class LimitedEditionBook
            LimitedEditionBook limitedEditionBook = new LimitedEditionBook(title, author, isbn, numberOfCopies, publishingYear);

            //call the method summary in the class LimitedEditionBook
            limitedEditionBook.Summary();

        }
    }
    //create class called Book
    class Book
    {
        //create properties for title, author, and copyright year
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        //create a constructor that takes in three parameters
        public Book(string title, string author, string isbn)
        {
            //check if title is null or empty
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title cannot be null or empty");
            }
            else
            {
                Title = title;
            }
            //check if author is null or empty
            if (string.IsNullOrEmpty(author))
            {
                throw new ArgumentException("Author cannot be null or empty");
            }
            else
            {
                Author = author;
            }
            //check if isbn is null or empty
            if (string.IsNullOrEmpty(isbn))
            {
                throw new ArgumentException("ISBN cannot be null or empty");
            }
            else
            {

                //check if input is a number if not repeat the process
                try
                {
                    ISBN = int.Parse(isbn);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number for the ISBN");
                    isbn = Console.ReadLine();
                    ISBN = int.Parse(isbn);
                }


            }
        }
        //create a method called Summary
        public virtual void Summary()
        {
            //return a string with the title, author, and copyright year
            Console.WriteLine($"{Title} was written by {Author} in {ISBN}");
        }
    }

    //create a class called LimitedEditionBook
    class LimitedEditionBook : Book
    {
        //create a property called NumberOfCopies
        public int NumberOfCopies { get; set; }
        public int PublishingYear { get; set; }
        //create a constructor that takes in five parameters
        public LimitedEditionBook(string title, string author, string isbn, string numberOfCopies, string publishingYear) : base(title, author, isbn)
        {
            //check if numberOfCopies is null or empty
            if (string.IsNullOrEmpty(numberOfCopies))
            {
                throw new ArgumentException("Number of copies cannot be null or empty");
            }
            else
            {
                //check if input is a number and if it is convert to an int
                int numberOfCopiesNumber;
                if (int.TryParse(numberOfCopies, out numberOfCopiesNumber))
                {
                    //check if numberOfCopies is less than 10 or larger than 100
                    if (numberOfCopiesNumber < 10 || numberOfCopiesNumber > 100)
                    {
                        throw new ArgumentException("Number of copies must be between 10 and 100");
                    }
                    else
                    {
                        NumberOfCopies = numberOfCopiesNumber;
                    }
                }
                else
                {
                    throw new ArgumentException("Number of copies must be a number");
                }

                //check if publishingYear is null or empty
                if (string.IsNullOrEmpty(publishingYear))
                {
                    throw new ArgumentException("Publishing year cannot be null or empty");
                }
                else
                {
                    //check if input is a number and if it is convert to an int
                    int publishingYearNumber;
                    if (int.TryParse(publishingYear, out publishingYearNumber))
                    {
                        //check if publishingYear is less than 1000 or larger than 2020
                        if (publishingYearNumber < 1000 || publishingYearNumber > 2020)
                        {
                            throw new ArgumentException("Publishing year must be between 1000 and 2020");
                        }
                        else
                        {
                            PublishingYear = publishingYearNumber;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Publishing year must be a number");
                    }
                }
            }



        }
        //override the Summary method
        public override void Summary()
        {
            //return a string with the title, author, copyright year, and number of copies
            Console.WriteLine($"{Title} was written by {Author} in {ISBN} and has {NumberOfCopies} copies available");
        }
    }
}
