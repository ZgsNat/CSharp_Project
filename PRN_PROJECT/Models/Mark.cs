using System;
using System.Collections.Generic;

namespace PRN_PROJECT.Models
{
    public partial class Mark
    {
        public string ExamCode { get; set; } = null!;
        public string Username { get; set; } = null!;
        public int? Mark1 { get; set; }

        public virtual Exam ExamCodeNavigation { get; set; } = null!;
        public virtual Student UsernameNavigation { get; set; } = null!;
    }
}
