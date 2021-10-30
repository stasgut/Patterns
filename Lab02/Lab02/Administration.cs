using System.Collections.Generic;

namespace Lab02
{
    public abstract class Administration
    {
        private PersonalInfo _personalInfo;

        public void FillCourse(Professor professor, Group group)
        {
            
        }
        public List<Course> _courses = new List<Course>();

        public abstract List<Course> AttachCourse(Course course);
    }
}