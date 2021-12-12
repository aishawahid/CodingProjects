namespace timetablingLogicOut
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUpdateUserPW = new System.Windows.Forms.TextBox();
            this.tbAddUserPW = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUpdateUserUN = new System.Windows.Forms.TextBox();
            this.tbAddUserUN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUpdateIsAdmin = new System.Windows.Forms.ComboBox();
            this.cbAddIsAdmin = new System.Windows.Forms.ComboBox();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUpdateUserFN = new System.Windows.Forms.TextBox();
            this.tbAddUserFN = new System.Windows.Forms.TextBox();
            this.cbUserDelete = new System.Windows.Forms.ComboBox();
            this.cbUserUpdate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToMain
            // 
            this.btnGoToMain.BackColor = System.Drawing.Color.Black;
            this.btnGoToMain.ForeColor = System.Drawing.Color.White;
            this.btnGoToMain.Location = new System.Drawing.Point(563, 459);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(157, 32);
            this.btnGoToMain.TabIndex = 89;
            this.btnGoToMain.Text = "Go back to main";
            this.btnGoToMain.UseVisualStyleBackColor = false;
            this.btnGoToMain.Click += new System.EventHandler(this.btnGoToMain_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 426);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(174, 65);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 88;
            this.pbLogo.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(599, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(121, 26);
            this.btnView.TabIndex = 112;
            this.btnView.Text = "View Staff";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Khaki;
            this.label9.Location = new System.Drawing.Point(73, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 111;
            this.label9.Text = "Password";
            // 
            // tbUpdateUserPW
            // 
            this.tbUpdateUserPW.Location = new System.Drawing.Point(353, 311);
            this.tbUpdateUserPW.Name = "tbUpdateUserPW";
            this.tbUpdateUserPW.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateUserPW.TabIndex = 110;
            // 
            // tbAddUserPW
            // 
            this.tbAddUserPW.Location = new System.Drawing.Point(175, 311);
            this.tbAddUserPW.Name = "tbAddUserPW";
            this.tbAddUserPW.Size = new System.Drawing.Size(121, 22);
            this.tbAddUserPW.TabIndex = 109;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(73, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 108;
            this.label8.Text = "Username";
            // 
            // tbUpdateUserUN
            // 
            this.tbUpdateUserUN.Location = new System.Drawing.Point(353, 276);
            this.tbUpdateUserUN.Name = "tbUpdateUserUN";
            this.tbUpdateUserUN.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateUserUN.TabIndex = 107;
            // 
            // tbAddUserUN
            // 
            this.tbAddUserUN.Location = new System.Drawing.Point(175, 276);
            this.tbAddUserUN.Name = "tbAddUserUN";
            this.tbAddUserUN.Size = new System.Drawing.Size(121, 22);
            this.tbAddUserUN.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(73, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 105;
            this.label7.Text = "Is Admin";
            // 
            // cbUpdateIsAdmin
            // 
            this.cbUpdateIsAdmin.FormattingEnabled = true;
            this.cbUpdateIsAdmin.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbUpdateIsAdmin.Location = new System.Drawing.Point(353, 203);
            this.cbUpdateIsAdmin.Name = "cbUpdateIsAdmin";
            this.cbUpdateIsAdmin.Size = new System.Drawing.Size(121, 24);
            this.cbUpdateIsAdmin.TabIndex = 104;
            this.cbUpdateIsAdmin.Text = "Select";
            // 
            // cbAddIsAdmin
            // 
            this.cbAddIsAdmin.FormattingEnabled = true;
            this.cbAddIsAdmin.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbAddIsAdmin.Location = new System.Drawing.Point(175, 203);
            this.cbAddIsAdmin.Name = "cbAddIsAdmin";
            this.cbAddIsAdmin.Size = new System.Drawing.Size(121, 24);
            this.cbAddIsAdmin.TabIndex = 103;
            this.cbAddIsAdmin.Text = "Select";
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(549, 346);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(75, 26);
            this.btnUserDelete.TabIndex = 102;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(375, 345);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnUserUpdate.TabIndex = 101;
            this.btnUserUpdate.Text = "Update";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(196, 345);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(75, 26);
            this.btnUserAdd.TabIndex = 100;
            this.btnUserAdd.Text = "Add";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(73, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(73, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "Staff";
            // 
            // tbUpdateUserFN
            // 
            this.tbUpdateUserFN.Location = new System.Drawing.Point(353, 240);
            this.tbUpdateUserFN.Name = "tbUpdateUserFN";
            this.tbUpdateUserFN.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateUserFN.TabIndex = 97;
            // 
            // tbAddUserFN
            // 
            this.tbAddUserFN.Location = new System.Drawing.Point(175, 240);
            this.tbAddUserFN.Name = "tbAddUserFN";
            this.tbAddUserFN.Size = new System.Drawing.Size(121, 22);
            this.tbAddUserFN.TabIndex = 96;
            // 
            // cbUserDelete
            // 
            this.cbUserDelete.FormattingEnabled = true;
            this.cbUserDelete.Location = new System.Drawing.Point(530, 164);
            this.cbUserDelete.Name = "cbUserDelete";
            this.cbUserDelete.Size = new System.Drawing.Size(121, 24);
            this.cbUserDelete.TabIndex = 95;
            this.cbUserDelete.Text = "Select";
            // 
            // cbUserUpdate
            // 
            this.cbUserUpdate.FormattingEnabled = true;
            this.cbUserUpdate.Location = new System.Drawing.Point(353, 166);
            this.cbUserUpdate.Name = "cbUserUpdate";
            this.cbUserUpdate.Size = new System.Drawing.Size(121, 24);
            this.cbUserUpdate.TabIndex = 94;
            this.cbUserUpdate.Text = "Select";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "Delete staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 92;
            this.label3.Text = "Update staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "Add new staff";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(321, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 90;
            this.label1.Text = "Stored Staff";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUpdateUserPW);
            this.Controls.Add(this.tbAddUserPW);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbUpdateUserUN);
            this.Controls.Add(this.tbAddUserUN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbUpdateIsAdmin);
            this.Controls.Add(this.cbAddIsAdmin);
            this.Controls.Add(this.btnUserDelete);
            this.Controls.Add(this.btnUserUpdate);
            this.Controls.Add(this.btnUserAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUpdateUserFN);
            this.Controls.Add(this.tbAddUserFN);
            this.Controls.Add(this.cbUserDelete);
            this.Controls.Add(this.cbUserUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.Name = "frmUser";
            this.Text = "LogicOut Timetable";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUpdateUserPW;
        private System.Windows.Forms.TextBox tbAddUserPW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUpdateUserUN;
        private System.Windows.Forms.TextBox tbAddUserUN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUpdateIsAdmin;
        private System.Windows.Forms.ComboBox cbAddIsAdmin;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUpdateUserFN;
        private System.Windows.Forms.TextBox tbAddUserFN;
        private System.Windows.Forms.ComboBox cbUserDelete;
        private System.Windows.Forms.ComboBox cbUserUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}