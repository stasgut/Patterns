using System;

namespace Lab02
{
    public class Calculus : Course
    {
        public Calculus(Professor professor) : base(professor)
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
            Console.WriteLine($"Group {group} will be studying by next course: {materials}");
        }
    }
}