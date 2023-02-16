using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ash
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelNameForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 46);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(148, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 89);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(148, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Font = new System.Drawing.Font("Calibri", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignIn.Location = new System.Drawing.Point(12, 124);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(104, 27);
            this.buttonSignIn.TabIndex = 2;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Calibri", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.Location = new System.Drawing.Point(142, 124);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(102, 27);
            this.buttonSignUp.TabIndex = 3;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(166, 46);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(58, 23);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(166, 92);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 23);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // labelNameForm
            // 
            this.labelNameForm.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameForm.Location = new System.Drawing.Point(12, 9);
            this.labelNameForm.Name = "labelNameForm";
            this.labelNameForm.Size = new System.Drawing.Size(195, 34);
            this.labelNameForm.TabIndex = 6;
            this.labelNameForm.Text = "Sign in Ash";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(249, 162);
            this.Controls.Add(this.labelNameForm);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelNameForm;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;

        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;

        private System.Windows.Forms.Button buttonSignIn;

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\zakha\\Documents\\Coding\\Kurs\\Ash\\Ash\\Database.mdf;Integrated Security=True");
                var password = md5.hashPassword(textBoxPassword.Text);
                string query = "select * from Users where username = '"+textBoxLogin.Text.Trim()+"' and password = '"+password+"'";
                SqlDataAdapter sqlda = new SqlDataAdapter(query, sqlcon);
                DataTable DT = new DataTable();
                sqlda.Fill(DT);

                if (DT.Rows.Count == 1)
                {
                    this.Hide();
                    var formMain = new FormMain();
                    formMain.Closed += (s, args) => this.Close();
                    formMain.Show();
                }
                else if (DT.Rows.Count <= 0)
                {
                    MessageBox.Show("Логин или пароль неправильный", "Huh?", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("" + exception, "Huh?", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formAuth = new FormAuth();
            formAuth.Closed += (s, args) => this.Close();
            formAuth.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}