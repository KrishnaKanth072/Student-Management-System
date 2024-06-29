namespace Loginpage
{
    partial class LoginForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.confrim = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1user = new System.Windows.Forms.Panel();
            this.usernew = new System.Windows.Forms.Label();
            this.textBox1usernew = new System.Windows.Forms.TextBox();
            this.panel1pass = new System.Windows.Forms.Panel();
            this.passnew = new System.Windows.Forms.Label();
            this.textBox2passnew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subm = new System.Windows.Forms.Button();
            this.backer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel1user.SuspendLayout();
            this.panel1pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.confrim);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(320, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 41);
            this.panel1.TabIndex = 11;
            // 
            // confrim
            // 
            this.confrim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.confrim.AutoSize = true;
            this.confrim.BackColor = System.Drawing.Color.Transparent;
            this.confrim.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrim.ForeColor = System.Drawing.Color.White;
            this.confrim.Location = new System.Drawing.Point(7, 6);
            this.confrim.Name = "confrim";
            this.confrim.Size = new System.Drawing.Size(185, 32);
            this.confrim.TabIndex = 0;
            this.confrim.Text = "Confrim Password";
            this.confrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(219, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1user
            // 
            this.panel1user.BackColor = System.Drawing.Color.Transparent;
            this.panel1user.Controls.Add(this.usernew);
            this.panel1user.Controls.Add(this.textBox1usernew);
            this.panel1user.Location = new System.Drawing.Point(320, 285);
            this.panel1user.Name = "panel1user";
            this.panel1user.Size = new System.Drawing.Size(587, 41);
            this.panel1user.TabIndex = 9;
            // 
            // usernew
            // 
            this.usernew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernew.AutoSize = true;
            this.usernew.BackColor = System.Drawing.Color.Transparent;
            this.usernew.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernew.ForeColor = System.Drawing.Color.White;
            this.usernew.Location = new System.Drawing.Point(4, 6);
            this.usernew.Name = "usernew";
            this.usernew.Size = new System.Drawing.Size(147, 32);
            this.usernew.TabIndex = 0;
            this.usernew.Text = "Student Name";
            this.usernew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1usernew
            // 
            this.textBox1usernew.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1usernew.Location = new System.Drawing.Point(219, 6);
            this.textBox1usernew.Name = "textBox1usernew";
            this.textBox1usernew.Size = new System.Drawing.Size(364, 27);
            this.textBox1usernew.TabIndex = 2;
            this.textBox1usernew.TextChanged += new System.EventHandler(this.textBox1usernew_TextChanged);
            // 
            // panel1pass
            // 
            this.panel1pass.BackColor = System.Drawing.Color.Transparent;
            this.panel1pass.Controls.Add(this.passnew);
            this.panel1pass.Controls.Add(this.textBox2passnew);
            this.panel1pass.Location = new System.Drawing.Point(320, 341);
            this.panel1pass.Name = "panel1pass";
            this.panel1pass.Size = new System.Drawing.Size(587, 41);
            this.panel1pass.TabIndex = 10;
            // 
            // passnew
            // 
            this.passnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.passnew.AutoSize = true;
            this.passnew.BackColor = System.Drawing.Color.Transparent;
            this.passnew.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passnew.ForeColor = System.Drawing.Color.White;
            this.passnew.Location = new System.Drawing.Point(12, 6);
            this.passnew.Name = "passnew";
            this.passnew.Size = new System.Drawing.Size(108, 32);
            this.passnew.TabIndex = 0;
            this.passnew.Text = "Password";
            this.passnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2passnew
            // 
            this.textBox2passnew.Font = new System.Drawing.Font("Arial", 10.2F);
            this.textBox2passnew.Location = new System.Drawing.Point(218, 6);
            this.textBox2passnew.Name = "textBox2passnew";
            this.textBox2passnew.Size = new System.Drawing.Size(364, 27);
            this.textBox2passnew.TabIndex = 2;
            this.textBox2passnew.TextChanged += new System.EventHandler(this.textBox2passnew_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Create Student  Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // subm
            // 
            this.subm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.subm.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subm.ForeColor = System.Drawing.Color.White;
            this.subm.Location = new System.Drawing.Point(405, 467);
            this.subm.Name = "subm";
            this.subm.Size = new System.Drawing.Size(161, 49);
            this.subm.TabIndex = 16;
            this.subm.Text = "Submit";
            this.subm.UseVisualStyleBackColor = false;
            this.subm.Click += new System.EventHandler(this.subm_Click);
            // 
            // backer
            // 
            this.backer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.backer.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backer.ForeColor = System.Drawing.Color.White;
            this.backer.Location = new System.Drawing.Point(736, 467);
            this.backer.Name = "backer";
            this.backer.Size = new System.Drawing.Size(161, 49);
            this.backer.TabIndex = 17;
            this.backer.Text = "Next";
            this.backer.UseVisualStyleBackColor = false;
            this.backer.Click += new System.EventHandler(this.backer_Click);
            // 
            // LoginForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 738);
            this.Controls.Add(this.backer);
            this.Controls.Add(this.subm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1user);
            this.Controls.Add(this.panel1pass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Student Account";
            this.Load += new System.EventHandler(this.LoginForm3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel1user.ResumeLayout(false);
            this.panel1user.PerformLayout();
            this.panel1pass.ResumeLayout(false);
            this.panel1pass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label confrim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1user;
        private System.Windows.Forms.Label usernew;
        private System.Windows.Forms.TextBox textBox1usernew;
        private System.Windows.Forms.Panel panel1pass;
        private System.Windows.Forms.Label passnew;
        private System.Windows.Forms.TextBox textBox2passnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button subm;
        private System.Windows.Forms.Button backer;
    }
}