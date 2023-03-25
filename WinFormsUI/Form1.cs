using FinalProject;

namespace WinFormsUI
{
    /// <summary>
    /// The Windows forms UI of my final project in 2022
    /// </summary>
    public partial class Form1 : Form
    {
        static Student newStudent;
        static string ID;

        public Form1()
        {
            InitializeComponent();
            newStudent = new Student(ID);
            CSVDataManagement data = new();
            data.LoadCourses("0", Path.Combine(Directory.GetCurrentDirectory(), $"Courses/0.txt"));

            while (true)
            {
                if (File.Exists(Path.Combine("Courses", $"{ID}.txt")))
                {
                    data.LoadCourses(ID, Path.Combine("Courses", $"{ID}.txt"));
                    int input = 2; //select what you wanna do next
                    switch (input)
                    {
                        case 1:
                            //form that show schedule
                            continue;
                        case 2:
                            //form where you can add to your schedule
                            break;
                        case 3:
                            File.WriteAllText(Path.Combine("Courses", $"{ID}.txt"), string.Empty);
                            File.Delete(Path.Combine("Courses", $"{ID}.txt"));
                            CSVDataManagement.courseDict.Clear();
                            CSVDataManagement.courseList.Clear();
                            //form where you can make your schedule again
                            break;
                        case 0:
                            return;
                    }
                }
                else
                {
                    //show the schedule
                }
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
            ID = txtBoxID.Text;
            Form form2 = new();
            form2.ShowDialog();
        }

        
    }
}