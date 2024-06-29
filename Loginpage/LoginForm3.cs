using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Loginpage
{
    public partial class LoginForm3 : Form
    {
        private Student newStudent;
        private const string DataFilePath = "students.txt";
        public LoginForm3()
        {
            InitializeComponent();
           
            
        }

        private void subm_Click(object sender, EventArgs e)
        {
            string studentName = textBox1usernew.Text;
            string password = textBox2passnew.Text;
            string confirmPassword = textBox1.Text;

            if (string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            var students = LoadStudents();
            var existingStudent = students.FirstOrDefault(s => s.StudentName == studentName);

            if (existingStudent != null)
            {
                MessageBox.Show("A student with this name is already registered. Please choose a different name.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            newStudent = new Student
            {
                StudentName = studentName,
                Password = password,
                Details = new StudentDetails()
            };

            MessageBox.Show("Registration successful.");
        }

        private void textBox1usernew_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2passnew_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backer_Click(object sender, EventArgs e)
        {
            if (newStudent == null)
            {
                MessageBox.Show("Please complete the registration process first.");
                return;
            }

            this.Hide();
            var detailsForm = new LoginForm2(newStudent);
            detailsForm.ShowDialog();
            this.Close();
        }

        
        private void SaveStudentDetails(string studentName, string password)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                                MotherName = parts[7],
                                FatherName = parts[8],
                                Address = parts[9],
                                ImagePath = parts.Length > 10 ? parts[10] : string.Empty
                            }
                        };
                        students.Add(student);
                    }
                }
            }
            return students;
        }

        private void LoginForm3_Load(object sender, EventArgs e)
        {

        }
    }
}
