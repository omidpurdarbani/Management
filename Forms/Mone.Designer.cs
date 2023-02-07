
namespace Management.Forms
{
    partial class Mone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label moneyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mone));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.manageMentDataSet = new Management.ManageMentDataSet();
            this.moneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyTableAdapter = new Management.ManageMentDataSetTableAdapters.MoneyTableAdapter();
            this.tableAdapterManager = new Management.ManageMentDataSetTableAdapters.TableAdapterManager();
            this.moneyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.moneyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.moneyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            moneyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manageMentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingNavigator)).BeginInit();
            this.moneyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            moneyLabel.Location = new System.Drawing.Point(206, 31);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            moneyLabel.Size = new System.Drawing.Size(84, 26);
            moneyLabel.TabIndex = 1;
            moneyLabel.Text = "موجودی :";
            // 
            // manageMentDataSet
            // 
            this.manageMentDataSet.DataSetName = "ManageMentDataSet";
            this.manageMentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneyBindingSource
            // 
            this.moneyBindingSource.DataMember = "Money";
            this.moneyBindingSource.DataSource = this.manageMentDataSet;
            // 
            // moneyTableAdapter
            // 
            this.moneyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataTableAdapter = null;
            this.tableAdapterManager.MoneyTableAdapter = this.moneyTableAdapter;
            this.tableAdapterManager.PassTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Management.ManageMentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // moneyBindingNavigator
            // 
            this.moneyBindingNavigator.AddNewItem = null;
            this.moneyBindingNavigator.BindingSource = this.moneyBindingSource;
            this.moneyBindingNavigator.CountItem = null;
            this.moneyBindingNavigator.DeleteItem = null;
            this.moneyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moneyBindingNavigatorSaveItem});
            this.moneyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.moneyBindingNavigator.MoveFirstItem = null;
            this.moneyBindingNavigator.MoveLastItem = null;
            this.moneyBindingNavigator.MoveNextItem = null;
            this.moneyBindingNavigator.MovePreviousItem = null;
            this.moneyBindingNavigator.Name = "moneyBindingNavigator";
            this.moneyBindingNavigator.PositionItem = null;
            this.moneyBindingNavigator.Size = new System.Drawing.Size(302, 25);
            this.moneyBindingNavigator.TabIndex = 0;
            this.moneyBindingNavigator.Text = "bindingNavigator1";
            // 
            // moneyBindingNavigatorSaveItem
            // 
            this.moneyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moneyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("moneyBindingNavigatorSaveItem.Image")));
            this.moneyBindingNavigatorSaveItem.Name = "moneyBindingNavigatorSaveItem";
            this.moneyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.moneyBindingNavigatorSaveItem.Text = "Save Data";
            this.moneyBindingNavigatorSaveItem.Click += new System.EventHandler(this.moneyBindingNavigatorSaveItem_Click_3);
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moneyBindingSource, "Money", true));
            this.moneyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyTextBox.Location = new System.Drawing.Point(12, 28);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(188, 30);
            this.moneyTextBox.TabIndex = 2;
            // 
            // moneyDataGridView
            // 
            this.moneyDataGridView.AllowUserToAddRows = false;
            this.moneyDataGridView.AllowUserToDeleteRows = false;
            this.moneyDataGridView.AutoGenerateColumns = false;
            this.moneyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.moneyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.moneyDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moneyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.moneyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moneyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.moneyDataGridView.DataSource = this.moneyBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.moneyDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.moneyDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.moneyDataGridView.Location = new System.Drawing.Point(0, 64);
            this.moneyDataGridView.Name = "moneyDataGridView";
            this.moneyDataGridView.ReadOnly = true;
            this.moneyDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moneyDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.moneyDataGridView.Size = new System.Drawing.Size(302, 181);
            this.moneyDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Money";
            this.dataGridViewTextBoxColumn1.HeaderText = "موجودی";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 43;
            // 
            // Mone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(302, 245);
            this.Controls.Add(this.moneyDataGridView);
            this.Controls.Add(moneyLabel);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.moneyBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mone";
            this.Text = "Mone";
            this.Load += new System.EventHandler(this.Mone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageMentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingNavigator)).EndInit();
            this.moneyBindingNavigator.ResumeLayout(false);
            this.moneyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ManageMentDataSet manageMentDataSet;
        private System.Windows.Forms.BindingSource moneyBindingSource;
        private ManageMentDataSetTableAdapters.MoneyTableAdapter moneyTableAdapter;
        private ManageMentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator moneyBindingNavigator;
        private System.Windows.Forms.ToolStripButton moneyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.DataGridView moneyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}