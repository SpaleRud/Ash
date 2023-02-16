using System.ComponentModel;

namespace Ash
{
    partial class FormMain
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
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.richTextBoxIn = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(12, 256);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(88, 23);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(505, 256);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxIn
            // 
            this.richTextBoxIn.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxIn.Name = "richTextBoxIn";
            this.richTextBoxIn.Size = new System.Drawing.Size(278, 238);
            this.richTextBoxIn.TabIndex = 4;
            this.richTextBoxIn.Text = "";
            // 
            // richTextBoxOut
            // 
            this.richTextBoxOut.Location = new System.Drawing.Point(307, 12);
            this.richTextBoxOut.Name = "richTextBoxOut";
            this.richTextBoxOut.Size = new System.Drawing.Size(273, 238);
            this.richTextBoxOut.TabIndex = 5;
            this.richTextBoxOut.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(593, 284);
            this.Controls.Add(this.richTextBoxOut);
            this.Controls.Add(this.richTextBoxIn);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConvert);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASH";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox richTextBoxIn;
        private System.Windows.Forms.RichTextBox richTextBoxOut;

        private System.Windows.Forms.RichTextBox richTextBoxIn2;
        private System.Windows.Forms.RichTextBox richTextBoxOut2;
        private System.Windows.Forms.Button buttonConvert;

        #endregion

        private System.Windows.Forms.Button buttonExit;
    }
}