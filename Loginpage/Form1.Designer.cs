namespace Loginpage
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login1 = new System.Windows.Forms.Button();
            this.newuser = new System.Windows.Forms.Button();
            this.panel1pass = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.Label();
            this.textBox2pass = new System.Windows.Forms.TextBox();
            this.ForgetPass = new System.Windows.Forms.Button();
            this.panel1user = new System.Windows.Forms.Panel();
            this.user = new System.Windows.Forms.Label();
            this.textBox1user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1pass.SuspendLayout();
            this.panel1user.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login1
            // 
            this.Login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.Login1.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login1.ForeColor = System.Drawing.Color.White;
            this.Login1.Location = new System.Drawing.Point(884, 386);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(124, 40);
            this.Login1.TabIndex = 6;
            this.Login1.Text = "Login";
            this.Login1.UseVisualStyleBackColor = false;
            this.Login1.Click += new System.EventHandler(this.Login1_Click);
            // 
            // newuser
            // 
            this.newuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.newuser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newuser.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newuser.ForeColor = System.Drawing.Color.White;
            this.newuser.Location = new System.Drawing.Point(759, 453);
            this.newuser.Name = "newuser";
            this.newuser.Size = new System.Drawing.Size(174, 44);
            this.newuser.TabIndex = 7;
            this.newuser.Text = "Create Account";
            this.newuser.UseVisualStyleBackColor = false;
            this.newuser.Click += new System.EventHandler(this.newuser_Click);
            // 
            // panel1pass
            // 
            this.panel1pass.BackColor = System.Drawing.Color.Transparent;
            this.panel1pass.Controls.Add(this.pass);
            this.panel1pass.Controls.Add(this.textBox2pass);
            this.panel1pass.Location = new System.Drawing.Point(761, 328);
            this.panel1pass.Name = "panel1pass";
            this.panel1pass.Size = new System.Drawing.Size(423, 41);
            this.panel1pass.TabIndex = 5;
            // 
            // pass
            // 
            this.pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(15, 6);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(108, 32);
            this.pass.TabIndex = 0;
            this.pass.Text = "Password";
            this.pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2pass
            // 
            this.textBox2pass.Font = new System.Drawing.Font("Arial", 10.2F);
            this.textBox2pass.Location = new System.Drawing.Point(193, 6);
            this.textBox2pass.Name = "textBox2pass";
            this.textBox2pass.Size = new System.Drawing.Size(208, 27);
            this.textBox2pass.TabIndex = 2;
            this.textBox2pass.TextChanged += new System.EventHandler(this.textBox2pass_TextChanged);
            // 
            // ForgetPass
            // 
            this.ForgetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.ForgetPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ForgetPass.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPass.ForeColor = System.Drawing.Color.White;
            this.ForgetPass.Location = new System.Drawing.Point(957, 453);
            this.ForgetPass.Name = "ForgetPass";
            this.ForgetPass.Size = new System.Drawing.Size(177, 44);
            this.ForgetPass.TabIndex = 8;
            this.ForgetPass.Text = "Forget Password";
            this.ForgetPass.UseVisualStyleBackColor = false;
            this.ForgetPass.Click += new System.EventHandler(this.ForgetPass_Click);
            // 
            // panel1user
            // 
            this.panel1user.BackColor = System.Drawing.Color.Transparent;
            this.panel1user.Controls.Add(this.user);
            this.panel1user.Controls.Add(this.textBox1user);
            this.panel1user.Location = new System.Drawing.Point(761, 277);
            this.panel1user.Name = "panel1user";
            this.panel1user.Size = new System.Drawing.Size(423, 41);
            this.panel1user.TabIndex = 4;
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(10, 6);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(147, 32);
            this.user.TabIndex = 0;
            this.user.Text = "Student Name";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1user
            // 
            this.textBox1user.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1user.Location = new System.Drawing.Point(194, 8);
            this.textBox1user.Name = "textBox1user";
            this.textBox1user.Size = new System.Drawing.Size(208, 27);
            this.textBox1user.TabIndex = 2;
            this.textBox1user.TextChanged += new System.EventHandler(this.textBox1user_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(689, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 738);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1user);
            this.Controls.Add(this.ForgetPass);
            this.Controls.Add(this.panel1pass);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.newuser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1pass.ResumeLayout(false);
            this.panel1pass.PerformLayout();
            this.panel1user.ResumeLayout(false);
            this.panel1user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login1;
        private System.Windows.Forms.Button newuser;
        private System.Windows.Forms.Panel panel1pass;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox textBox2pass;
        private System.Windows.Forms.Button ForgetPass;
        private System.Windows.Forms.Panel panel1user;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox textBox1user;
        private System.Windows.Forms.Label label1;
    }
}

