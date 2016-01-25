using System;

namespace Assignment_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentA = new Student("John", "Doe", "1/1/1900");
            Student studentB = new Student("Sally", "Jones", "2/21/1951");
            Student studentC = new Student("Bob", "Smith", "9/2/2001");

            Course progWithCSharp = new Course("Programming with C#");
            progWithCSharp.AddStudent(studentA);
            progWithCSharp.AddStudent(studentB);
            progWithCSharp.AddStudent(studentC);

            Teacher teacherA = new Teacher("Paul", "Burns", "10/10/1975");
            progWithCSharp.AddTeacher(teacherA);

            Degree bachelor = new Degree("Bachelor of Science");
            bachelor.AddCourse(progWithCSharp);

            UProgram informationTechnology = new UProgram("Information Technology");
            informationTechnology.AddDegree(bachelor);

            Console.WriteLine(informationTechnology);
            Console.WriteLine(bachelor);
            Console.WriteLine(progWithCSharp);
            Console.WriteLine("\n");
        }
    }

    class UProgram
    {
        #region Properties
        public string Name { set; get; }
        public string DeptHead { set; get; }
        #endregion

        private int degCnt = 0;
        private Degree[] degrees;

        #region Constructors
        public UProgram(string name, string deptHead = "")
        {
            Name = name;
            DeptHead = deptHead;
        }
        #endregion

        #region Methods
        public void AddDegree(Degree degree)
        {
            Degree[] tmpDeg;

            if (degCnt < 1)
            {
                degCnt++;
                degrees = new Degree[degCnt];
                degrees[0] = degree;
            }
            else
            {
                degCnt++;
                tmpDeg = new Degree[degCnt];
                for(int i = 0; i < degCnt - 1; i++)
                {
                    tmpDeg[i] = degrees[i];
                }
                tmpDeg[degCnt - 1] = degree;               
                degrees = new Degree[degCnt];
                degrees = tmpDeg;
            }            
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            string toPrint = "Program: " + Name + "\nDegrees Offered:\n";
            for(int i = 0; i < degCnt; i++)
            {
                toPrint += "\t" + degrees[i].Name + "\n";
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
        #endregion

        private int courseCnt = 0;
        private Course[] courses;

        #region Constructors
        public Degree(string name, double credits = 0)
        {
            Name = name;
            Credits = credits;
        }
        #endregion

        #region Methods
        public void AddCourse(Course course)
        {
            Course[] tmpCourse;

            if (courseCnt < 1)
            {
                courseCnt++;
                courses = new Course[courseCnt];
                courses[0] = course;
            }
            else
            {
                courseCnt++;
                tmpCourse = new Course[courseCnt];
                for (int i = 0; i < courseCnt - 1; i++)
                {
                    tmpCourse[i] = courses[i];
                }
                tmpCourse[courseCnt - 1] = course;
                courses = new Course[courseCnt];
                courses = tmpCourse;
            }
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            string toPrint = "Degree: " + Name + "\nRequired Courses to Earn Degree:\n";
            for (int i = 0; i < courseCnt; i++)
            {
                toPrint += "\t" + courses[i].Name + "\n";
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
        public string Teacher { set; get; }
        #endregion

        private int studentCnt = 0;
        private int teacherCnt = 0;
        private Student[] students;        
        private Teacher[] teachers;

        #region Constructors
        public Course(string name, double credits = 0, int duration = 0, string teacher = "")
        {
            Name = name;
            Credits = credits;
            Duration = duration;
            Teacher = teacher;
        }
        #endregion

        #region Methods
        public void AddStudent(Student student)
        {
            Student[] tmpStudents;

            if (studentCnt < 1)
            {
                studentCnt++;
                students = new Student[studentCnt];
                students[0] = student;
            }
            else
            {
                studentCnt++;
                tmpStudents = new Student[studentCnt];
                for (int i = 0; i < studentCnt - 1; i++)
                {
                    tmpStudents[i] = students[i];
                }
                tmpStudents[studentCnt - 1] = student;
                students = new Student[studentCnt];
                students = tmpStudents;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            Teacher[] tmpTeachers;

            if (teacherCnt < 1)
            {
                teacherCnt++;
                teachers = new Teacher[teacherCnt];
                teachers[0] = teacher;
            }
            else
            {
                teacherCnt++;
                tmpTeachers = new Teacher[teacherCnt];
                for (int i = 0; i < teacherCnt - 1; i++)
                {
                    tmpTeachers[i] = teachers[i];
                }
                tmpTeachers[teacherCnt - 1] = teacher;
                teachers = new Teacher[teacherCnt];
                teachers = tmpTeachers;
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

        #region Methods

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
        private static int _studentsEnrolled = 0;
        public static int StudentsEnrolled { set; get; }

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
        }
}

    class Teacher : Person
    {
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
    }
}
