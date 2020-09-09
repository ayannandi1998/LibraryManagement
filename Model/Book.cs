using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement3.Model
{
    public  class Book
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookCopyno { get; set; }
        public string AuthorName { get; set; }

       
    }
}
