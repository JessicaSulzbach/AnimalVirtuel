using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saveProgress
{
    public partial class Form1 : Form
    {
        List<string> progress = new List<string>();
        string line;
        int num = 0;  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readFile();

            label1.Text = progress[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num++;
            label1.Text = Convert.ToString(num);

        }

        private void saveToFile(string thingsToSave)
        {
            StreamWriter WRITE = new StreamWriter(@"C:\Users\SULZBACHJ_INFO\Desktop\saveProgress\saveProgress\Resources\progress.txt");

            WRITE.WriteLine(thingsToSave);
        }

        private void readFile()
        {
            StreamReader READ = new StreamReader(@"C:\Users\SULZBACHJ_INFO\Desktop\saveProgress\saveProgress\Resources\progress.txt");

            while ((line = READ.ReadLine()) != null)
            {
                progress.Add(line);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveToFile(label1.Text);
            Application.Exit();
        }

        
    }
}
