namespace timetablingLogicOut
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUpdateStudentName = new System.Windows.Forms.TextBox();
            this.tbAddStudentName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentUpdate = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStudentDelete = new System.Windows.Forms.ComboBox();
            this.cbStudentUpdate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUpdateStudentNum = new System.Windows.Forms.TextBox();
            this.tbUpdateStudentEmail = new System.Windows.Forms.TextBox();
            this.tbAddStudentEmail = new System.Windows.Forms.TextBox();
            this.tbAddStudentNum = new System.Windows.Forms.TextBox();
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
            // btnGoToMain
            // 
            this.btnGoToMain.BackColor = System.Drawing.Color.Black;
            this.btnGoToMain.ForeColor = System.Drawing.Color.White;
            this.btnGoToMain.Location = new System.Drawing.Point(563, 459);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(157, 32);
            this.btnGoToMain.TabIndex = 106;
            this.btnGoToMain.Text = "Go back to main";
            this.btnGoToMain.UseVisualStyleBackColor = false;
            this.btnGoToMain.Click += new System.EventHandler(this.btnGoToMain_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(599, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(121, 26);
            this.btnView.TabIndex = 104;
            this.btnView.Text = "View Students";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(65, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 101;
            this.label8.Text = "Name";
            // 
            // tbUpdateStudentName
            // 
            this.tbUpdateStudentName.Location = new System.Drawing.Point(359, 211);
            this.tbUpdateStudentName.Name = "tbUpdateStudentName";
            this.tbUpdateStudentName.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateStudentName.TabIndex = 100;
            // 
            // tbAddStudentName
            // 
            this.tbAddStudentName.Location = new System.Drawing.Point(188, 211);
            this.tbAddStudentName.Name = "tbAddStudentName";
            this.tbAddStudentName.Size = new System.Drawing.Size(121, 22);
            this.tbAddStudentName.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(65, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 98;
            this.label7.Text = "Contact Number";
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(540, 331);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 26);
            this.btnStudentDelete.TabIndex = 95;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.Location = new System.Drawing.Point(381, 330);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnStudentUpdate.TabIndex = 94;
            this.btnStudentUpdate.Text = "Update";
            this.btnStudentUpdate.UseVisualStyleBackColor = true;
            this.btnStudentUpdate.Click += new System.EventHandler(this.btnStudentUpdate_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(209, 330);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(75, 26);
            this.btnStudentAdd.TabIndex = 93;
            this.btnStudentAdd.Text = "Add";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(65, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 92;
            this.label6.Text = "Contact Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(65, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "Student";
            // 
            // cbStudentDelete
            // 
            this.cbStudentDelete.FormattingEnabled = true;
            this.cbStudentDelete.Location = new System.Drawing.Point(521, 176);
            this.cbStudentDelete.Name = "cbStudentDelete";
            this.cbStudentDelete.Size = new System.Drawing.Size(121, 24);
            this.cbStudentDelete.TabIndex = 90;
            this.cbStudentDelete.Text = " Select";
            // 
            // cbStudentUpdate
            // 
            this.cbStudentUpdate.FormattingEnabled = true;
            this.cbStudentUpdate.Location = new System.Drawing.Point(359, 176);
            this.cbStudentUpdate.Name = "cbStudentUpdate";
            this.cbStudentUpdate.Size = new System.Drawing.Size(121, 24);
            this.cbStudentUpdate.TabIndex = 89;
            this.cbStudentUpdate.Text = " Select";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Delete a student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Update a student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "Add a new student";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(299, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 85;
            this.label1.Text = "Stored Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUpdateStudentNum
            // 
            this.tbUpdateStudentNum.Location = new System.Drawing.Point(359, 244);
            this.tbUpdateStudentNum.Name = "tbUpdateStudentNum";
            this.tbUpdateStudentNum.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateStudentNum.TabIndex = 107;
            // 
            // tbUpdateStudentEmail
            // 
            this.tbUpdateStudentEmail.Location = new System.Drawing.Point(359, 279);
            this.tbUpdateStudentEmail.Name = "tbUpdateStudentEmail";
            this.tbUpdateStudentEmail.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateStudentEmail.TabIndex = 108;
            // 
            // tbAddStudentEmail
            // 
            this.tbAddStudentEmail.Location = new System.Drawing.Point(188, 279);
            this.tbAddStudentEmail.Name = "tbAddStudentEmail";
            this.tbAddStudentEmail.Size = new System.Drawing.Size(121, 22);
            this.tbAddStudentEmail.TabIndex = 109;
            // 
            // tbAddStudentNum
            // 
            this.tbAddStudentNum.Location = new System.Drawing.Point(188, 244);
            this.tbAddStudentNum.Name = "tbAddStudentNum";
            this.tbAddStudentNum.Size = new System.Drawing.Size(121, 22);
            this.tbAddStudentNum.TabIndex = 110;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.tbAddStudentNum);
            this.Controls.Add(this.tbAddStudentEmail);
            this.Controls.Add(this.tbUpdateStudentEmail);
            this.Controls.Add(this.tbUpdateStudentNum);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbUpdateStudentName);
            this.Controls.Add(this.tbAddStudentName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStudentDelete);
            this.Controls.Add(this.btnStudentUpdate);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbStudentDelete);
            this.Controls.Add(this.cbStudentUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.Name = "frmStudent";
            this.Text = "LogicOut Timetabling";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnGoToMain;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUpdateStudentName;
        private System.Windows.Forms.TextBox tbAddStudentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentUpdate;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStudentDelete;
        private System.Windows.Forms.ComboBox cbStudentUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUpdateStudentNum;
        private System.Windows.Forms.TextBox tbUpdateStudentEmail;
        private System.Windows.Forms.TextBox tbAddStudentEmail;
        private System.Windows.Forms.TextBox tbAddStudentNum;
    }
}