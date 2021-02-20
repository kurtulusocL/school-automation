using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class TaskInSchool : BaseHome
    {
        public string KindOfTask { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
