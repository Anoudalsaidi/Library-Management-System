

using Library_Management_System.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System

{
   public class Program
    {
        // system Storge
        public static LibraryContext context = new LibraryContext
        {
            books = new List<Book>(),
            loans = new List<Loan>(),
            members = new List<Member>(),
            reservations = new List<Reservation>()

        };
       public static void RegisterMemeber()
        {
            Console.WriteLine("Enter Member Name :");
            string membername = Console.ReadLine();

            Console.WriteLine("Enter Member Phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter Member Email :");
            string email = Console.ReadLine();

            int memberid = context.members.Count + 1;

            context.members.Add(new Member
            {

                MemberID= memberid,
                MemberName=membername,
                MemberPhone=phone,
                MemberEmail=email

            }
            );

            Console.WriteLine($"Member Added seccuessfully with ID :{memberid}");
        } //case 1

       public static void AddBook()
        {
            Console.WriteLine("Enter Book Title :");
            string booktitle = Console.ReadLine();

            Console.WriteLine("Enter Book Author :");
            string bookauthor = Console.ReadLine();

            Console.WriteLine("Enter Gerne :");
            string gerne = Console.ReadLine();

            Console.WriteLine("Enter Book Stock :");
            int stock = int.Parse(Console.ReadLine());

            int bookid = context.books.Count + 1;


            context.books.Add(new Book
            {
                BookID = bookid,
                BookTitle=booktitle,
                BookAuthor=bookauthor,
                BookStock=stock
            });

            Console.WriteLine($"Book Added Successfully with ID:{bookid}");
        } // case 2

       public static void ViewAllBook()
        {
            Console.WriteLine("-----Avaiable Books-------\n");

            foreach(Book book in context.books)
            {
                Console.WriteLine($"Book ID:{book.BookID} | Book Title: {book.BookTitle} | Book Author: {book.BookAuthor} | Book Gerne : {book.Gerne} | Book Stock: {book.BookStock}");
            }
        }// case 3

     public static void BorrowBook()
        {
            // user input
            Console.WriteLine("Enter Member ID :");
            int memberId = int.Parse(Console.ReadLine());

           Member checkid = context.members.FirstOrDefault(item => item.MemberID == memberId);

            // view book to select book id
            ViewAllBook();

            Console.WriteLine("Enter slecected Book ID:");
            int selectbook = int.Parse(Console.ReadLine());

            Book checkbookid = context.books.FirstOrDefault(item => item.BookID == selectbook);

            // check 
            if(context.books.Count == 0)
            {
                Console.WriteLine($"Book Not Avaiable");
                return;
            }

            //user input
            Console.WriteLine("Enter Borrow Date: ");
            string borrowdate = Console.ReadLine();

            Console.WriteLine("Enter Return Date: note: > 14 days fine will calculate");
            string returndate = Console.ReadLine();


        }





















        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("^^^^^^^-----------------------^^^^^^^");
                Console.WriteLine(" Welcome To Library Managment System");
                Console.WriteLine("^^^^^^^-----------------------^^^^^^^");
                Console.WriteLine("please select an option :");
                Console.WriteLine("1- Regester Memeber");
                Console.WriteLine("2- Add Book");
                Console.WriteLine("3- View Book");
                Console.WriteLine("4- Borrow Book");
                Console.WriteLine("5- Return Book");
                Console.WriteLine("6- Calculate Fine");
                Console.WriteLine("7- Display Active Loan");
                Console.WriteLine("8- Display Over Due Loan");
                Console.WriteLine("9- Most Borrowed Book Report");
                Console.WriteLine("10- Exist");
            }
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    RegisterMemeber();
                    break;
                case 2:
                    AddBook();
                    break;
                case 3:
                    ViewAllBook();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    Console.WriteLine("Invalid Option, Please Try Again!");
                    break;
            }

            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
