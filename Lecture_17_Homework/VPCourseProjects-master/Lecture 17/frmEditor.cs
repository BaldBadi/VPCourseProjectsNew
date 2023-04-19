using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_17
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtxtEditor.SelectionFont = fontDialog1.Font;
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rtxtEditor.SelectionColor = colorDialog1.Color;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtEditor.SelectAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you certain you want to leave?", "Alert!", buttons);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void rtxtEditor_TextChanged(object sender, EventArgs e)
        {

        } private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        rtxtEditor.Copy();
        }

             private void cutToolStripMenuItem_Click(object sender, EventArgs e)
             {
               rtxtEditor.Cut();
             }

              private void PasToolStripMenuItem_Click(object sender, EventArgs e)
              {
                rtxtEditor.Paste();
              }


    }
   
}
