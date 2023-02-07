using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management.Forms
{
    public partial class Passw : Form
    {
        public Passw()
        {
            InitializeComponent();
        }

        private void Passw_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manageMentDataSet.Pass' table. You can move, or remove it, as needed.
            this.passTableAdapter.Fill(this.manageMentDataSet.Pass);

        }

        private void passBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manageMentDataSet);

        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
