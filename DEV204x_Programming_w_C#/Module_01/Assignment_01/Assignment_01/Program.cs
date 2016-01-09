using System;

namespace Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // student info
            string firstName = "John";
            string lastName = "Doe";
            string birthdate = "1/1/1950";
            string address1 = "123 Sunset Road";
            string address2 = "Apt 103";
            string city = "Blaine";
            string state_province = "MN";
            int zip = 55432;
            string country = "United States";

            // degree info
            string degree_name = "M.S.E.E.";
            float credits_req = 60.0f;

            // course info
            string course_name = "DEV204x";
            float credits = 1.0f;
            int duration_wks = 15;

            // print info
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthdate);
            Console.WriteLine(address1);
            Console.WriteLine(address2);
            Console.WriteLine(city);
            Console.WriteLine(state_province);
            Console.WriteLine(zip);
            Console.WriteLine(country);
            Console.WriteLine(degree_name);
            Console.WriteLine(credits_req);
            Console.WriteLine(course_name);
            Console.WriteLine(credits);
            Console.WriteLine(duration_wks);
        }
    }
}
