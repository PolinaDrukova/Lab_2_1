using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab__2._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;

            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
        
        public string TextBoxValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string word1 = textBox2.Text;
            string word2 = textBox3.Text;

            string text = Program.replace_text(textBox1.Text, word1, word2);
            TextBoxValue = text;
            System.IO.File.WriteAllText(text, textBox1.Text);
        }
    }
}

    

