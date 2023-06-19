using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Flames
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
            string yourname = yourName.Text;
            string yourcrush = yourCrush.Text;
            string name1 = string.Empty;
            
           

            int freq = 0;
            string flames = "flames";
            char relation;


            yourname = yourname.Trim().ToLower();
            yourcrush = yourcrush.Trim().ToLower();

            string cleanedName = Regex.Replace(yourname, "\\s+", "");
            string cleanedCrush = Regex.Replace(yourcrush, "\\s+", "");

            string addedname = string.Concat(cleanedName, cleanedCrush);

            //MessageBox.Show(addedname);

            for (int i = 0; i < cleanedName.Length; i++)
            {
                name1 = cleanedName.Substring(i, 1);
                char c = char.Parse(name1);

                if (cleanedCrush.Contains(name1))
                {
                    freq += addedname.Count(f => (f == c));
                    addedname = addedname.Replace(name1,String.Empty);
                }

            }
            //MessageBox.Show("Same : " + freq);
            //MessageBox.Show(addedname);

            // numofsameletters = sameletters.Length;


            //MessageBox.Show("AW " +  numofsameletters);
            if (freq > 6)
            {
                freq = freq % 6;
            }

            if (freq > 0)
            {
                relation = Char.Parse(flames.Substring(freq-1, 1));

                switch (relation)
                {
                    case 'f':
                        MessageBox.Show("FRIENDS");
                        break;
                    case 'l':
                        MessageBox.Show("LOVERS");
                        break;
                    case 'a':
                        MessageBox.Show("ADMIRERS");
                        break;
                    case 'm':
                        MessageBox.Show("MARRIAGE");
                        break;
                    case 'e':
                        MessageBox.Show("ENEMIES");
                        break;
                    case 's':
                        MessageBox.Show("SWEETHEARTS");
                        break;
                    default:
                        break;

                }
            }
            else
            {
                MessageBox.Show("Not Match");
            }
                       

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}