using System;
using System.Collections.Generic;

namespace Lab01
{
    public class Enrollment
    {
        
        //Composition
        public Student _student;
        public Course _course;
        public Enrollment(Student student, Course course)
        {
            _student = student;
            _course = course;
        }

        Dictionary<DateTime, float> received_marks = new Dictionary<DateTime, float>();
        

        public float GetAverageToDate(DateTime data){
        
        float avarege = 0;
            foreach (var mark in received_marks)
            {
                if (mark.Key < data)
                {
                    avarege += mark.Value;
                }
            }
            return avarege;
        }

        public float GetFinalMark()
        {
            float finalmark = 0;
            foreach (var mark in received_marks)
            {
                finalmark += mark.Value;
            }
            return finalmark;
        }
    }
}