namespace WinFormsUI
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitIDbtn = new System.Windows.Forms.Button();
            this.erlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(316, 212);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(118, 23);
            this.txtBoxID.TabIndex = 0;
            this.txtBoxID.TextChanged += new System.EventHandler(this.IDInputBoxNumbers_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(176, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Schedule maker!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please enter your 8-digit BadgerID";
            // 
            // SubmitIDbtn
            // 
            this.SubmitIDbtn.Location = new System.Drawing.Point(440, 212);
            this.SubmitIDbtn.Name = "SubmitIDbtn";
            this.SubmitIDbtn.Size = new System.Drawing.Size(62, 23);
            this.SubmitIDbtn.TabIndex = 3;
            this.SubmitIDbtn.Text = "Go!";
            this.SubmitIDbtn.UseVisualStyleBackColor = true;
            this.SubmitIDbtn.Click += new System.EventHandler(this.SubmitIDbtn_Click);
            // 
            // erlbl
            // 
            this.erlbl.Location = new System.Drawing.Point(294, 238);
            this.erlbl.Name = "erlbl";
            this.erlbl.Size = new System.Drawing.Size(197, 67);
            this.erlbl.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit Program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.erlbl);
            this.Controls.Add(this.SubmitIDbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxID);
            this.Name = "LoginScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Button SubmitIDbtn;
        public TextBox txtBoxID;
        private Label erlbl;
        private Button button1;
    }
}