using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS446_Project_LivePrototype
{
    public partial class EditTokenForm : Form
    {
        public EditTokenForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //when token objects have been made change this method
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }
}
