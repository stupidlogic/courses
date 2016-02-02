using System.Collections.Generic;
using System.Windows;
using System;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> Students { get; set; }

        private static int currentStudent = 0;

        public MainWindow()
        {
            Students = new List<Student>();

            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();

            // set student information
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.City = txtCity.Text;

            // add student to list
            Students.Add(student);

            // clear text boxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();

            // reset list location
            currentStudent = 0;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PopulateStudentText(Students[currentStudent]);
                currentStudent--;
                if (currentStudent < 0)
                {
                    currentStudent = Students.Count - 1;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No students in list.");
            }            
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PopulateStudentText(Students[currentStudent]);
                currentStudent++;
                if (currentStudent > Students.Count - 1)
                {
                    currentStudent = 0;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No students in list.");
            }            
        }

        private void PopulateStudentText(Student student)
        {
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCity.Text = student.City;
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }        

        public Student()
        {

        }
    }
}
