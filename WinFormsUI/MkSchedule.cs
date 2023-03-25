using FinalProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class MkSchedule : Form
    {
        List<string> addedCourses = new();
        Student newStudent = new();
        public MkSchedule()
        {
            InitializeComponent();
            //read master schedule
            //each class is a check box
            //check the ones you want
            //save to file
            txtBoxSchedule.Text = ScheduleMenu.PrintMasterSchedule();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MkSchedule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input;

            try
            {
                input = int.Parse(textBox1.Text);
            }
            catch 
            { 
                label3.Text = "Please only input a 4-digit number.";
                return;
            }
            try
            {
                Student.AddCourse(DataMan.masterDict[input]); //takes a course already saved to masterdict and places it also in newStudent.AddCourse
                DataMan.courseDict.Add(input, DataMan.masterDict[input]);
                label3.Text = "Course added successfully.";
            }
            catch
            {
                label3.Text = "Oops! Something went wrong. Please enter a valid CRN.";
            }
            //save course according to CRN in the textbox
            //label 3 displays confirmation msg

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataMan.SaveCourses(Student.studentSchedule, Student.studentID);
            ScheduleMenu.instance.PrintSchedule();
            Close();
        }
    }
}
