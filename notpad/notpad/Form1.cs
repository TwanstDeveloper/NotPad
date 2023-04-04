using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace notpad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text file(*.txt)|*.txt|All File|*.*";
            op.Title = "Open File";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(op.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();

                }catch(Exception x)
                {

                }
            }
        
        
        
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog op = new SaveFileDialog();
            op.Filter = "Text file(*.txt)|*.txt|All File|*.*";
            op.Title = "Save";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter wr = new StreamWriter(op.FileName);
                    wr.Write(richTextBox1.Text);
                    wr.Close();

                }
                catch (Exception x)
                {

                }
            }

        }

        private void fontColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog CD = new ColorDialog();
            if (CD.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.ForeColor = CD.Color;
            }
        }

        private void fontTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog CD = new FontDialog();
            if (CD.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = CD.Font;
            }
        }
    }
}
