using System;
using System.Linq;
using System.Windows.Forms;
using Atbash = Atbash.Atbash;

namespace Ash
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {   
            var textIn = richTextBoxIn.Text;
            if (textIn == "" || textIn[0] == ' ')
            {
                MessageBox.Show("Поля пустые или уберите пробел(ы) перед текстом!", "Huh?", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    char setAlphabet = textIn[0];
                    int[] Alphabet = new int[100];
                    int[] eAlphabet = new int[9] {32, 46, 44, 63, 33, 47, 39, 59, 58};
                    if (setAlphabet >= 1040 && setAlphabet <= 1103)
                    {
                        for(int i = 1040; i<=1103; i++)
                        {
                            Alphabet[i - 1031] = i;
                        }
                    }
                    else if (setAlphabet >= 65 && setAlphabet <= 122)
                    {
                        for(int i = 65; i<=150; i++)
                        {
                            Alphabet[i - 56] = i;
                        }
                    }
                    bool close = false;
                    foreach (char symbol in textIn)
                    {
                        if(!Alphabet.Contains((int)symbol) && !eAlphabet.Contains((int)symbol)){MessageBox.Show("Нельзя использовать два разных алфавита!", "Huh?", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            close = true; break;}
                    }

                    if (close == false)
                    {
                        var EncryptText = new global::Atbash.Atbash(richTextBoxIn.Text);
                        richTextBoxOut.Text = EncryptText.Code();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("" + exception, "Huh?", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formLogin = new FormLogin();
            formLogin.Closed += (s, args) => this.Close();
            formLogin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void richTextBoxOut_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}