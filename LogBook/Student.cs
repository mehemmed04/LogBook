using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook
{
    public class Student
    {
        public int Id { get; set; } = ++ID;
        public static int ID = 0;
        public string Fullname { get; set; }
        public DateTime EnteredMystat { get; set; }
        public int DiamondCount { get; set; } = 0;
        public Image ProfileImage { get; set; }
    }
}
