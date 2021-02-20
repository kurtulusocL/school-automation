using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class Holiday : BaseHome
    {
        public string Title { get; set; }
        public DateTime HolidayDate { get; set; }
        public int Day { get; set; }
        public DateTime ComebackDate { get; set; }

        public int? WorkerId { get; set; }
        public int? TeacherId { get; set; }

        public virtual Worker Worker { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
