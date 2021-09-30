using System;

namespace Lab01
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
            Course WebUI = new Course(Robin);
            WebUI.date = (DateTime.Now);
            WebUI.fee = "30";
            WebUI.seminars_numbers = "№3";
            WebUI.name = "Web UI course";
            WebUI.start_date = DateTime.Today;
            
            
            Course course = new Course(professor:Robin);
            course.AddStudent(student1);
        }
    }
}