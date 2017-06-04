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
        
        public List<Semester> Semesters { get; set; }  


        public int GetTotalHours ()
        {
            int result = 0;
            foreach ( Semester current in Semesters )
                result += current.LessonsHours;

            return result;
        }
    }
}
