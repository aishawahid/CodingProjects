namespace timetablingLogicOut
{
    partial class frmSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUpdateDay = new System.Windows.Forms.ComboBox();
            this.cbAddDay = new System.Windows.Forms.ComboBox();
            this.btnScheduleDelete = new System.Windows.Forms.Button();
            this.btnScheduleUpdate = new System.Windows.Forms.Button();
            this.btnSchedulesAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.tbAddScheduleET = new System.Windows.Forms.MaskedTextBox();
            this.tbAddScheduleST = new System.Windows.Forms.MaskedTextBox();
            this.tbUpdateScheduleET = new System.Windows.Forms.MaskedTextBox();
            this.tbUpdateScheduleST = new System.Windows.Forms.MaskedTextBox();
            this.cbUpdateScheduleday = new System.Windows.Forms.ComboBox();
            this.cbDeleteSchedDay = new System.Windows.Forms.ComboBox();
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
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(599, 28);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(121, 26);
            this.btnView.TabIndex = 81;
            this.btnView.Text = "View Schedules";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(35, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "End Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(35, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "Day";
            // 
            // cbUpdateDay
            // 
            this.cbUpdateDay.FormattingEnabled = true;
            this.cbUpdateDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cbUpdateDay.Location = new System.Drawing.Point(321, 196);
            this.cbUpdateDay.Name = "cbUpdateDay";
            this.cbUpdateDay.Size = new System.Drawing.Size(121, 24);
            this.cbUpdateDay.TabIndex = 76;
            this.cbUpdateDay.Text = "Select";
            // 
            // cbAddDay
            // 
            this.cbAddDay.FormattingEnabled = true;
            this.cbAddDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cbAddDay.Location = new System.Drawing.Point(141, 196);
            this.cbAddDay.Name = "cbAddDay";
            this.cbAddDay.Size = new System.Drawing.Size(121, 24);
            this.cbAddDay.TabIndex = 75;
            this.cbAddDay.Text = "Select";
            // 
            // btnScheduleDelete
            // 
            this.btnScheduleDelete.Location = new System.Drawing.Point(526, 322);
            this.btnScheduleDelete.Name = "btnScheduleDelete";
            this.btnScheduleDelete.Size = new System.Drawing.Size(75, 26);
            this.btnScheduleDelete.TabIndex = 74;
            this.btnScheduleDelete.Text = "Delete";
            this.btnScheduleDelete.UseVisualStyleBackColor = true;
            this.btnScheduleDelete.Click += new System.EventHandler(this.btnScheduleDelete_Click);
            // 
            // btnScheduleUpdate
            // 
            this.btnScheduleUpdate.Location = new System.Drawing.Point(345, 323);
            this.btnScheduleUpdate.Name = "btnScheduleUpdate";
            this.btnScheduleUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnScheduleUpdate.TabIndex = 73;
            this.btnScheduleUpdate.Text = "Update";
            this.btnScheduleUpdate.UseVisualStyleBackColor = true;
            this.btnScheduleUpdate.Click += new System.EventHandler(this.btnScheduleUpdate_Click);
            // 
            // btnSchedulesAdd
            // 
            this.btnSchedulesAdd.Location = new System.Drawing.Point(155, 322);
            this.btnSchedulesAdd.Name = "btnSchedulesAdd";
            this.btnSchedulesAdd.Size = new System.Drawing.Size(75, 26);
            this.btnSchedulesAdd.TabIndex = 72;
            this.btnSchedulesAdd.Text = "Add";
            this.btnSchedulesAdd.UseVisualStyleBackColor = true;
            this.btnSchedulesAdd.Click += new System.EventHandler(this.btnSchedulesAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(35, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(35, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Schedules";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Delete a schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Update a schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Add a new schedule";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(297, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "Stored Schedules";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoToMain
            // 
            this.btnGoToMain.BackColor = System.Drawing.Color.Black;
            this.btnGoToMain.ForeColor = System.Drawing.Color.White;
            this.btnGoToMain.Location = new System.Drawing.Point(563, 459);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(157, 32);
            this.btnGoToMain.TabIndex = 83;
            this.btnGoToMain.Text = "Go back to main";
            this.btnGoToMain.UseVisualStyleBackColor = false;
            this.btnGoToMain.Click += new System.EventHandler(this.btnGoToMain_Click);
            // 
            // tbAddScheduleET
            // 
            this.tbAddScheduleET.Location = new System.Drawing.Point(141, 271);
            this.tbAddScheduleET.Mask = "90:00";
            this.tbAddScheduleET.Name = "tbAddScheduleET";
            this.tbAddScheduleET.Size = new System.Drawing.Size(46, 22);
            this.tbAddScheduleET.TabIndex = 84;
            this.tbAddScheduleET.ValidatingType = typeof(System.DateTime);
            // 
            // tbAddScheduleST
            // 
            this.tbAddScheduleST.Location = new System.Drawing.Point(141, 233);
            this.tbAddScheduleST.Mask = "90:00";
            this.tbAddScheduleST.Name = "tbAddScheduleST";
            this.tbAddScheduleST.Size = new System.Drawing.Size(46, 22);
            this.tbAddScheduleST.TabIndex = 85;
            this.tbAddScheduleST.ValidatingType = typeof(System.DateTime);
            // 
            // tbUpdateScheduleET
            // 
            this.tbUpdateScheduleET.Location = new System.Drawing.Point(321, 272);
            this.tbUpdateScheduleET.Mask = "90:00";
            this.tbUpdateScheduleET.Name = "tbUpdateScheduleET";
            this.tbUpdateScheduleET.Size = new System.Drawing.Size(47, 22);
            this.tbUpdateScheduleET.TabIndex = 86;
            this.tbUpdateScheduleET.ValidatingType = typeof(System.DateTime);
            // 
            // tbUpdateScheduleST
            // 
            this.tbUpdateScheduleST.Location = new System.Drawing.Point(321, 236);
            this.tbUpdateScheduleST.Mask = "90:00";
            this.tbUpdateScheduleST.Name = "tbUpdateScheduleST";
            this.tbUpdateScheduleST.Size = new System.Drawing.Size(47, 22);
            this.tbUpdateScheduleST.TabIndex = 87;
            this.tbUpdateScheduleST.ValidatingType = typeof(System.DateTime);
            // 
            // cbUpdateScheduleday
            // 
            this.cbUpdateScheduleday.FormattingEnabled = true;
            this.cbUpdateScheduleday.Location = new System.Drawing.Point(321, 158);
            this.cbUpdateScheduleday.Name = "cbUpdateScheduleday";
            this.cbUpdateScheduleday.Size = new System.Drawing.Size(178, 24);
            this.cbUpdateScheduleday.TabIndex = 98;
            this.cbUpdateScheduleday.Text = "Select";
            // 
            // cbDeleteSchedDay
            // 
            this.cbDeleteSchedDay.FormattingEnabled = true;
            this.cbDeleteSchedDay.Location = new System.Drawing.Point(505, 158);
            this.cbDeleteSchedDay.Name = "cbDeleteSchedDay";
            this.cbDeleteSchedDay.Size = new System.Drawing.Size(183, 24);
            this.cbDeleteSchedDay.TabIndex = 99;
            this.cbDeleteSchedDay.Text = "Select";
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.cbDeleteSchedDay);
            this.Controls.Add(this.cbUpdateScheduleday);
            this.Controls.Add(this.tbUpdateScheduleST);
            this.Controls.Add(this.tbUpdateScheduleET);
            this.Controls.Add(this.tbAddScheduleST);
            this.Controls.Add(this.tbAddScheduleET);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbUpdateDay);
            this.Controls.Add(this.cbAddDay);
            this.Controls.Add(this.btnScheduleDelete);
            this.Controls.Add(this.btnScheduleUpdate);
            this.Controls.Add(this.btnSchedulesAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.Name = "frmSchedule";
            this.Text = "LogicOut Timetabling";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUpdateDay;
        private System.Windows.Forms.ComboBox cbAddDay;
        private System.Windows.Forms.Button btnScheduleDelete;
        private System.Windows.Forms.Button btnScheduleUpdate;
        private System.Windows.Forms.Button btnSchedulesAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToMain;
        private System.Windows.Forms.MaskedTextBox tbAddScheduleET;
        private System.Windows.Forms.MaskedTextBox tbAddScheduleST;
        private System.Windows.Forms.MaskedTextBox tbUpdateScheduleET;
        private System.Windows.Forms.MaskedTextBox tbUpdateScheduleST;
        private System.Windows.Forms.ComboBox cbUpdateScheduleday;
        private System.Windows.Forms.ComboBox cbDeleteSchedDay;
    }
}