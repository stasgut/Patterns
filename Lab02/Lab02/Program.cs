using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student created
            Student student1 = new Student();
            student1.address = "Prospect Svobodi";
            student1.email = "stanislav.hut@lnu.edu.ua";
            student1.name = "Stanislav";
            student1.phone_number = "063-222-2222";
            student1.student_number = "№111";

            //Professor created
            Professor Robin = new Professor();
            Robin.name = "Robin";
            Robin.email = "RobinTeatcher@gmail.com";
            Robin.address = "Svobody 22";
            Robin.phone_number = "063-222-2222";
            Robin.salary = 415;
            
            //Course created
            Course webUI = new Course(Robin);
            webUI.date = (DateTime.Now);
            webUI.fee = "30";
            webUI.seminars_numbers = "№3";
            webUI.name = "Web UI course";
            webUI.start_date = DateTime.Today;
            
            
            Course course = new Course(professor:Robin);
            student1.Enroll(webUI);
            course.AddStudent(student1);
        }
    }
}