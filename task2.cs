// Task 2: Student Management
// Task: Create a Student class with:
// Name, Age, and Grade properties.
// A DisplayDetails() method.
// In Main(), create 5 students, store them in an array, and display their details.

using System;

class Student {
    public string Name {get; set;}
    public int Age {get; set;}
    public int Grade {get; set;}

    public Student (string name, int age, int grade) {
        Name = name;
        Age = age;
        Grade = grade;
    }
    public void DisplayDetails (Student obj) {
        Console.WriteLine ($"Name: {obj.Name}\nAge: {obj.Age}\nGrade: {obj.Grade}");
    } 

}

class Program {
    static void Main (string[] args) {
    
    Student[] students = new Student [5]; 

    for (int i = 0; i < students.Length; ++i) {
        Console.Write ("Please Enter the student's Name ");
        string name = Console.ReadLine ();
        Console.Write ("Please Enter the student's Age ");
        int age = int.Parse (Console.ReadLine());
        Console.Write ("Please Enter the student's Grade ");
        int grade = int.Parse (Console.ReadLine ());
        students[i] = new Student (name, age, grade);
        Console.WriteLine ();  
    }
    Console.WriteLine ();
    for (int i = 0; i < students.Length; ++i) {
        students[i].DisplayDetails (students[i]);
        Console.WriteLine ("--------------------");
    }


    }
}
