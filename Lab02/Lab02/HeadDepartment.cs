using System.Collections.Generic;

namespace Lab02
{
    public class HeadDepartment : Administration
    {
        private DesignPattern _designPattern;
        private Professor _professor;
        private MachineLearning _machineLearning;
        public override List<Course> AttachCourse(Course course)
        {
            if (course == _designPattern)
            {
                course = new DesignPattern(_professor);
            }
            else if (course == _machineLearning)
            {
                course = new MachineLearning(_professor);
            }

            return new List<Course> {course};
        }
    }
}