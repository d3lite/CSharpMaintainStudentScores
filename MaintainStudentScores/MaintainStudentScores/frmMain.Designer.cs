namespace MaintainStudentScores
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
            this.lblStudents = new System.Windows.Forms.Label();
            this.listStudentInfo = new System.Windows.Forms.ListBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(12, 21);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(52, 13);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "Students:";
            // 
            // listStudentInfo
            // 
            this.listStudentInfo.FormattingEnabled = true;
            this.listStudentInfo.Location = new System.Drawing.Point(12, 47);
            this.listStudentInfo.Name = "listStudentInfo";
            this.listStudentInfo.Size = new System.Drawing.Size(300, 160);
            this.listStudentInfo.TabIndex = 1;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(216, 278);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(47, 13);
            this.lblAverage.TabIndex = 2;
            this.lblAverage.Text = "Average";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Location = new System.Drawing.Point(191, 252);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(65, 13);
            this.lblScoreCount.TabIndex = 3;
            this.lblScoreCount.Text = "Score count";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(198, 228);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(58, 13);
            this.lblScoreTotal.TabIndex = 4;
            this.lblScoreTotal.Text = "Score total";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(330, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(330, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(330, 60);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 7;
            this.btnAddNew.Text = "Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(269, 271);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(43, 20);
            this.txtAverage.TabIndex = 8;
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(269, 245);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.Size = new System.Drawing.Size(43, 20);
            this.txtScoreCount.TabIndex = 9;
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(269, 221);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.Size = new System.Drawing.Size(43, 20);
            this.txtScoreTotal.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(330, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 349);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.listStudentInfo);
            this.Controls.Add(this.lblStudents);
            this.Name = "frmMain";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.ListBox listStudentInfo;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.Button btnExit;
    }
}

