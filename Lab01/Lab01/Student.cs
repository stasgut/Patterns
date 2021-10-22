using System.Collections.Generic;

namespace Lab01
{
    public class Student
    {
        public string name { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string student_number { get; set; }
        public float average_mark { get; set; }


        private List<Enrollment> _enrollments = new List<Enrollment>();

        private Course _course;
        public bool CanEnroll(Course course)
        {
            foreach (var enrollment in _enrollments)
            {
                if (enrollment._course == course)
                {
                    return false;
                }
            }
            return true;
        }

        public int TakenCourses()
        {
            return _enrollments.Count;
        }

        public void Enroll(Course course)
        {
            _enrollments.Add(new Enrollment(this, course));
        }

        public void Unenroll(Course course)
        {
            _course = course;
        }
    }
}