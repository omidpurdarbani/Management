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
    public partial class List : Form
    {
        
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manageMentDataSet.Pass' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'manageMentDataSet1.Money' table. You can move, or remove it, as needed.
            //this.moneyTableAdapter1.Fill(this.manageMentDataSet1.Money);

            // TODO: This line of code loads data into the 'manageMentDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.manageMentDataSet.Data);
            
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            System.Windows.Forms.Label subjectLabel1;
            System.Windows.Forms.Label take_InLabel1;
            System.Windows.Forms.Label take_OutLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.manageMentDataSet = new Management.ManageMentDataSet();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableAdapter = new Management.ManageMentDataSetTableAdapters.DataTableAdapter();
            this.tableAdapterManager = new Management.ManageMentDataSetTableAdapters.TableAdapterManager();
            this.dataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.subjectTextBox2 = new System.Windows.Forms.TextBox();
            this.take_InNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.take_OutNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.moneyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.moneyTableAdapter = new Management.ManageMentDataSetTableAdapters.MoneyTableAdapter();
            this.moneyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            dateLabel1 = new System.Windows.Forms.Label();
            subjectLabel1 = new System.Windows.Forms.Label();
            take_InLabel1 = new System.Windows.Forms.Label();
            take_OutLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manageMentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.take_InNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.take_OutNumericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel1
            // 
            resources.ApplyResources(dateLabel1, "dateLabel1");
            dateLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dateLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dateLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dateLabel1.Name = "dateLabel1";
            // 
            // subjectLabel1
            // 
            resources.ApplyResources(subjectLabel1, "subjectLabel1");
            subjectLabel1.Name = "subjectLabel1";
            // 
            // take_InLabel1
            // 
            resources.ApplyResources(take_InLabel1, "take_InLabel1");
            take_InLabel1.Name = "take_InLabel1";
            // 
            // take_OutLabel1
            // 
            resources.ApplyResources(take_OutLabel1, "take_OutLabel1");
            take_OutLabel1.Name = "take_OutLabel1";
            // 
            // manageMentDataSet
            // 
            this.manageMentDataSet.DataSetName = "ManageMentDataSet";
            this.manageMentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "Data";
            this.dataBindingSource.DataSource = this.manageMentDataSet;
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataTableAdapter = this.dataTableAdapter;
            this.tableAdapterManager.MoneyTableAdapter = null;
            this.tableAdapterManager.PassTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Management.ManageMentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataDataGridView
            // 
            resources.ApplyResources(this.dataDataGridView, "dataDataGridView");
            this.dataDataGridView.AllowUserToAddRows = false;
            this.dataDataGridView.AllowUserToDeleteRows = false;
            this.dataDataGridView.AutoGenerateColumns = false;
            this.dataDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataDataGridView.DataSource = this.dataBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataDataGridView.Name = "dataDataGridView";
            this.dataDataGridView.ReadOnly = true;
            this.dataDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Subject";
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Take_In";
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Take_Out";
            resources.ApplyResources(this.dataGridViewTextBoxColumn11, "dataGridViewTextBoxColumn11");
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dateDateTimePicker1
            // 
            resources.ApplyResources(this.dateDateTimePicker1, "dateDateTimePicker1");
            this.dateDateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateDateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateDateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateDateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateDateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataBindingSource, "Date", true));
            this.dateDateTimePicker1.Name = "dateDateTimePicker1";
            this.dateDateTimePicker1.Value = new System.DateTime(2021, 4, 27, 22, 57, 54, 0);
            // 
            // subjectTextBox2
            // 
            this.subjectTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subjectTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBindingSource, "Subject", true));
            resources.ApplyResources(this.subjectTextBox2, "subjectTextBox2");
            this.subjectTextBox2.Name = "subjectTextBox2";
            this.subjectTextBox2.TextChanged += new System.EventHandler(this.subjectTextBox2_TextChanged);
            // 
            // take_InNumericUpDown1
            // 
            this.take_InNumericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.take_InNumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataBindingSource, "Take_In", true));
            resources.ApplyResources(this.take_InNumericUpDown1, "take_InNumericUpDown1");
            this.take_InNumericUpDown1.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.take_InNumericUpDown1.Name = "take_InNumericUpDown1";
            this.take_InNumericUpDown1.ValueChanged += new System.EventHandler(this.take_InNumericUpDown1_ValueChanged);
            // 
            // take_OutNumericUpDown1
            // 
            this.take_OutNumericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.take_OutNumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataBindingSource, "Take_Out", true));
            resources.ApplyResources(this.take_OutNumericUpDown1, "take_OutNumericUpDown1");
            this.take_OutNumericUpDown1.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.take_OutNumericUpDown1.Name = "take_OutNumericUpDown1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.take_OutNumericUpDown1);
            this.groupBox1.Controls.Add(this.take_InNumericUpDown1);
            this.groupBox1.Controls.Add(this.subjectTextBox2);
            this.groupBox1.Controls.Add(this.dateDateTimePicker1);
            this.groupBox1.Controls.Add(dateLabel1);
            this.groupBox1.Controls.Add(subjectLabel1);
            this.groupBox1.Controls.Add(take_InLabel1);
            this.groupBox1.Controls.Add(take_OutLabel1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.moneyDataGridView);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moneyDataGridView
            // 
            this.moneyDataGridView.AllowUserToAddRows = false;
            this.moneyDataGridView.AllowUserToDeleteRows = false;
            this.moneyDataGridView.AutoGenerateColumns = false;
            this.moneyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moneyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn19});
            this.moneyDataGridView.DataSource = this.moneyBindingSource;
            resources.ApplyResources(this.moneyDataGridView, "moneyDataGridView");
            this.moneyDataGridView.Name = "moneyDataGridView";
            this.moneyDataGridView.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Money";
            resources.ApplyResources(this.dataGridViewTextBoxColumn12, "dataGridViewTextBoxColumn12");
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ID";
            resources.ApplyResources(this.dataGridViewTextBoxColumn19, "dataGridViewTextBoxColumn19");
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // moneyBindingSource
            // 
            this.moneyBindingSource.DataMember = "Money";
            this.moneyBindingSource.DataSource = this.manageMentDataSet;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // moneyTableAdapter
            // 
            this.moneyTableAdapter.ClearBeforeFill = true;
            // 
            // moneyBindingSource1
            // 
            this.moneyBindingSource1.DataMember = "Money";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // List
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "List";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageMentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.take_InNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.take_OutNumericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //save
            //this.Validate();
            //this.dataBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.manageMentDataSet);
            // todo :)
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // todo :)
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // todo :)
        }

        private void take_InNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validate();
            dataBindingSource.EndEdit();
            dataTableAdapter.Update(manageMentDataSet.Data);
            refresh();
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Passw fr = new Passw();
            fr.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void subjectTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataBindingSource.AddNew();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataBindingSource.RemoveCurrent();
            dataBindingSource.EndEdit();
            dataTableAdapter.Update(manageMentDataSet.Data);
            refresh();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            moneyDataGridView.CurrentRow.Cells[0].Value = take_InNumericUpDown1.Value;



            Validate();
            //manageMentDataSet.Money.Rows[0] +=(int) take_InNumericUpDown1.Value;
            
            dataBindingSource.EndEdit();
            dataTableAdapter.Update(manageMentDataSet.Data);
            refresh();
            
        }
        private void refresh()
        {


            dataBindingSource.Filter = null;
            dataTableAdapter.Fill(manageMentDataSet.Data);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void moneyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mone fr = new Mone();
            fr.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
        Bitmap bmp;
        private void button6_Click(object sender, EventArgs e)
        {
            dataDataGridView.ClearSelection();
            int hieght = dataDataGridView.Height;
            dataDataGridView.Height = dataDataGridView.RowCount * dataDataGridView.RowTemplate.Height * 2;

            bmp = new Bitmap(dataDataGridView.Width, dataDataGridView.Height);
            dataDataGridView.DrawToBitmap(bmp,new Rectangle(0,0,dataDataGridView.Width,dataDataGridView.Height));
            dataDataGridView.Height = hieght;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
