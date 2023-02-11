using System;
using System.Collections.Generic;

namespace StudentWebApI_Feb10.Models
{
    public partial class StudentDetail
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int? StudentAge { get; set; }
        public string? StudentAddress { get; set; }
        public int? StudentFee { get; set; }
        public int? CourseId { get; set; }

        public virtual CourseDetail? Course { get; set; }
    }
}
