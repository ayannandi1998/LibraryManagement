using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement3.Model
{
    public  class Issue
    {
        [Key]
        public int IssueNo { get; set; }
        public int BookId { get; set; }
        public string CandidateName { get; set; }

       
    }
}
