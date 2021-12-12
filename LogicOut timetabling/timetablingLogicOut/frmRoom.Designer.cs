namespace timetablingLogicOut
{
    partial class frmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoom));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.viewRoomBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUpdateRoomMinC = new System.Windows.Forms.TextBox();
            this.tbAddRoomMinC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUpdateRoomMaxC = new System.Windows.Forms.TextBox();
            this.tbAddRoomMaxC = new System.Windows.Forms.TextBox();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.btnUpdateUpdate = new System.Windows.Forms.Button();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUpdateRoomName = new System.Windows.Forms.TextBox();
            this.tbAddRoomName = new System.Windows.Forms.TextBox();
            this.cbRoomDelete = new System.Windows.Forms.ComboBox();
            this.cbUpdateRoom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.addRoomComment = new System.Windows.Forms.TextBox();
            this.tbUpdateRoomComments = new System.Windows.Forms.TextBox();
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
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // viewRoomBtn
            // 
            this.viewRoomBtn.BackColor = System.Drawing.Color.White;
            this.viewRoomBtn.ForeColor = System.Drawing.Color.Black;
            this.viewRoomBtn.Location = new System.Drawing.Point(580, 35);
            this.viewRoomBtn.Name = "viewRoomBtn";
            this.viewRoomBtn.Size = new System.Drawing.Size(121, 26);
            this.viewRoomBtn.TabIndex = 81;
            this.viewRoomBtn.Text = "View Rooms";
            this.viewRoomBtn.UseVisualStyleBackColor = false;
            this.viewRoomBtn.Click += new System.EventHandler(this.viewRoomBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(42, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Minimum Capacity";
            // 
            // tbUpdateRoomMinC
            // 
            this.tbUpdateRoomMinC.Location = new System.Drawing.Point(347, 275);
            this.tbUpdateRoomMinC.Name = "tbUpdateRoomMinC";
            this.tbUpdateRoomMinC.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateRoomMinC.TabIndex = 79;
            // 
            // tbAddRoomMinC
            // 
            this.tbAddRoomMinC.Location = new System.Drawing.Point(184, 275);
            this.tbAddRoomMinC.Name = "tbAddRoomMinC";
            this.tbAddRoomMinC.Size = new System.Drawing.Size(121, 22);
            this.tbAddRoomMinC.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(42, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "Maximum Capacity";
            // 
            // tbUpdateRoomMaxC
            // 
            this.tbUpdateRoomMaxC.Location = new System.Drawing.Point(347, 235);
            this.tbUpdateRoomMaxC.Name = "tbUpdateRoomMaxC";
            this.tbUpdateRoomMaxC.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateRoomMaxC.TabIndex = 76;
            // 
            // tbAddRoomMaxC
            // 
            this.tbAddRoomMaxC.Location = new System.Drawing.Point(184, 235);
            this.tbAddRoomMaxC.Name = "tbAddRoomMaxC";
            this.tbAddRoomMaxC.Size = new System.Drawing.Size(121, 22);
            this.tbAddRoomMaxC.TabIndex = 75;
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.Location = new System.Drawing.Point(530, 366);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Size = new System.Drawing.Size(75, 26);
            this.btnRoomDelete.TabIndex = 74;
            this.btnRoomDelete.Text = "Delete";
            this.btnRoomDelete.UseVisualStyleBackColor = true;
            this.btnRoomDelete.Click += new System.EventHandler(this.btnRoomDelete_Click);
            // 
            // btnUpdateUpdate
            // 
            this.btnUpdateUpdate.Location = new System.Drawing.Point(369, 366);
            this.btnUpdateUpdate.Name = "btnUpdateUpdate";
            this.btnUpdateUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnUpdateUpdate.TabIndex = 73;
            this.btnUpdateUpdate.Text = "Update";
            this.btnUpdateUpdate.UseVisualStyleBackColor = true;
            this.btnUpdateUpdate.Click += new System.EventHandler(this.btnUpdateUpdate_Click);
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.Location = new System.Drawing.Point(204, 366);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(75, 26);
            this.btnRoomAdd.TabIndex = 72;
            this.btnRoomAdd.Text = "Add";
            this.btnRoomAdd.UseVisualStyleBackColor = true;
            this.btnRoomAdd.Click += new System.EventHandler(this.btnRoomAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(42, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(42, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Room";
            // 
            // tbUpdateRoomName
            // 
            this.tbUpdateRoomName.Location = new System.Drawing.Point(347, 194);
            this.tbUpdateRoomName.Name = "tbUpdateRoomName";
            this.tbUpdateRoomName.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateRoomName.TabIndex = 69;
            // 
            // tbAddRoomName
            // 
            this.tbAddRoomName.Location = new System.Drawing.Point(184, 194);
            this.tbAddRoomName.Name = "tbAddRoomName";
            this.tbAddRoomName.Size = new System.Drawing.Size(121, 22);
            this.tbAddRoomName.TabIndex = 68;
            // 
            // cbRoomDelete
            // 
            this.cbRoomDelete.FormattingEnabled = true;
            this.cbRoomDelete.Location = new System.Drawing.Point(504, 152);
            this.cbRoomDelete.Name = "cbRoomDelete";
            this.cbRoomDelete.Size = new System.Drawing.Size(121, 24);
            this.cbRoomDelete.TabIndex = 67;
            // 
            // cbUpdateRoom
            // 
            this.cbUpdateRoom.FormattingEnabled = true;
            this.cbUpdateRoom.Location = new System.Drawing.Point(347, 152);
            this.cbUpdateRoom.Name = "cbUpdateRoom";
            this.cbUpdateRoom.Size = new System.Drawing.Size(121, 24);
            this.cbUpdateRoom.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Delete a room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Update a room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Add a new room";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(323, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "Stored Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoToMain
            // 
            this.btnGoToMain.BackColor = System.Drawing.Color.Black;
            this.btnGoToMain.ForeColor = System.Drawing.Color.White;
            this.btnGoToMain.Location = new System.Drawing.Point(563, 459);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(157, 32);
            this.btnGoToMain.TabIndex = 82;
            this.btnGoToMain.Text = "Go back to main";
            this.btnGoToMain.UseVisualStyleBackColor = false;
            this.btnGoToMain.Click += new System.EventHandler(this.btnGoToMain_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Khaki;
            this.label9.Location = new System.Drawing.Point(42, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 83;
            this.label9.Text = "Comments";
            // 
            // addRoomComment
            // 
            this.addRoomComment.Location = new System.Drawing.Point(184, 315);
            this.addRoomComment.Name = "addRoomComment";
            this.addRoomComment.Size = new System.Drawing.Size(121, 22);
            this.addRoomComment.TabIndex = 84;
            // 
            // tbUpdateRoomComments
            // 
            this.tbUpdateRoomComments.Location = new System.Drawing.Point(347, 315);
            this.tbUpdateRoomComments.Name = "tbUpdateRoomComments";
            this.tbUpdateRoomComments.Size = new System.Drawing.Size(121, 22);
            this.tbUpdateRoomComments.TabIndex = 85;
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.tbUpdateRoomComments);
            this.Controls.Add(this.addRoomComment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.viewRoomBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbUpdateRoomMinC);
            this.Controls.Add(this.tbAddRoomMinC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUpdateRoomMaxC);
            this.Controls.Add(this.tbAddRoomMaxC);
            this.Controls.Add(this.btnRoomDelete);
            this.Controls.Add(this.btnUpdateUpdate);
            this.Controls.Add(this.btnRoomAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUpdateRoomName);
            this.Controls.Add(this.tbAddRoomName);
            this.Controls.Add(this.cbRoomDelete);
            this.Controls.Add(this.cbUpdateRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.Name = "frmRoom";
            this.Text = "LogicOut Timetabling";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button viewRoomBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUpdateRoomMinC;
        private System.Windows.Forms.TextBox tbAddRoomMinC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUpdateRoomMaxC;
        private System.Windows.Forms.TextBox tbAddRoomMaxC;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.Button btnUpdateUpdate;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUpdateRoomName;
        private System.Windows.Forms.TextBox tbAddRoomName;
        private System.Windows.Forms.ComboBox cbRoomDelete;
        private System.Windows.Forms.ComboBox cbUpdateRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToMain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addRoomComment;
        private System.Windows.Forms.TextBox tbUpdateRoomComments;
    }
}