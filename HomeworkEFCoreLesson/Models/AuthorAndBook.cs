using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkEFCoreLesson.Models
{
    public class AuthorAndBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }

    }
}
