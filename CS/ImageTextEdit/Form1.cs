using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageTextEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customIconTextEdit1_Properties_OnIconSelection(object sender, OnIconSelectionEventArgs e)
        {
            CustomIconTextEdit editor = sender as CustomIconTextEdit;
            if (editor != null)
            {
                if (editor.Enabled)
                    if (editor.ContainsFocus)
                        e.ImageIndex = 0;
                    else
                        e.ImageIndex = 1;
                else
                    e.ImageIndex = 2;

            }
        }

        private void customIconTextEdit1_IconClick(object sender, MouseEventArgs e)
        {
            CustomIconTextEdit editor = sender as CustomIconTextEdit;
            if (editor != null)
            {
                this.Text = editor.Name + ".Text = " + editor.Text;
            }
        }
    }
}