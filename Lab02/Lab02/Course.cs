using System;
using System.Collections.Generic;

namespace Lab02
{
    public abstract class Course
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public DateTime start_date { get; set; }
        public string seminars_numbers { get; set; }
        public string fee { get; set; }
        public List<int> seminarId = new List<int>();
        public List<Staff> students = new List<Staff>();


        //Association
        private Professor _professor;
        public Course(Professor professor)
        {
            _professor = professor; 
        }
        
        
        private List<Student> _students = new List<Student>();

        public abstract void AddStudent(Student student);

        public abstract void RemoveStudent(Student student);

        public abstract void SendCourseMaterials(Group group, string materials);
    }
}