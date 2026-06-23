

using Library_Management_System.Models;

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
       

        static void Main(string[] args)
        {
            bool flag = false;
            while (flag == false)
            {
                Console.WriteLine("^^^^^^^-----------------------^^^^^^^");
                Console.WriteLine(" Welcome To Library Managment System");
                Console.WriteLine("^^^^^^^-----------------------^^^^^^^");
                Console.WriteLine("please select an option :");
                Console.WriteLine("1- ");
            }
           
        }
    }
}
