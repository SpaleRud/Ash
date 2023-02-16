using System.ComponentModel;

namespace Ash
{
    partial class FormAuth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.labelNameForm = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelReplyPassword = new System.Windows.Forms.Label();
            this.textBoxReplyPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNameForm
            // 
            this.labelNameForm.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameForm.Location = new System.Drawing.Point(12, 9);
            this.labelNameForm.Name = "labelNameForm";
            this.labelNameForm.Size = new System.Drawing.Size(195, 34);
            this.labelNameForm.TabIndex = 13;
            this.labelNameForm.Text = "Sign up Ash\r\n";
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(166, 92);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 23);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(166, 46);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(58, 23);
            this.labelLogin.TabIndex = 11;
            this.labelLogin.Text = "Login";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Calibri", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.Location = new System.Drawing.Point(12, 175);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(102, 27);
            this.buttonSignUp.TabIndex = 10;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 89);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(148, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 46);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(148, 20);
            this.textBoxLogin.TabIndex = 7;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelReplyPassword
            // 
            this.labelReplyPassword.Font = new System.Drawing.Font("Calibri", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReplyPassword.Location = new System.Drawing.Point(166, 138);
            this.labelReplyPassword.Name = "labelReplyPassword";
            this.labelReplyPassword.Size = new System.Drawing.Size(114, 23);
            this.labelReplyPassword.TabIndex = 15;
            this.labelReplyPassword.Text = "Reply Password";
            // 
            // textBoxReplyPassword
            // 
            this.textBoxReplyPassword.Location = new System.Drawing.Point(12, 135);
            this.textBoxReplyPassword.Name = "textBoxReplyPassword";
            this.textBoxReplyPassword.PasswordChar = '*';
            this.textBoxReplyPassword.Size = new System.Drawing.Size(148, 20);
            this.textBoxReplyPassword.TabIndex = 14;
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(285, 218);
            this.Controls.Add(this.labelReplyPassword);
            this.Controls.Add(this.textBoxReplyPassword);
            this.Controls.Add(this.labelNameForm);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuth";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAuth";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelNameForm;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelReplyPassword;
        private System.Windows.Forms.TextBox textBoxReplyPassword;

        #endregion
    }
}