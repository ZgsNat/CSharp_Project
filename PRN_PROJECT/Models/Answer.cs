using System;
using System.Collections.Generic;

namespace PRN_PROJECT.Models
{
    public partial class Answer
    {
        public int QuestionId { get; set; }
        public string? ExamCode { get; set; }
        public int Stt { get; set; }
        public string? Answers { get; set; }
        public bool? Correct { get; set; }

        public bool Checked { get; set; }
        public virtual Exam? ExamCodeNavigation { get; set; }
        public virtual Question Question { get; set; } = null!;
    }
}
