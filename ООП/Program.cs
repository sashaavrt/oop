using System;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Student:Person
{
    public string Major { get; set; }

    public Student(string name, int age, string major) : base(name, age)
    {
        Major = major;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student - Name: {Name}, Age: {Age}, Major: {Major}");
    }
}

class Teacher : Person
{
    public string Subject {  get; set; }

    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;  
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Teacher - Name: {Name}, Age: {Age}, Subject: {Subject}");
    }
}
    
