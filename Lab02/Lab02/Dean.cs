using System.Collections.Generic;

namespace Lab02
{
    public class Dean : Administration
    {
        private Professor _professor;
        private Calculus _calculus;

        public override List<Course> AttachCourse(Course course)
        {
            if (course == _calculus)
            {
                _calculus =  new Calculus(_professor);
            }
            return new List<Course> {_calculus};
        }

        public IEnumerable<Course> Calculus { get; set; }
    }
}