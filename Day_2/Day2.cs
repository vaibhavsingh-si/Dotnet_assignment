using System;
using System.Collections.Generic;

namespace StudentRecordManagement
{
    class Student
    {
        private string name;
        private int age;
        private string gender;
        private string studentID;
        private List<string> courseEnrollment = new List<string>();
        private double gpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public List<string> CourseEnrollment
        {
            get { return courseEnrollment; }
            set { courseEnrollment = value; }
        }

        public double GPA
        {
            get { return CalculateGPA(); }
        }

        private double CalculateGPA()
        {
            double totalGradePoints = 0;
            foreach (string course in courseEnrollment)
            {
                // Calculate grade points based on course grades (A=4, B=3, C=2, D=1, F=0)
                // Assuming course grades are stored in another data structure
                // Add the respective grade points to totalGradePoints
            }

            return totalGradePoints / courseEnrollment.Count;
        }
    }

    class School
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayStudents()
        {
            Console.WriteLine("Student List:");
            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}, ID: {student.StudentID}");
            }
        }

        public double CalculateOverallGPA()
        {
            double totalGPA = 0;
            foreach (Student student in students)
            {
                totalGPA += student.GPA;
            }

            return totalGPA / students.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            // Allow user interaction to add students, display student list, and calculate overall GPA
            // You can use Console.ReadLine and Console.WriteLine here

            // Example usage
            Student student1 = new Student();
            student1.Name = "John Doe";
            student1.Age = 18;
            student1.Gender = "Male";
            student1.StudentID = "12345";
            student1.CourseEnrollment = new List<string> { "Math", "English" };

            school.AddStudent(student1);
            school.DisplayStudents();
            Console.WriteLine($"Overall GPA: {school.CalculateOverallGPA():F2}");
        }
    }
}
