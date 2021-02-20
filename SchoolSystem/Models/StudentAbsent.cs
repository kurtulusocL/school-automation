using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class StudentAbsent : BaseHome
    {
        public DateTime AbsentDate { get; set; }
        public bool? IsReport { get; set; }

        public int StudentId { get; set; }
        public int? LessonId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
