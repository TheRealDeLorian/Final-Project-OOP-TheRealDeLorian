using FinalProject;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsUI
{
    /// <summary>
    /// The Windows forms UI of my final project in 2022
    /// </summary>
    public partial class LoginScreen : Form
    {
        static Student newStudent;
        static string ID;
        string dir = $"{Directory.GetCurrentDirectory()}\\..\\..\\..\\";

        public LoginScreen()
        {
            InitializeComponent();
            newStudent = new Student();
            //MessageBox.Show(dir);
            //initializes master schedule
            if (File.Exists($"{dir}\\Courses\\0.txt"))
            {
                DataMan.LoadCourses("0", $"{dir}/Courses/0.txt"); //Path.Combine(Directory.GetCurrentDirectory(), 
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IDInputBoxNumbers_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitIDbtn_Click(object sender, EventArgs e)
        {
            if (txtBoxID.Text == "0" || txtBoxID.Text.Length == 8)
            {
                ID = txtBoxID.Text;
                Student.studentID = txtBoxID.Text;
                if (!File.Exists($"{dir}/Courses/{ID}.txt"))
                {
                    FileStream fs = File.Create($"{dir}/Courses/{ID}.txt");
                    fs.Close();
                }
                DataMan.LoadCourses(ID, $"{dir}/Courses/{ID}.txt");
                ScheduleMenu f2 = new();
                f2.ShowDialog();
            }
            else
            {
                erlbl.Text = "Please enter a valid student ID.";
            }
            txtBoxID.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}