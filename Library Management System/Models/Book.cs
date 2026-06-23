using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
   public class Book
    {
        public int BookID { get; set; } // generatd
        public string BookTitle { get; set; } // input
        public string BookAuthor { get; set; }// input
        public string Gerne { get; set; }//input
        public int BookStock { get; set; } 
    }
}
