namespace WinFormsUI
{
    partial class ScheduleMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxSchedule = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, student! Here\'s what your schedule looks like for this semester:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(184, 389);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(96, 23);
            this.btnAddCourse.TabIndex = 2;
            this.btnAddCourse.Text = "Add course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(536, 389);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(46, 23);
            this.btnErase.TabIndex = 3;
            this.btnErase.Text = "Erase schedule and start over";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "(This will remove all courses!)";
            // 
            // txtbxSchedule
            // 
            this.txtbxSchedule.Location = new System.Drawing.Point(170, 45);
            this.txtbxSchedule.Multiline = true;
            this.txtbxSchedule.Name = "txtbxSchedule";
            this.txtbxSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxSchedule.Size = new System.Drawing.Size(412, 338);
            this.txtbxSchedule.TabIndex = 5;
            this.txtbxSchedule.TextChanged += new System.EventHandler(this.txtbxSchedule_TextChanged);
            // 
            // ScheduleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxSchedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button btnAddCourse;
        private Button btnErase;
        private Label label2;
        private TextBox txtbxSchedule;
    }
}