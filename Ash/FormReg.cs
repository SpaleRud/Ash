using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ash
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }
        
        private void buttonSignUp_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (textBoxLogin.Text=="" && textBoxPassword.Text=="" && textBoxReplyPassword.Text == "")
                {
                    MessageBox.Show("Поля пустые", "Huh?", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPassword.Text == textBoxReplyPassword.Text)
                {
                    SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\zakha\\Documents\\Coding\\Kurs\\Ash\\Ash\\Database.mdf;Integrated Security=True");
                    var password = md5.hashPassword(textBoxPassword.Text);
                    string insert = "insert into [Users](username, password) values('" + textBoxLogin.Text + "', '" + password + "')";
                    SqlCommand cmd = new SqlCommand(insert, sqlcon);
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Аккаунт создан", "Yeap", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var formLogin = new FormLogin();
                    formLogin.Closed += (s, args) => this.Close();
                    formLogin.Show();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Huh?", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("" + exception, "Huh?", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxLogin_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}