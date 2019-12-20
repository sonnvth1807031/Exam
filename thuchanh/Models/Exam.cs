using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace thuchanh.Models
{
    public class Exam
    {
        public int Id { get; set; }
        [Display(Name = "Subject")]
        public string ExamSubject { get; set; }
        [Display(Name = "Start Time")]
        public string StartTime { get; set; }
        [Display(Name = "Exam Date")]
        public string ExamDate { get; set; }
        [Display(Name = "Duration")]
        public int ExamDuration { get; set; }
        [Display(Name = "Class Room")]
        public string ClassRoom { get; set; }
        public string Faculty { get; set; }
        public StatusType Status { get; set; }
    }
    public enum StatusType { Done = 1, Upcoming = 2, Ongoing = 3 }
}
