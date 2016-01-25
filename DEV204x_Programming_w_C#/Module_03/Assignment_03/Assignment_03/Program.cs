using System;

namespace Assignment_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string firstName = "";
            string lastName = "";
            string birthday = "";
            string addrLine1 = "";
            string addrLine2 = "";
            string city = "";
            string state = "";
            string zipcode = "";
            string country = "";

            string programName = "";
            string deptHead = "";
            string degrees = "";

            string degreeName = "";
            string degreeCredits = "";

            string courseName = "";
            string courseCredits = "";
            string duration = "";
            string teacher = "";
            #endregion

            // student info
            GetStudentInformation(out firstName, out lastName, out birthday, 
                out addrLine1, out addrLine2, out city, out state, out zipcode, out country);
            PrintStudentDetails(firstName, lastName, birthday);

            // teacher info
            GetTeacherInformation(out firstName, out lastName, out birthday,
                out addrLine1, out addrLine2, out city, out state, out zipcode, out country);
            PrintTeacherDetails(firstName, lastName, birthday);

            // uprogram
            GetUProgramInformation(out programName, out deptHead, out degrees);
            PrintUProgramDetails(programName, deptHead, degrees);

            // degree
            GetDegreeInformation(out degreeName, out degreeCredits);
            PrintDegreeDetails(degreeName, degreeCredits);

            // course
            GetCourseInformation(out courseName, out courseCredits, out duration, out teacher);
            PrintCourseDetails(courseName, courseCredits, duration, teacher);

            // birthday, exception test
            ValidateBirthday(birthday);
        }

        #region Person
        static void GetStudentInformation(out string firstName, out string lastName, out string birthday,
            out string addrLine1, out string addrLine2, out string city, out string state, out string zipcode, out string country)
        {
            GetPersonInformation("student", out firstName, out lastName, out birthday,
                out addrLine1, out addrLine2, out city, out state, out zipcode, out country);
        }

        static void GetTeacherInformation(out string firstName, out string lastName, out string birthday,
            out string addrLine1, out string addrLine2, out string city, out string state, out string zipcode, out string country)
        {
            GetPersonInformation("teacher", out firstName, out lastName, out birthday,
                out addrLine1, out addrLine2, out city, out state, out zipcode, out country);
        }

        static void GetPersonInformation(string personType, out string firstName, out string lastName, out string birthday,
            out string addrLine1, out string addrLine2, out string city, out string state, out string zipcode, out string country)
        {
            Console.WriteLine("Enter the {0}'s first name: ", personType);
            firstName = Console.ReadLine();

            Console.WriteLine("Enter the {0}'s last name: ", personType);
            lastName = Console.ReadLine();

            Console.WriteLine("Enter the {0}'s birth date: ", personType);
            birthday = Console.ReadLine();

            Console.WriteLine("Enter the {0}'s address (line 1): ", personType);
            addrLine1 = Console.ReadLine();

            Console.WriteLine("Enter the {0}'s address (line 2): ", personType);
            addrLine2 = Console.ReadLine();

            Console.WriteLine("Enter the {0}'s city: ", personType);
            city = Console.ReadLine();

            Console.WriteLine("Enter the {0}'s state/province: ", personType);
            state = Console.ReadLine();

            Console.WriteLine("Enter the {0}'s zip/postal code: ", personType);
            zipcode = Console.ReadLine();

            Console.WriteLine("Enter the {0}'s country: ", personType);
            country = Console.ReadLine();
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            PrintPersonDetails(first, last, birthday);
        }

        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            PrintPersonDetails(first, last, birthday);
        }

        static void PrintPersonDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}\n", first, last, birthday);
        }

        static void ValidateBirthday(string birthday)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region UProgram
        static void GetUProgramInformation(out string programName, out string deptHead, out string degrees)
        {
            Console.WriteLine("Enter the program name: ");
            programName = Console.ReadLine();

            Console.WriteLine("Enter the department head: ");
            deptHead = Console.ReadLine();

            Console.WriteLine("Enter the degrees: ");
            degrees = Console.ReadLine();
        }

        static void PrintUProgramDetails(string name, string deptHead, string degrees)
        {
            Console.WriteLine("Program Name: {0}\nDepartment Head: {1}\nDegrees: {2}\n", name, deptHead, degrees);
        }

        #endregion

        #region Degree
        static void GetDegreeInformation(out string degreeName, out string degreeCredits)
        {
            Console.WriteLine("Enter the degree name: ");
            degreeName = Console.ReadLine();

            Console.WriteLine("Enter the credits required: ");
            degreeCredits = Console.ReadLine();
        }

        static void PrintDegreeDetails(string name, string credits)
        {
            Console.WriteLine("Degree Name: {0}\nCredits: {1}\n", name, credits);
        }

        #endregion

        #region Course
        static void GetCourseInformation(out string courseName, out string courseCredits, out string duration, out string teacherName)
        {
            Console.WriteLine("Enter the course name: ");
            courseName = Console.ReadLine();

            Console.WriteLine("Enter the credits: ");
            courseCredits = Console.ReadLine();

            Console.WriteLine("Enter the duration in weeks: ");
            duration = Console.ReadLine();

            Console.WriteLine("Enter the teacher's name: ");
            teacherName = Console.ReadLine();
        }

        static void PrintCourseDetails(string name, string credits, string duration, string teacherName)
        {
            Console.WriteLine("Course Name: {0}\nCredits: {1}\nDuration: {2}\nTeacher Name: {3}\n", name, credits, duration, teacherName);
        }

        #endregion


    }
}
