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

            txtbxSchedule.Text = DataMan.courseList.ToString();

            
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
