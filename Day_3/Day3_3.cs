using System;

namespace StudentGradingSystem
{
    class Student
    {
        public string Name { get; }
        private double[] grades;

        public Student(string name, int numberOfGrades)
        {
            Name = name;
            grades = new double[numberOfGrades];
        }

        public void EnterGrades()
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        grades[i] = grade;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Grade must be between 0 and 100.");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a numeric value.");
                    i--;
                }
            }
        }

        public double CalculateAverageGrade()
        {
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grading System");
            Console.WriteLine("----------------------");

            Console.Write("Enter the name of the student: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter the number of grades to be entered: ");
            int numberOfGrades;
            if (!int.TryParse(Console.ReadLine(), out numberOfGrades) || numberOfGrades <= 0)
            {
                Console.WriteLine("Invalid input! Number of grades must be a positive integer.");
                return;
            }

            Student student = new Student(studentName, numberOfGrades);
            student.EnterGrades();

            Console.WriteLine();
            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Grades: {string.Join(", ", student.CalculateAverageGrade())}");
            Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}");
        }
    }
}
using System;

namespace StudentGradingSystem
{
    class Student
    {
        public string Name { get; }
        private double[] grades;

        public Student(string name, int numberOfGrades)
        {
            Name = name;
            grades = new double[numberOfGrades];
        }

        public void EnterGrades()
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        grades[i] = grade;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Grade must be between 0 and 100.");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a numeric value.");
                    i--;
                }
            }
        }

        public double CalculateAverageGrade()
        {
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grading System");
            Console.WriteLine("----------------------");

            Console.Write("Enter the name of the student: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter the number of grades to be entered: ");
            int numberOfGrades;
            if (!int.TryParse(Console.ReadLine(), out numberOfGrades) || numberOfGrades <= 0)
            {
                Console.WriteLine("Invalid input! Number of grades must be a positive integer.");
                return;
            }

            Student student = new Student(studentName, numberOfGrades);
            student.EnterGrades();

            Console.WriteLine();
            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Grades: {string.Join(", ", student.CalculateAverageGrade())}");
            Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}");
        }
    }
}
