using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaithiAsp.Models
{
    public class Examp
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<Subject> Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime ExamTime { get; set; }
        public int Duration { get; set; }
        public IEnumerable<Room> ClassRomm { get; set; }
        public IEnumerable<Faculty> Faculty { get; set; }
        public IEnumerable<Status> Status { get; set; }
                   }
}