using System.Collections.Generic;

namespace Lab02
{
    public abstract class Staff
    {
        private PersonalInfo _personalInfo { get; set; }
        
        public Course course;

        public bool CanEnroll()
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

        private List<Enrollment> _enrollments = new List<Enrollment>();
        private List<Course> takenCourse = new List<Course>();

        public void Enroll(Course course)
        {
            _enrollments.Add(new Enrollment(this, course));
        }

        public static void Unassign(Course course)
        {
            //
        }

        public abstract float CalculateWorkload();
        public abstract string GetViolation(string message);

    }
}