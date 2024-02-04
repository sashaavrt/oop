using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Course
{
    public string Name { get; set; }
    public string Description {  get; set; }
    public Course(string name, string description)
    {
        Name = name;
        Description = description;
    }
    private List<Course> courses = new List<Course>();
    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public void AvailableCourses(Course course)
    {
        foreach (var co in courses)
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}");
        }

    }
}

class College
{
    private List<Student> students = new List<Student>();
    private List<Student> EnrolledStudents = new List<Student>();
    private List<Teacher> teachers = new List<Teacher>();


    public void RegisterStudent(Student student)
    {
        students.Add(student);
    }
    public void AssignStudentToCourse(Student student, Course course) 
    {
        EnrolledStudents.Add(student);
    }

    public void AssignTeacherToCourse(Teacher teacher, Course course)
    {
        teachers.Add(teacher);
    }

    public void GetRegisteredStudents(Student student)
    {
        foreach (var st in students) {
            st.DisplayInfo();
        }
       
    }
    public void GetRegisteredTeachers(Teacher teacher)
    {
        foreach (var te in teachers)
        {
            te.DisplayInfo();
        }

    }
}