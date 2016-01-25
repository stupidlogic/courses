using System;

namespace Assignment_04
{
    class Program
    {
        #region Struct Definitions
        struct Student
        {
            public string firstName;
            public string lastName;
            public string birthday;
            public string addrLine1;
            public string addrLine2;
            public string city;
            public string state;
            public string zipcode;
            public string country;

            public Student(string firstName, string lastName, string birthday,
                string addrLine1 = "", string addrLine2 = "", string city = "", string state = "", string zipcode = "", string country = "")
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthday = birthday;
                this.addrLine1 = addrLine1;
                this.addrLine2 = addrLine2;
                this.city = city;
                this.state = state;
                this.zipcode = zipcode;
                this.country = country;
            }

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
                    firstName,
                    lastName,
                    birthday,
                    addrLine1,
                    addrLine2,
                    city,
                    state,
                    zipcode,
                    country
                };

                string toPrint = "" ;

                for(int i = 0; i < titles.Length; i++)
                {
                    toPrint += titles[i] + data[i] + "\n";                
                }

                return toPrint;
            }
        }

        struct Teacher
        {
            public string firstName;
            public string lastName;
            public string birthday;
            public string addrLine1;
            public string addrLine2;
            public string city;
            public string state;
            public string zipcode;
            public string country;

            public Teacher(string firstName, string lastName, string birthday,
                string addrLine1 = "", string addrLine2 = "", string city = "", string state = "", string zipcode = "", string country = "")
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthday = birthday;
                this.addrLine1 = addrLine1;
                this.addrLine2 = addrLine2;
                this.city = city;
                this.state = state;
                this.zipcode = zipcode;
                this.country = country;
            }

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
                    firstName,
                    lastName,
                    birthday,
                    addrLine1,
                    addrLine2,
                    city,
                    state,
                    zipcode,
                    country
                };

                string toPrint = "";

                for (int i = 0; i < titles.Length; i++)
                {
                    toPrint += titles[i] + data[i] + "\n";
                }

                return toPrint;
            }
        }

        struct UProgram
        {
            public string programName;
            public string deptHead;
            public string degrees;

            public UProgram(string programName, string deptHead = "", string degrees = "")
            {
                this.programName = programName;
                this.deptHead = deptHead;
                this.degrees = degrees;
            }
        }

        struct Degree
        {
            public string degreeName;
            public string degreeCredits;

            public Degree(string degreeName, string degreeCredits)
            {
                this.degreeName = degreeName;
                this.degreeCredits = degreeCredits;
            }
        }

        struct Course
        {
            public string courseName;
            public string courseCredits;
            public string duration;
            public string teacher;

            public Course(string courseName, string courseCredits, string duration = "", string teacher = "")
            {
                this.courseName = courseName;
                this.courseCredits = courseCredits;
                this.duration = duration;
                this.teacher = teacher;
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Student[] students = new Student[1];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Pleased enther the following information for the student:\n");

                Console.WriteLine("First Name: ");
                students[i].firstName = Console.ReadLine();

                Console.WriteLine("Last Name: ");
                students[i].lastName = Console.ReadLine();

                Console.WriteLine("Birthdate: ");
                students[i].birthday = Console.ReadLine();

                Console.WriteLine("Address (line 1): ");
                students[i].addrLine1 = Console.ReadLine();

                Console.WriteLine("Address (line 2): ");
                students[i].addrLine2 = Console.ReadLine();

                Console.WriteLine("City: ");
                students[i].city = Console.ReadLine();

                Console.WriteLine("State/Province: ");
                students[i].state = Console.ReadLine();

                Console.WriteLine("Zip/Postal Code: ");
                students[i].zipcode = Console.ReadLine();

                Console.WriteLine("Country: ");
                students[i].country = Console.ReadLine();
            }

            Console.WriteLine("\n");
            Console.WriteLine(students[0]);
        }
    }
}