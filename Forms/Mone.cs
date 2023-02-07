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
    public partial class Mone : Form
    {
        public Mone()
        {
            InitializeComponent();
        }

       
        private void refresh()
        {


            

        }

    

        private void Mone_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manageMentDataSet.Money' table. You can move, or remove it, as needed.
            this.moneyTableAdapter.Fill(this.manageMentDataSet.Money);


        }

        private void moneyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void moneyBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void moneyBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

        }

        private void moneyBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.moneyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manageMentDataSet);

        }
    }
}
