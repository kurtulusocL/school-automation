using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class Worker : BaseHome
    {
        public string NameSurname { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime HireDate { get; set; }

        public int TaskInSchoolId { get; set; }
        public virtual TaskInSchool TaskInSchool { get; set; }

        public ICollection<Holiday> Holidays { get; set; }
    }
}
