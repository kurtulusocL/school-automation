using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class Student : BaseHome
    {
        public string NameSurname { get; set; }
        public string IdentityNumber { get; set; }
        public string StudentNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime RegisterDate { get; set; }

        public int LessonId { get; set; }
        public int ClassTypeId { get; set; }
        public int TeacherId { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual ClassType ClassType { get; set; }
        public virtual Teacher Teacher { get; set; }

        public ICollection<StudentNote> StudentNotes { get; set; }
        public ICollection<StudentAbsent> StudentAbsents { get; set; }
    }
}
