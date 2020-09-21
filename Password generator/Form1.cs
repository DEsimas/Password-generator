using System;
using System.Windows.Forms;
using System.IO;

namespace Password_generator
{

    public partial class Main : Form
    {
        private Random rand = new Random();
        private string pass = "";
        public int kol = 9;

        public Main()
        {
            InitializeComponent();
        }

        private string gen (string str)
        {
            str = Convert.ToString((char)rand.Next(0x0020,0x007E));
            return str;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            pass = "";
            for (int a = 0; a <= kol; a++)
                pass += gen(pass);
            textBox1.Text = pass;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(pass);
        }

        private void length_TextChanged(object sender, EventArgs e)
        {
            kol = Convert.ToInt32(length.Text) - 1;
        }

        private void File_Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(qantity.Text); i++)
            {
                Generate.PerformClick();
                File.AppendAllText(file_position.Text, textBox1.Text + "\n");
            }
            textBox1.Text = "";
        }
    }
}
