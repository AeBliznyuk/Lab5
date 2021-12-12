using System;
using System.IO;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (Path.GetExtension(openFileDialog.FileName) != ".txt")
                    {
                        throw new Exception("Выбран не тот формат файла");
                    }
                    richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    richTextBox1.Text = ex.Message;
                }
            } 
        }
    }
}
