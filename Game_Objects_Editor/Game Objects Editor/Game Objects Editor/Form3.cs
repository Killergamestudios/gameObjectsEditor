using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Objects_Editor
{
    public partial class message0 : Form
    {
        public message0()
        {
            InitializeComponent();

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
