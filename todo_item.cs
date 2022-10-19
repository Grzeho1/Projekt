using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projekt
{
    public partial class todo_item : UserControl
    {
        public todo_item()
        {
            InitializeComponent();
        }

        private void todo_item_Load(object sender, EventArgs e)
        {

        }
        public todo_item(string Text)
        {
            InitializeComponent();
            label1.Text = Text;
        }
    }
}
