using System;
using System.Collections.Generic;


namespace subject_cms.Models
{

    public enum LessonType
    {
        Practice,

        Lecture,

        Laboratory
    }


    ///One subject has several tipes of lessons and different amount of hours
    public class Lesson
    {

        public LessonType Type { get; set; }

        public short Hours { get; set; }

     }
}
