using Microsoft.Rest.ClientRuntime.Azure.Authentication.Utilities;
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
    public partial class FRlock : Form
    {
        
        public FRlock()
        {
            
            InitializeComponent();
        }

        private void FRlock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manageMentDataSet.Pass' table. You can move, or remove it, as needed.
            this.passTableAdapter.Fill(this.manageMentDataSet.Pass);
            // TODO: This line of code loads data into the 'databaseDataSet.Manage' table. You can move, or remove it, as needed.
            //this.manageTableAdapter.Fill(this.databaseDataSet.Manage);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {

        }
        private void enter(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (textBox1.Text == passDataGridView.CurrentRow.Cells[0].Value.ToString())
                {

                    this.Visible = false;
                    label4.Visible = false;
                    Console.Beep(500, 750);

                    List fr = new List();
                    fr.Show();

                }
                else
                {
                    Console.Beep(800, 150);
                    label4.Visible = true;
                }
            }
        }

  
   

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = char.Parse("\0");
            }
            else
                textBox1.PasswordChar = char.Parse("*");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == passDataGridView.CurrentRow.Cells[0].Value.ToString())
            {
                this.Visible = false;
                label4.Visible = false;
                Console.Beep(500, 750);

                List fr = new List();
                fr.Show();



            }
            else
            {
                Console.Beep(800, 150);
                label4.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manageMentDataSet);

        }
    }
}
