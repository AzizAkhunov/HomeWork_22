using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_22
{
    public class Students
    {
        public string StuName { get; set; }
        public int GrPoint { get; set; }
        public int StuId { get; set; }

        public List<Students> GtStuRec()
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Akbar ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alisher", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Nuri", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Islom", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Doston", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Azim", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "Dovud", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Pulat", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Ronaldu", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Samir", GrPoint = 750 });
            return stulist;
        }
    }
}
