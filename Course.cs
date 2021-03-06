using System;
using System.Collections.Generic;

namespace Lab01
{
    public class Course
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public DateTime start_date { get; set; }
        public string seminars_numbers { get; set; }
        public string fee { get; set; }


        //Association
        private Professor _professor;
        public Course(Professor professor)
        {
            _professor = professor; 
        }
        
        
        private List<Student> _students = new List<Student>();

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }
    }
}