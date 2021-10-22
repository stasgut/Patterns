using System;
using System.Collections.Generic;

namespace Lab02
{
    public class Enrollment
    {
        
        //Composition
        public Staff _student;
        public Course _course;
        public Seminar _seminar;
        public Enrollment(Staff student, Course course)
        {
            _student = student;
            _course = course;
        }

        Dictionary<DateTime, float> received_marks = new Dictionary<DateTime, float>();
        private Dictionary<Seminar, float> visitedSeminars = new Dictionary<Seminar, float>();


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

        //Check IT!!!
        public float GetSeminarsToDate(DateTime date)
        {
            float visitedSeminars = 0;
            foreach (var seminar in this.visitedSeminars)
            {
                visitedSeminars += seminar.Value;
            }
            return visitedSeminars;
        }
    }
}