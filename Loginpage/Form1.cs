using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Loginpage.LoginForm3;
using System.IO;

namespace Loginpage
{
    

    public partial class Form1 : Form
    {
        private const string DataFilePath = "students.txt";

        public Form1()
        {
            InitializeComponent();
            CreateFileIfNotExist();
        }
        private void CreateFileIfNotExist()
        {
            if (!File.Exists(DataFilePath))
            {
                File.Create(DataFilePath).Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new LoginForm3();
            registerForm.ShowDialog();
            this.Show();
        }
     


        private void Login1_Click(object sender, EventArgs e)
        {
            string username = textBox1user.Text;
            string password = textBox2pass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var students = LoadStudents();
            var student = students.FirstOrDefault(s => s.StudentName == username && s.Password == password);

            if (student != null)
            {
                this.Hide();
                var viewForm = new ViewLoginForm(student);
                viewForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
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
      
        private void textBox1user_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgetPass_Click(object sender, EventArgs e)
        {
            string username = textBox1user.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.");
                return;
            }

            var students = LoadStudents();
            var student = students.FirstOrDefault(s => s.StudentName == username);

            if (student == null)
            {
                MessageBox.Show("Username not found.");
                return;
            }

            MessageBox.Show($"Your password: {student.Password}");
        }
        private void SaveStudents(List<Student> students)
        {
            var lines = students.Select(s => $"{s.StudentName}|{s.Password}|{s.Details.StudentID}|{s.Details.StudentName}|{s.Details.Gender}|{s.Details.Age}|{s.Details.MobileNumber}|{s.Details.MotherName}|{s.Details.FatherName}|{s.Details.Address}|{s.Details.ImagePath}");
            File.WriteAllLines(DataFilePath, lines);
        }


        public void DeleteStudent(string studentName)
        {
            
        }
    }
}
