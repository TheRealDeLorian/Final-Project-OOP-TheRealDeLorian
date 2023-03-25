using FinalProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsUI
{
    public partial class ScheduleMenu : Form //Form 2 displays schedule
    {
        string ID;
        public ScheduleMenu()
        {
            InitializeComponent();
            ID = Student.studentID;

            txtbxSchedule.Text = PrintSchedule();


        }

        public string PrintSchedule()
        {
            string courseInfo = "";
            foreach (Course course in DataMan.courseList)
            {
                string days = "";
                foreach (string day in course.Days)
                {
                    days = days + $"{day}, ";
                }
                courseInfo = courseInfo +

                    $"Course Name: {course.CourseName}\r\n" +
                    $"CRN: {course.CRN}\r\n" +
                    $"Days offered: {days}\r\n" +
                    $"from {course.TimeStart} to {course.TimeEnd}\r\n" +
                    $"Description: {course.Description}\r\n" +
                    "\r\n"; //to seperate the courses
            }
            return courseInfo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void txtbxSchedule_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //erases everything 
        {

            File.WriteAllText(Path.Combine("Courses", $"{ID}.txt"), string.Empty);
            File.Delete(Path.Combine("Courses", $"{ID}.txt"));
            DataMan.courseDict.Clear();
            DataMan.courseList.Clear();

        }
    }
}
