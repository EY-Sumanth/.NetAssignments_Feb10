using System;
using System.Collections.Generic;

namespace StudentWebApI_Feb10.Models
{
    public partial class CourseDetail
    {
        public CourseDetail()
        {
            StudentDetails = new HashSet<StudentDetail>();
        }

        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? CourseResult { get; set; }

        public virtual ICollection<StudentDetail> StudentDetails { get; set; }
    }
}
