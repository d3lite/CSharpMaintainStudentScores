namespace MaintainStudentScores
{
    partial class AddNewStudent
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtScores = new System.Windows.Forms.TextBox();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 68);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(12, 110);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(40, 13);
            this.lblScores.TabIndex = 2;
            this.lblScores.Text = "Scores";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(53, 61);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 4;
            // 
            // txtScores
            // 
            this.txtScores.Location = new System.Drawing.Point(53, 103);
            this.txtScores.Name = "txtScores";
            this.txtScores.Size = new System.Drawing.Size(242, 20);
            this.txtScores.TabIndex = 5;
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(220, 129);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(75, 23);
            this.btnClearScores.TabIndex = 6;
            this.btnClearScores.Text = "Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(172, 58);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(75, 23);
            this.btnAddScore.TabIndex = 7;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(139, 179);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.txtScores);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Name = "AddNewStudent";
            this.Text = "AddNewStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtScores;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}