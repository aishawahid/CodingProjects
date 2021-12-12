namespace timetablingLogicOut
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAllocate = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnSchedules = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnChoices = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllocate
            // 
            this.btnAllocate.BackColor = System.Drawing.Color.Black;
            this.btnAllocate.ForeColor = System.Drawing.Color.White;
            this.btnAllocate.Location = new System.Drawing.Point(342, 456);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(184, 30);
            this.btnAllocate.TabIndex = 13;
            this.btnAllocate.Text = "Allocate";
            this.btnAllocate.UseVisualStyleBackColor = false;
            this.btnAllocate.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(371, 132);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(128, 28);
            this.btnUsers.TabIndex = 12;
            this.btnUsers.Text = "Edit Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(371, 310);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(128, 28);
            this.btnStudents.TabIndex = 11;
            this.btnStudents.Text = "Edit Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(371, 221);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(128, 28);
            this.btnRooms.TabIndex = 10;
            this.btnRooms.Text = "Edit Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnSchedules
            // 
            this.btnSchedules.Location = new System.Drawing.Point(371, 264);
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.Size = new System.Drawing.Size(128, 28);
            this.btnSchedules.TabIndex = 9;
            this.btnSchedules.Text = "Edit Schedules";
            this.btnSchedules.UseVisualStyleBackColor = true;
            this.btnSchedules.Click += new System.EventHandler(this.btnSchedules_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(371, 176);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(128, 28);
            this.btnCourses.TabIndex = 8;
            this.btnCourses.Text = "Edit Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(297, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select the option you would like to carry out";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Location = new System.Drawing.Point(744, 511);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 30);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 476);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(174, 65);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 15;
            this.pbLogo.TabStop = false;
            // 
            // btnSession
            // 
            this.btnSession.Location = new System.Drawing.Point(371, 355);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(128, 28);
            this.btnSession.TabIndex = 16;
            this.btnSession.Text = "Edit Session";
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // btnChoices
            // 
            this.btnChoices.Location = new System.Drawing.Point(371, 401);
            this.btnChoices.Name = "btnChoices";
            this.btnChoices.Size = new System.Drawing.Size(128, 28);
            this.btnChoices.TabIndex = 17;
            this.btnChoices.Text = "Edit Choices";
            this.btnChoices.UseVisualStyleBackColor = true;
            this.btnChoices.Click += new System.EventHandler(this.btnChoices_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.BackColor = System.Drawing.Color.Black;
            this.btnTimetable.ForeColor = System.Drawing.Color.White;
            this.btnTimetable.Location = new System.Drawing.Point(342, 502);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(184, 30);
            this.btnTimetable.TabIndex = 18;
            this.btnTimetable.Text = "Timetable";
            this.btnTimetable.UseVisualStyleBackColor = false;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.btnTimetable);
            this.Controls.Add(this.btnChoices);
            this.Controls.Add(this.btnSession);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnSchedules);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "LogicOut Timetabling";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnSchedules;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnChoices;
        private System.Windows.Forms.Button btnTimetable;
    }
}