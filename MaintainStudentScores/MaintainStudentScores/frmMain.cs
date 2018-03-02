using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// David Seng
// Maintain student scores

namespace MaintainStudentScores
{
    public partial class frmMain : Form
    {
     

        public frmMain()
        {
            InitializeComponent();
        }
        private List<Student> students = null;
      
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtAverage.Enabled = false;
            txtScoreCount.Enabled = false;
            txtScoreTotal.Enabled = false;

            students = StudentList.GetStudents();
            FillStudentListBox();
           
         

        }

        private void FillStudentListBox()
        {
            listStudentInfo.Items.Clear();
            foreach (Student s in students)
            {
                listStudentInfo.Items.Add(s.GetDisplayText());
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewStudent addStudentForm = new AddNewStudent();
            Student student = addStudentForm.GetNewStudent();
            if (student != null)
            {
                students.Add(student);
                StudentList.SaveStudents(students);
                FillStudentListBox();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = listStudentInfo.SelectedIndex;
            if (i != -1)
            {
                Student student = (Student)students[i];
                string message = "Are you sure you want to delete "
                    + student.Name + " " + student.Score + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    students.Remove(student);
                    StudentList.SaveStudents(students);
                    FillStudentListBox();
                }
            }
        }
    }
}
