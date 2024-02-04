using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        College college = new College();
        Student newStudent = new Student("Sasha Averina", 20, "Computer Science");
        college.RegisterStudent(newStudent);

        Course programmingCourse = new Course("Programming 101", "Introduction to programming");
        college.AssignStudentToCourse(newStudent, programmingCourse);
       

        Teacher newTeacher = new Teacher("Prof. Smith", 35, "Computer Sciense");
        college.AssignTeacherToCourse(newTeacher, programmingCourse);

        Console.WriteLine("Registered Students");
        college.GetRegisteredStudents(newStudent);
        Console.WriteLine("\nRegistered Teachers");
        college.GetRegisteredTeachers(newTeacher);
        Console.WriteLine("\nAvailable Courses");
        
       
    }
}