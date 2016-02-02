using System;
using System.Collections.Generic;

namespace Assignment_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // create three students
            Student[] students = new Student[3]
            {
                new Student("John", "Doe", "1/1/1900"),
                new Student("Sally", "Jones", "2/21/1951"),
                new Student("Bob", "Smith", "9/2/2001")
            };

            // create course, add students to it, and add 5 grades for each student
            Course progWithCSharp = new Course("Programming with C#");
            for (int i = 0; i < students.Length; i++)
            {
                progWithCSharp.Students.Add(students[i]);
                for (int j = 0; j < 5; j++)
                {
                    students[i].Grades.Push(j * 10 + 50);
                }
            }

            // create a teacher and add it to the course
            Teacher teacherA = new Teacher("Paul", "Burns", "10/10/1975");
            progWithCSharp.Teachers.Add(teacherA);

            // create a degree and add the course to it
            Degree bachelor = new Degree("Bachelor of Science");
            bachelor.Courses.Add(progWithCSharp);

            // create a program and add a degree to it
            UProgram informationTechnology = new UProgram("Information Technology");
            informationTechnology.Degrees.Add(bachelor);

            // print program, degree, and course information
            Console.WriteLine(informationTechnology);
            Console.WriteLine(bachelor);
            Console.WriteLine(progWithCSharp);
            Console.WriteLine("\n");

            // print list of students in the course.
            Console.WriteLine("Student Names in Programming with C#");
            progWithCSharp.ListStudents();
            Console.WriteLine("\n");
        }
    }

    class UProgram
    {
        #region Properties
        public string Name { set; get; }
        public string DeptHead { set; get; }

        public List<Degree> Degrees { set; get; }
        #endregion

        #region Constructors
        public UProgram(string name, string deptHead = "")
        {
            Name = name;
            DeptHead = deptHead;

            Degrees = new List<Degree>();
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            string toPrint = "Program: " + Name + "\nDegrees Offered:\n";
            foreach (Degree degree in Degrees)
            {
                toPrint += "\t" + degree.Name + "\n";
            }
            return toPrint;
        }
        #endregion
    }

    class Degree
    {
        #region Properties
        public string Name { set; get; }
        public double Credits { set; get; }

        public List<Course> Courses { set; get; }
        #endregion        

        #region Constructors
        public Degree(string name, double credits = 0)
        {
            Name = name;
            Credits = credits;

            Courses = new List<Course>();
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            string toPrint = "Degree: " + Name + "\nRequired Courses to Earn Degree:\n";
            foreach (Course course in Courses)
            {
                toPrint += "\t" + course.Name + "\n";
            }
            return toPrint;
        }
        #endregion
    }

    class Course
    {
        #region Properties
        public string Name { set; get; }
        public double Credits { set; get; }
        public int Duration { set; get; }

        public List<Student> Students { set; get; }
        public List<Teacher> Teachers { set; get; }
        #endregion

        #region Constructors
        public Course(string name, double credits = 0, int duration = 0)
        {
            Name = name;
            Credits = credits;
            Duration = duration;

            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }
        #endregion

        #region Methods
        public void ListStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return "Course: " + Name + "\n\tStudents Enrolled: " + Student.StudentsEnrolled;
        }
        #endregion
    }

    class Person
    {
        #region Properties
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Birthday { set; get; }
        public string AddrLine1 { set; get; }
        public string AddrLine2 { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string Zipcode { set; get; }
        public string Country { set; get; }
        #endregion

        #region Constructors
        public Person()
        {

        }

        public Person(string firstName, string lastName, string birthday,
                string addrLine1 = "", string addrLine2 = "", string city = "", string state = "", string zipcode = "", string country = "")
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            AddrLine1 = addrLine1;
            AddrLine2 = addrLine2;
            City = city;
            State = state;
            Zipcode = zipcode;
            Country = country;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            string[] titles =
            {
                    "First Name: ",
                    "Last Name: ",
                    "Birthdate: ",
                    "Address (line 1): ",
                    "Address (line 2): ",
                    "City: ",
                    "State/Province: ",
                    "Zip/Postal Code: ",
                    "Country: "
                };

            string[] data =
            {
                    FirstName,
                    LastName,
                    Birthday,
                    AddrLine1,
                    AddrLine2,
                    City,
                    State,
                    Zipcode,
                    Country
                };

            string toPrint = "";

            for (int i = 0; i < titles.Length; i++)
            {
                toPrint += titles[i] + data[i] + "\n";
            }

            return toPrint;
        }
        #endregion
    }

    class Student : Person
    {
        #region Properties
        public static int StudentsEnrolled { set; get; }
        public Stack<decimal> Grades { set; get; }
        #endregion

        #region Constructors
        public Student(string firstName, string lastName, string birthday, string addrLine1 = "",
            string addrLine2 = "", string city = "", string state = "", string zipcode = "", string country = "") : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            AddrLine1 = addrLine1;
            AddrLine2 = addrLine2;
            City = city;
            State = state;
            Zipcode = zipcode;
            Country = country;

            StudentsEnrolled++;

            Grades = new Stack<decimal>();
        }
        #endregion

        #region Methods
        public void TakeTest()
        {
            Console.WriteLine("Student is taking a test.");
        }
        #endregion
    }

    class Teacher : Person
    {
        #region Constructors
        public Teacher(string firstName, string lastName, string birthday, string addrLine1 = "",
            string addrLine2 = "", string city = "", string state = "", string zipcode = "", string country = "") : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            AddrLine1 = addrLine1;
            AddrLine2 = addrLine2;
            City = city;
            State = state;
            Zipcode = zipcode;
            Country = country;
        }
        #endregion

        #region Methods
        public void GradeTest()
        {
            Console.WriteLine("Teacher is grading a test.");
        }
        #endregion
    }
}
