using System;
using System.Collections.Generic;

namespace PRN_PROJECT.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public int QuestionId { get; set; }
        public string ExamCode { get; set; } = null!;
        public string? QuestionDesc { get; set; }
        public string? AnswerDesc { get; set; }
        public List<Answer> ListAnswer { get; set; }
        public bool Checked { get; set; }
        public bool Correct { get; set; }
        public int CurrentPoint { get; set; }
        public bool InProgress { get; set; }
        public virtual Exam ExamCodeNavigation { get; set; } = null!;
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
