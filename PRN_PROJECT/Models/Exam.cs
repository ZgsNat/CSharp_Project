using System;
using System.Collections.Generic;

namespace PRN_PROJECT.Models
{
    public partial class Exam
    {
        public Exam()
        {
            Answers = new HashSet<Answer>();
            Marks = new HashSet<Mark>();
            Questions = new HashSet<Question>();
        }

        public string ExamCode { get; set; } = null!;
        public string? ExamSubject { get; set; }
        public int? Duration { get; set; }
        public int? TotalQues { get; set; }

        public List<Question> ListQuestion{ get; set; }


        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
