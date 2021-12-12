namespace timetablingLogicOut
{
    partial class frmAllocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllocation));
            this.btnGoToMain = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cbSessions = new System.Windows.Forms.ComboBox();
            this.btnAllocated = new System.Windows.Forms.Button();
            this.dgvAllocated = new System.Windows.Forms.DataGridView();
            this.dgvUnallocated = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnallocated)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToMain
            // 
            this.btnGoToMain.BackColor = System.Drawing.Color.Black;
            this.btnGoToMain.ForeColor = System.Drawing.Color.White;
            this.btnGoToMain.Location = new System.Drawing.Point(863, 609);
            this.btnGoToMain.Name = "btnGoToMain";
            this.btnGoToMain.Size = new System.Drawing.Size(157, 32);
            this.btnGoToMain.TabIndex = 84;
            this.btnGoToMain.Text = "Go back to main";
            this.btnGoToMain.UseVisualStyleBackColor = false;
            this.btnGoToMain.Click += new System.EventHandler(this.btnGoToMain_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 576);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(174, 65);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 83;
            this.pbLogo.TabStop = false;
            // 
            // cbSessions
            // 
            this.cbSessions.FormattingEnabled = true;
            this.cbSessions.Location = new System.Drawing.Point(304, 157);
            this.cbSessions.Name = "cbSessions";
            this.cbSessions.Size = new System.Drawing.Size(408, 24);
            this.cbSessions.TabIndex = 86;
            this.cbSessions.SelectedIndexChanged += new System.EventHandler(this.cbSessions_SelectedIndexChanged);
            // 
            // btnAllocated
            // 
            this.btnAllocated.Location = new System.Drawing.Point(398, 76);
            this.btnAllocated.Name = "btnAllocated";
            this.btnAllocated.Size = new System.Drawing.Size(231, 32);
            this.btnAllocated.TabIndex = 88;
            this.btnAllocated.Text = "Allocate students to all sessions";
            this.btnAllocated.UseVisualStyleBackColor = true;
            this.btnAllocated.Click += new System.EventHandler(this.btnAllocated_Click);
            // 
            // dgvAllocated
            // 
            this.dgvAllocated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocated.Location = new System.Drawing.Point(20, 228);
            this.dgvAllocated.Name = "dgvAllocated";
            this.dgvAllocated.RowTemplate.Height = 24;
            this.dgvAllocated.Size = new System.Drawing.Size(491, 326);
            this.dgvAllocated.TabIndex = 89;
            // 
            // dgvUnallocated
            // 
            this.dgvUnallocated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnallocated.Location = new System.Drawing.Point(517, 228);
            this.dgvUnallocated.Name = "dgvUnallocated";
            this.dgvUnallocated.RowTemplate.Height = 24;
            this.dgvUnallocated.Size = new System.Drawing.Size(491, 326);
            this.dgvUnallocated.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(460, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 93;
            this.label3.Text = "Sessions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(185, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 94;
            this.label5.Text = "Allocated Students ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(693, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = "Unallocated Students";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(220, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 96;
            this.label1.Text = "Maximum Capacity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(536, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 97;
            this.label2.Text = "Minimum Capacity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(698, 597);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 98;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(382, 597);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 23);
            this.label7.TabIndex = 99;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 17);
            this.label8.TabIndex = 100;
            this.label8.Text = "Select a session to view the student allocated to it";
            // 
            // frmAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 653);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvUnallocated);
            this.Controls.Add(this.dgvAllocated);
            this.Controls.Add(this.btnAllocated);
            this.Controls.Add(this.cbSessions);
            this.Controls.Add(this.btnGoToMain);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.Name = "frmAllocation";
            this.Text = "LogicOut Timetabling";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnallocated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cbSessions;
        private System.Windows.Forms.Button btnAllocated;
        private System.Windows.Forms.DataGridView dgvAllocated;
        private System.Windows.Forms.DataGridView dgvUnallocated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}