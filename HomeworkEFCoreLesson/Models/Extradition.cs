using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkEFCoreLesson.Models
{
    public class Extradition
    {
        public int Id { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public int BookId { get; set; }
        public int ReaderId { get; set; }
    }
}
