using System;

namespace subject_cms.Models
{

    public enum SemesterType
    {
        Exam,

        Credit
    }


    public class Semester
    {
        public Semester()
        {
            Lectures = new Lesson();
            Lectures.Type = LessonType.Lecture;

            Practice = new Lesson();
            Practice.Type = LessonType.Practice;

            Laboratory = new Lesson();
            Laboratory.Type = LessonType.Laboratory;
        }


        //Somthing like "Осень 2016"
        public string Title { get; set; }


        //public IEnumerable<Lesson> Lessons { get; set; }

        //Type and hours of different lesson types
        public Lesson Lectures { get; set; }

        public Lesson Practice { get; set; }

        public Lesson Laboratory { get; set; }


        public SemesterType Type { get; set; }


        public int LessonsHours {
            get
            {
                return Lectures.Hours + Practice.Hours + Laboratory.Hours;
            }
        }
    }
}
