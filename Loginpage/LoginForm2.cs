using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loginpage
{
    public partial class LoginForm2 : Form
    {
        private Student student;
        public LoginForm2(Student student)
        {
            InitializeComponent();
            this.student = student;

        }


       
        private void LoginForm2_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernew_Click(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1user_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Father_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4id_TextChanged(object sender, EventArgs e)
        {

        }

        private void subm_Click(object sender, EventArgs e)
        {
            student.Details.StudentID = textBox4id.Text;
            student.Details.StudentName = textBox1usernew.Text;
            student.Details.Gender = radioButton1.Checked ? "Male" : "Female";
            student.Details.Age = Ager.Text;
            student.Details.MobileNumber = textBox2num.Text;
            student.Details.FatherName = textBox2fath.Text;
            student.Details.MotherName = textBox3moth.Text;
            student.Details.Address = richTextBox1.Text;
            student.Details.ImagePath = stuimag.Text;

            SaveStudentDetails(student);

            MessageBox.Show("Details saved successfully.");
        }
        private void SaveStudentDetails(Student student)
        {
            const string DataFilePath = "students.txt";
            var studentData = $"{student.StudentName}|{student.Password}|{student.Details.StudentID}|{student.Details.StudentName}|{student.Details.Gender}|{student.Details.Age}|{student.Details.MobileNumber}|{student.Details.MotherName}|{student.Details.FatherName}|{student.Details.Address}|{student.Details.ImagePath}";
            File.AppendAllText(DataFilePath, studentData + Environment.NewLine);
        }

        private void textBox1usernew_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2num_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2fath_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3moth_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stuimag_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select a Student Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                stuimag.Text = openFileDialog.FileName;
                pictureBox2.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void backer_Click(object sender, EventArgs e)
        {
            textBox4id.Clear();
            textBox1usernew.Clear();
            radioButton1.Checked = false;
            fema.Checked = false;
            Ager.Clear();
            textBox2num.Clear();
            textBox2fath.Clear();
            textBox3moth.Clear();
            richTextBox1.Clear();
            stuimag.ResetText();
            pictureBox2.Image = null;

        }

        private void fema_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Exi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
