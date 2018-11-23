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

namespace Editor1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = saveFileDialog2.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(saveFileDialog2.FileName, richTextBox2.Lines);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {   //
            DialogResult dialogResult = openFileDialog2.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                richTextBox2.Lines = System.IO.File.ReadAllLines(openFileDialog2.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
