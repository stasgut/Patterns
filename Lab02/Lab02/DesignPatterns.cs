﻿namespace Lab02
{
    public class DesignPattern : Course
    {
        public DesignPattern(Professor professor) : base(professor)
        {
        }

        public override void AddStudent(Student student)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveStudent(Student student)
        {
            throw new System.NotImplementedException();
        }

        public override void SendCourseMaterials(Group group, string materials)
        {
            throw new System.NotImplementedException();
        }
    }
}