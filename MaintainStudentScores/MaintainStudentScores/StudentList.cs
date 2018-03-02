using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaintainStudentScores
{
    class StudentList 
    {
        private const string dir = @"C:\Desktop\";
        private const string path = dir + "Customers.txt";

        public static void SaveStudents(List<Student> students)
        {
            // create the output stream for a text file that exists
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            // write each customer
            foreach (Student student in students)
            {
                textOut.Write(student.Name + "|");
                textOut.Write(student.Score + "|");
               
            }

            // write the end of the document
            textOut.Close();
        }
        public static List<Student> GetStudents()
        {
            // if the directory doesn't exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the array list for customers
            List<Student> students = new List<Student>();

            // read the data from the file and store it in the ArrayList
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Student student = new Student();
                student.Name = columns[0];
                student.Score = int.Parse(columns[1]);
            
                students.Add(student);
            }

            textIn.Close();

            return students;
        }

    }
}
