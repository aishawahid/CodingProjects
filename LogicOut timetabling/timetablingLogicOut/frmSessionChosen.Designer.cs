namespace timetablingLogicOut
{
    partial class frmSessionChosen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSessionChosen));
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnCourseDelete = new System.Windows.Forms.Button();
            this.btnCourseAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAddChoiceStudent = new System.Windows.Forms.ComboBox();
            this.cbAddChoiceSession = new System.Windows.Forms.ComboBox();
            this.cbDeleteChoice = new System.Windows.Forms.ComboBox();
            this.cbDeleteAllocated = new System.Windows.Forms.ComboBox();
            this.btnChoiceAdelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToMain
            // 
            this.btnGoToMain.BackColor = System.Drawing.Color.Black;
            this.btnGoToMain.ForeColor = System.Drawing.Color.White;
            this.btnGoToMain.Location = new System.Drawing.Point(863, 478);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(157, 32);
            this.btnGoToMain.TabIndex = 78;
            this.btnGoToMain.Text = "Go back to main";
            this.btnGoToMain.UseVisualStyleBackColor = false;
            this.btnGoToMain.Click += new System.EventHandler(this.btnGoToMain_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(14, 445);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(174, 65);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 77;
            this.pbLogo.TabStop = false;
            // 
            // btnCourseDelete
            // 
            this.btnCourseDelete.Location = new System.Drawing.Point(825, 331);
            this.btnCourseDelete.Name = "btnCourseDelete";
            this.btnCourseDelete.Size = new System.Drawing.Size(77, 26);
            this.btnCourseDelete.TabIndex = 90;
            this.btnCourseDelete.Text = "Delete";
            this.btnCourseDelete.UseVisualStyleBackColor = true;
            this.btnCourseDelete.Click += new System.EventHandler(this.btnCourseDelete_Click);
            // 
            // btnCourseAdd
            // 
            this.btnCourseAdd.Location = new System.Drawing.Point(184, 331);
            this.btnCourseAdd.Name = "btnCourseAdd";
            this.btnCourseAdd.Size = new System.Drawing.Size(75, 26);
            this.btnCourseAdd.TabIndex = 88;
            this.btnCourseAdd.Text = "Add";
            this.btnCourseAdd.UseVisualStyleBackColor = true;
            this.btnCourseAdd.Click += new System.EventHandler(this.btnCourseAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(11, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 87;
            this.label6.Text = "Session";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(11, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(756, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Remove a unallocated choice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Add a new choice";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(899, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(121, 26);
            this.btnView.TabIndex = 92;
            this.btnView.Text = "View Choices";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(447, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Student Choices";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 93;
            this.label3.Text = "Choices";
            // 
            // cbAddChoiceStudent
            // 
            this.cbAddChoiceStudent.FormattingEnabled = true;
            this.cbAddChoiceStudent.Location = new System.Drawing.Point(81, 250);
            this.cbAddChoiceStudent.Name = "cbAddChoiceStudent";
            this.cbAddChoiceStudent.Size = new System.Drawing.Size(309, 24);
            this.cbAddChoiceStudent.TabIndex = 94;
            // 
            // cbAddChoiceSession
            // 
            this.cbAddChoiceSession.FormattingEnabled = true;
            this.cbAddChoiceSession.Location = new System.Drawing.Point(81, 293);
            this.cbAddChoiceSession.Name = "cbAddChoiceSession";
            this.cbAddChoiceSession.Size = new System.Drawing.Size(309, 24);
            this.cbAddChoiceSession.TabIndex = 95;
            // 
            // cbDeleteChoice
            // 
            this.cbDeleteChoice.FormattingEnabled = true;
            this.cbDeleteChoice.Location = new System.Drawing.Point(711, 205);
            this.cbDeleteChoice.Name = "cbDeleteChoice";
            this.cbDeleteChoice.Size = new System.Drawing.Size(309, 24);
            this.cbDeleteChoice.TabIndex = 96;
            // 
            // cbDeleteAllocated
            // 
            this.cbDeleteAllocated.FormattingEnabled = true;
            this.cbDeleteAllocated.Location = new System.Drawing.Point(396, 205);
            this.cbDeleteAllocated.Name = "cbDeleteAllocated";
            this.cbDeleteAllocated.Size = new System.Drawing.Size(309, 24);
            this.cbDeleteAllocated.TabIndex = 99;
            // 
            // btnChoiceAdelete
            // 
            this.btnChoiceAdelete.Location = new System.Drawing.Point(474, 331);
            this.btnChoiceAdelete.Name = "btnChoiceAdelete";
            this.btnChoiceAdelete.Size = new System.Drawing.Size(77, 26);
            this.btnChoiceAdelete.TabIndex = 98;
            this.btnChoiceAdelete.Text = "Delete";
            this.btnChoiceAdelete.UseVisualStyleBackColor = true;
            this.btnChoiceAdelete.Click += new System.EventHandler(this.btnChoiceAdelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 97;
            this.label7.Text = "Remove an allocated choice";
            // 
            // frmSessionChosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 521);
            this.Controls.Add(this.cbDeleteAllocated);
            this.Controls.Add(this.btnChoiceAdelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbDeleteChoice);
            this.Controls.Add(this.cbAddChoiceSession);
            this.Controls.Add(this.cbAddChoiceStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCourseDelete);
            this.Controls.Add(this.btnCourseAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.Name = "frmSessionChosen";
            this.Text = "LogicOut Timetabling";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnCourseDelete;
        private System.Windows.Forms.Button btnCourseAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAddChoiceStudent;
        private System.Windows.Forms.ComboBox cbAddChoiceSession;
        private System.Windows.Forms.ComboBox cbDeleteChoice;
        private System.Windows.Forms.ComboBox cbDeleteAllocated;
        private System.Windows.Forms.Button btnChoiceAdelete;
        private System.Windows.Forms.Label label7;
    }
}