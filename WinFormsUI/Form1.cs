using FinalProject;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        internal static string ID;

        public Form1()
        {
            InitializeComponent();
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
        }

        
    }
}