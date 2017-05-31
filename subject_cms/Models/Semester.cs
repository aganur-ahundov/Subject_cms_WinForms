using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject_cms.Models
{

    public enum SemsterType
    {
        Exam,

        Credit
    }


    public class Semester
    {

        //Somthing like "Осень 2016"
        public string Title { get; set; }


        //Type and hours of different lesson types
        public IEnumerable<Lesson> Lessons { get; set; }


        public SemsterType Type { get; set; }
    }
}
