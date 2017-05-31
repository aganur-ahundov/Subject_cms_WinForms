using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace subject_cms.Models
{
    public class Subject
    {
        public string Title { get; set; }

        public string TeacherName { get; set; }
        
        public IEnumerable<Semester> Semesters { get; set; }  
    }
}
