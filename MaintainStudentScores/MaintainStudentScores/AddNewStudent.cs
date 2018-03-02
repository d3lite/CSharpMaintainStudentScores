using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintainStudentScores
{
    public partial class AddNewStudent : Form
    {
        

        public AddNewStudent()
        {
            InitializeComponent();
            txtScores.Enabled = false;

        }
        private Student student = null;
        
        public Student GetNewStudent()
        {
            this.ShowDialog();
            return student;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          
          
                student = new Student(txtName.Text, int.Parse(txtScore.Text)
                    );
                this.Close();
            

        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            student = new Student(int.Parse(txtScore.Text));

            txtScores.Text = student.GetDisplayScore();




        }
    }
}
