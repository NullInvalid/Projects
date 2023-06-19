using System.Text.RegularExpressions;

namespace PasswordChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = passwordInput.Text;
            int digitCount = 0;
            int letterCount = 0;
            char checker;
            
            Regex input = new Regex("[^A-Za-z0-9]");
            
            bool hasSpecialChars = input.IsMatch(password);
            bool passlengthcheck = password.Length >= 8;
            bool notqualified = false;
            string reqs = string.Empty;

            for(int i = 0; i < password.Length; i++)
            {
                // This loop checks if the password contains a digit or letter
               checker = Char.Parse(password.Substring(i, 1));
                if (char.IsDigit(checker))
                {
                    digitCount++;
                }
                else if (char.IsLetter(checker))
                {
                    letterCount++;
                }
            }

            if (digitCount < 1)
            {
                // This checks if there is at least 1 digit
                reqs += "Must contain at least 1 DIGIT." + Environment.NewLine;
                notqualified = true;
            }
            if (letterCount < 1)
            {
                // This checks if there is at least 1 letter
                reqs += "Must contain at least 1 LETTER." + Environment.NewLine;
                notqualified = true;
            }
            if (hasSpecialChars == false)
            {
                // This checks if password has special characters
                reqs += "Must contain at least 1 SPECIAL CHARACTER." + Environment.NewLine;
                notqualified = true;

            }
            if (passlengthcheck == false)
            {
                // This checks if the password is at least 8 characters long
                reqs += "Must be at least 8 characters." + Environment.NewLine;
                notqualified = true;
            }
            if (notqualified == true)
            {
                // This checks if there are requirements not met and displays them
                MessageBox.Show(reqs);
                passwordInput.Text = "";
            }
            else if(notqualified == false)
            {
                // This checks if there are no deficiencies in the password, if so, displays "QUALIFIED"
                MessageBox.Show("QUALIFIED!");
            }
        }
    }
}