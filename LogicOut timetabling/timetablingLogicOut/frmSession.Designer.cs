namespace timetablingLogicOut
{
    partial class frmSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSession));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.cbUpdateSessionRoom = new System.Windows.Forms.ComboBox();
            this.cbSessionRoom = new System.Windows.Forms.ComboBox();
            this.cbUpdateSessionSchedule = new System.Windows.Forms.ComboBox();
            this.cbAddSessionSchedule = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUpdateSessionCourse = new System.Windows.Forms.ComboBox();
            this.cbAddSessionCourse = new System.Windows.Forms.ComboBox();
            this.btnSessionDelete = new System.Windows.Forms.Button();
            this.btnSessionUpdate = new System.Windows.Forms.Button();
            this.btnSessionAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSessionDelete = new System.Windows.Forms.ComboBox();
            this.cbSessionUpdate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 476);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(174, 65);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // btnGoToMain
            // 
            this.btnGoToMain.BackColor = System.Drawing.Color.Black;
            this.btnGoToMain.ForeColor = System.Drawing.Color.White;
            this.btnGoToMain.Location = new System.Drawing.Point(763, 509);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(157, 32);
            this.btnGoToMain.TabIndex = 77;
            this.btnGoToMain.Text = "Go back to main";
            this.btnGoToMain.UseVisualStyleBackColor = false;
            this.btnGoToMain.Click += new System.EventHandler(this.btnGoToMain_Click);
            // 
            // cbUpdateSessionRoom
            // 
            this.cbUpdateSessionRoom.FormattingEnabled = true;
            this.cbUpdateSessionRoom.Location = new System.Drawing.Point(338, 304);
            this.cbUpdateSessionRoom.Name = "cbUpdateSessionRoom";
            this.cbUpdateSessionRoom.Size = new System.Drawing.Size(178, 24);
            this.cbUpdateSessionRoom.TabIndex = 101;
            // 
            // cbSessionRoom
            // 
            this.cbSessionRoom.FormattingEnabled = true;
            this.cbSessionRoom.Location = new System.Drawing.Point(135, 304);
            this.cbSessionRoom.Name = "cbSessionRoom";
            this.cbSessionRoom.Size = new System.Drawing.Size(177, 24);
            this.cbSessionRoom.TabIndex = 100;
            // 
            // cbUpdateSessionSchedule
            // 
            this.cbUpdateSessionSchedule.FormattingEnabled = true;
            this.cbUpdateSessionSchedule.Location = new System.Drawing.Point(338, 269);
            this.cbUpdateSessionSchedule.Name = "cbUpdateSessionSchedule";
            this.cbUpdateSessionSchedule.Size = new System.Drawing.Size(178, 24);
            this.cbUpdateSessionSchedule.TabIndex = 99;
            // 
            // cbAddSessionSchedule
            // 
            this.cbAddSessionSchedule.FormattingEnabled = true;
            this.cbAddSessionSchedule.Location = new System.Drawing.Point(135, 270);
            this.cbAddSessionSchedule.Name = "cbAddSessionSchedule";
            this.cbAddSessionSchedule.Size = new System.Drawing.Size(177, 24);
            this.cbAddSessionSchedule.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(27, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 97;
            this.label8.Text = "Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(27, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 96;
            this.label7.Text = "Course";
            // 
            // cbUpdateSessionCourse
            // 
            this.cbUpdateSessionCourse.FormattingEnabled = true;
            this.cbUpdateSessionCourse.Location = new System.Drawing.Point(338, 234);
            this.cbUpdateSessionCourse.Name = "cbUpdateSessionCourse";
            this.cbUpdateSessionCourse.Size = new System.Drawing.Size(178, 24);
            this.cbUpdateSessionCourse.TabIndex = 95;
            // 
            // cbAddSessionCourse
            // 
            this.cbAddSessionCourse.FormattingEnabled = true;
            this.cbAddSessionCourse.Location = new System.Drawing.Point(135, 235);
            this.cbAddSessionCourse.Name = "cbAddSessionCourse";
            this.cbAddSessionCourse.Size = new System.Drawing.Size(177, 24);
            this.cbAddSessionCourse.TabIndex = 94;
            // 
            // btnSessionDelete
            // 
            this.btnSessionDelete.Location = new System.Drawing.Point(732, 359);
            this.btnSessionDelete.Name = "btnSessionDelete";
            this.btnSessionDelete.Size = new System.Drawing.Size(75, 26);
            this.btnSessionDelete.TabIndex = 93;
            this.btnSessionDelete.Text = "Delete";
            this.btnSessionDelete.UseVisualStyleBackColor = true;
            this.btnSessionDelete.Click += new System.EventHandler(this.btnSessionDelete_Click);
            // 
            // btnSessionUpdate
            // 
            this.btnSessionUpdate.Location = new System.Drawing.Point(433, 358);
            this.btnSessionUpdate.Name = "btnSessionUpdate";
            this.btnSessionUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnSessionUpdate.TabIndex = 92;
            this.btnSessionUpdate.Text = "Update";
            this.btnSessionUpdate.UseVisualStyleBackColor = true;
            this.btnSessionUpdate.Click += new System.EventHandler(this.btnSessionUpdate_Click);
            // 
            // btnSessionAdd
            // 
            this.btnSessionAdd.Location = new System.Drawing.Point(156, 359);
            this.btnSessionAdd.Name = "btnSessionAdd";
            this.btnSessionAdd.Size = new System.Drawing.Size(75, 26);
            this.btnSessionAdd.TabIndex = 91;
            this.btnSessionAdd.Text = "Add";
            this.btnSessionAdd.UseVisualStyleBackColor = true;
            this.btnSessionAdd.Click += new System.EventHandler(this.btnSessionAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(27, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Schedule";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(27, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 89;
            this.label5.Text = "Session";
            // 
            // cbSessionDelete
            // 
            this.cbSessionDelete.FormattingEnabled = true;
            this.cbSessionDelete.Location = new System.Drawing.Point(640, 197);
            this.cbSessionDelete.Name = "cbSessionDelete";
            this.cbSessionDelete.Size = new System.Drawing.Size(287, 24);
            this.cbSessionDelete.TabIndex = 88;
            // 
            // cbSessionUpdate
            // 
            this.cbSessionUpdate.FormattingEnabled = true;
            this.cbSessionUpdate.Location = new System.Drawing.Point(338, 197);
            this.cbSessionUpdate.Name = "cbSessionUpdate";
            this.cbSessionUpdate.Size = new System.Drawing.Size(282, 24);
            this.cbSessionUpdate.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Delete a session";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Update a session";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Add a new session";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(751, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(169, 26);
            this.btnView.TabIndex = 83;
            this.btnView.Text = "View Sessions";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(398, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 82;
            this.label2.Text = "Sessions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.cbUpdateSessionRoom);
            this.Controls.Add(this.cbSessionRoom);
            this.Controls.Add(this.cbUpdateSessionSchedule);
            this.Controls.Add(this.cbAddSessionSchedule);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbUpdateSessionCourse);
            this.Controls.Add(this.cbAddSessionCourse);
            this.Controls.Add(this.btnSessionDelete);
            this.Controls.Add(this.btnSessionUpdate);
            this.Controls.Add(this.btnSessionAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSessionDelete);
            this.Controls.Add(this.cbSessionUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.Name = "frmSession";
            this.Text = "LogicOut Timetabling";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnGoToMain;
        private System.Windows.Forms.ComboBox cbUpdateSessionRoom;
        private System.Windows.Forms.ComboBox cbSessionRoom;
        private System.Windows.Forms.ComboBox cbUpdateSessionSchedule;
        private System.Windows.Forms.ComboBox cbAddSessionSchedule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUpdateSessionCourse;
        private System.Windows.Forms.ComboBox cbAddSessionCourse;
        private System.Windows.Forms.Button btnSessionDelete;
        private System.Windows.Forms.Button btnSessionUpdate;
        private System.Windows.Forms.Button btnSessionAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSessionDelete;
        private System.Windows.Forms.ComboBox cbSessionUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label2;
    }
}