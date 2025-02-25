
// Task 8: School System
// Task: Create a School Management System with:
// Student class (Name, Age, Grade).
// Teacher class (Name, Subject, YearsOfExperience).
// School class that stores students & teachers in an array.
// Show students with the highest grade and teachers with less than 2 years experience.

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

}

class Teacher {
    public string Name {get; set;}
    public string Subject {get; set;}
    public int YearsOfExperience {get; set;}

    public Teacher (string name, string subject, int yearsofexperience) {
        Name = name;
        Subject = subject;
        YearsOfExperience = yearsofexperience;
    }
}

class School {

    private Student[] Students;
    private Teacher[] Teachers;

    public School (Student[] students, Teacher[] teachers) {
        Students = students;
        Teachers = teachers;
    }
    public void HigtestGradeStudents () {
        int max = Students[0].Grade;
        int j  = 0;
        for (int i = 1; i < Students.Length; ++i) {
            if (max < Students[i].Grade) {
                max = Students[i].Grade;
                j = i;
            }
        }
        Console.WriteLine ($"\nThe max Grade is {max} Student Name: {Students[j].Name}");
    }


    public void TeachersWithLessExperience () {
        for (int i = 0; i < Teachers.Length; ++i) {
            if (Teachers[i].YearsOfExperience < 2) {
                Console.WriteLine ("Teachers with Less Than 2 Years of Experience: " + Teachers[i].Name);
            }
        }
    }
}

class Program {
    static void Main (string[] args) {

        Student[] Students = new Student[]
        {
            new Student("Alice", 15, 95),
            new Student("Bob", 16, 88),
            new Student("Charlie", 15, 95), // Another highest-grade student
            new Student("David", 14, 92),
            new Student("Eve", 17, 89)
        };

        Teacher[] Teachers = new Teacher[]
        {
            new Teacher("Mr. Smith", "Math", 5),
            new Teacher("Ms. Johnson", "Science", 1), // Less than 2 years experience
            new Teacher("Mr. Brown", "History", 10),
            new Teacher("Ms. Wilson", "English", 0) // Less than 2 years experience
        };

        School mySchool = new School(Students, Teachers);

        mySchool.HigtestGradeStudents();
        mySchool.TeachersWithLessExperience();

    }

    
}