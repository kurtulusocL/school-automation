using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class StudentNote : BaseHome
    {
        public double Exam1 { get; set; }
        public double Exam2 { get; set; }
        public double Vize { get; set; }
        public double Exam3 { get; set; }
        public double Final { get; set; }
        public double Homework { get; set; }
        public double Result { get; set; }
        public string Statu { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
