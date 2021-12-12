namespace timetablingLogicOut
{
    partial class frmCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourse));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.btnCourseDelete = new System.Windows.Forms.Button();
            this.btnCourseUpdate = new System.Windows.Forms.Button();
            this.btnCourseAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUpdateCourseName = new System.Windows.Forms.TextBox();
            this.tbAddCouseName = new System.Windows.Forms.TextBox();
            this.cbCourseDelete = new System.Windows.Forms.ComboBox();
            this.cbCourseUpdate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 426);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(174, 65);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(599, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(121, 26);
            this.btnView.TabIndex = 77;
            this.btnView.Text = "View Courses";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGoToMain
            // 
            this.btnGoToMain.BackColor = System.Drawing.Color.Black;
            this.btnGoToMain.ForeColor = System.Drawing.Color.White;
            this.btnGoToMain.Location = new System.Drawing.Point(563, 459);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(157, 32);
            this.btnGoToMain.TabIndex = 76;
            this.btnGoToMain.Text = "Go back to main";
            this.btnGoToMain.UseVisualStyleBackColor = false;
            this.btnGoToMain.Click += new System.EventHandler(this.btnGoToMain_Click);
            // 
            // btnCourseDelete
            // 
            this.btnCourseDelete.Location = new System.Drawing.Point(521, 284);
            this.btnCourseDelete.Name = "btnCourseDelete";
            this.btnCourseDelete.Size = new System.Drawing.Size(75, 26);
            this.btnCourseDelete.TabIndex = 75;
            this.btnCourseDelete.Text = "Delete";
            this.btnCourseDelete.UseVisualStyleBackColor = true;
            this.btnCourseDelete.Click += new System.EventHandler(this.btnCourseDelete_Click);
            // 
            // btnCourseUpdate
            // 
            this.btnCourseUpdate.Location = new System.Drawing.Point(367, 284);
            this.btnCourseUpdate.Name = "btnCourseUpdate";
            this.btnCourseUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnCourseUpdate.TabIndex = 74;
            this.btnCourseUpdate.Text = "Update";
            this.btnCourseUpdate.UseVisualStyleBackColor = true;
            this.btnCourseUpdate.Click += new System.EventHandler(this.btnCourseUpdate_Click);
            // 
            // btnCourseAdd
            // 
            this.btnCourseAdd.Location = new System.Drawing.Point(203, 284);
            this.btnCourseAdd.Name = "btnCourseAdd";
            this.btnCourseAdd.Size = new System.Drawing.Size(75, 26);
            this.btnCourseAdd.TabIndex = 73;
            this.btnCourseAdd.Text = "Add";
            this.btnCourseAdd.UseVisualStyleBackColor = true;
            this.btnCourseAdd.Click += new System.EventHandler(this.btnCourseAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(80, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(80, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Course";
            // 
            // tbUpdateCourseName
            // 
            this.tbUpdateCourseName.Location = new System.Drawing.Point(345, 233);
            this.tbUpdateCourseName.Name = "tbUpdateCourseName";
            this.tbUpdateCourseName.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateCourseName.TabIndex = 69;
            // 
            // tbAddCouseName
            // 
            this.tbAddCouseName.Location = new System.Drawing.Point(182, 233);
            this.tbAddCouseName.Name = "tbAddCouseName";
            this.tbAddCouseName.Size = new System.Drawing.Size(121, 22);
            this.tbAddCouseName.TabIndex = 68;
            // 
            // cbCourseDelete
            // 
            this.cbCourseDelete.FormattingEnabled = true;
            this.cbCourseDelete.Location = new System.Drawing.Point(502, 185);
            this.cbCourseDelete.Name = "cbCourseDelete";
            this.cbCourseDelete.Size = new System.Drawing.Size(121, 24);
            this.cbCourseDelete.TabIndex = 67;
            // 
            // cbCourseUpdate
            // 
            this.cbCourseUpdate.FormattingEnabled = true;
            this.cbCourseUpdate.Location = new System.Drawing.Point(345, 185);
            this.cbCourseUpdate.Name = "cbCourseUpdate";
            this.cbCourseUpdate.Size = new System.Drawing.Size(121, 24);
            this.cbCourseUpdate.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Delete a course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Update a course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Add a new course";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(312, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "Stored Courses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.btnCourseDelete);
            this.Controls.Add(this.btnCourseUpdate);
            this.Controls.Add(this.btnCourseAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUpdateCourseName);
            this.Controls.Add(this.tbAddCouseName);
            this.Controls.Add(this.cbCourseDelete);
            this.Controls.Add(this.cbCourseUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.Name = "frmCourse";
            this.Text = "LogicOut Timetabling";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnGoToMain;
        private System.Windows.Forms.Button btnCourseDelete;
        private System.Windows.Forms.Button btnCourseUpdate;
        private System.Windows.Forms.Button btnCourseAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUpdateCourseName;
        private System.Windows.Forms.TextBox tbAddCouseName;
        private System.Windows.Forms.ComboBox cbCourseDelete;
        private System.Windows.Forms.ComboBox cbCourseUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}