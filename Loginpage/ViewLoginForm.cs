using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Loginpage
{
    public partial class ViewLoginForm : Form
    {
        private Student student;
        private const string DataFilePath = "students.txt";


        public ViewLoginForm(Student student)
        {
            InitializeComponent();
            this.student = student;
            
            DisplayStudentDetails();
        }
     
        private void DisplayStudentDetails()
        {
            if (student != null)
            {
                //textBoxStudentName.Text = student.StudentName;
                textBox4id.Text = student.Details.StudentID;
                textBox1usernew.Text = student.Details.StudentName;
                radioButton1.Checked = student.Details.Gender == "Male";
                fema.Checked = student.Details.Gender == "Female";
                Ager.Text = student.Details.Age;
                textBox2num.Text = student.Details.MobileNumber;
                textBox3moth.Text = student.Details.MotherName;
                textBox2fath.Text = student.Details.FatherName;
                richTextBox1.Text = student.Details.Address;
                if (!string.IsNullOrEmpty(student.Details.ImagePath))
                {
                    pictureBox2.ImageLocation = student.Details.ImagePath;
                }
            }
        }
        private bool IsValidDate(DateTime date)
        {
            // Check if the date is within a reasonable range for your application
            return (date > DateTime.MinValue && date < DateTime.MaxValue);
        }

        private void textBox4id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1add_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            var students = LoadStudents();
            var updatedStudents = students.Where(s => s.StudentName != student.StudentName).ToList();

            SaveStudents(updatedStudents);
            MessageBox.Show("Account deleted successfully.");

            this.Close();

        }
        private List<Student> LoadStudents()
        {
            var students = new List<Student>();
            if (File.Exists(DataFilePath))
            {
                var lines = File.ReadAllLines(DataFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 3)
                    {
                        var student = new Student
                        {
                            StudentName = parts[0],
                            Password = parts[1],
                            Details = new StudentDetails
                            {
                                StudentID = parts[2],
                                StudentName = parts[3],
                                Gender = parts[4],
                                Age = parts[5],
                                MobileNumber = parts[6],
                                MotherName = parts[6],
                                FatherName = parts[7],
                                Address = parts[7],
                                ImagePath = parts.Length > 10 ? parts[10] : string.Empty
                            }
                        };
                        students.Add(student);
                    }
                }
            }
            return students;
        }
        private void SaveStudents(List<Student> students)
        {
            var lines = students.Select(s => $"{s.StudentName}|{s.Password}|{s.Details.StudentID}|{s.Details.Gender}|{s.Details.Age}|{s.Details.MobileNumber}|{s.Details.MotherName}|{s.Details.FatherName}|{s.Details.Address}|{s.Details.ImagePath}");
            File.WriteAllLines(DataFilePath, lines);
        }

        private void Exi_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1usernew_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
