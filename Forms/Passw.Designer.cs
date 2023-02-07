
namespace Management.Forms
{
    partial class Passw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passw));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label passLabel;
            this.manageMentDataSet = new Management.ManageMentDataSet();
            this.passBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passTableAdapter = new Management.ManageMentDataSetTableAdapters.PassTableAdapter();
            this.tableAdapterManager = new Management.ManageMentDataSetTableAdapters.TableAdapterManager();
            this.passBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.passBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.passDataGridView = new System.Windows.Forms.DataGridView();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            passLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manageMentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBindingNavigator)).BeginInit();
            this.passBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // manageMentDataSet
            // 
            this.manageMentDataSet.DataSetName = "ManageMentDataSet";
            this.manageMentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passBindingSource
            // 
            this.passBindingSource.DataMember = "Pass";
            this.passBindingSource.DataSource = this.manageMentDataSet;
            // 
            // passTableAdapter
            // 
            this.passTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataTableAdapter = null;
            this.tableAdapterManager.MoneyTableAdapter = null;
            this.tableAdapterManager.PassTableAdapter = this.passTableAdapter;
            this.tableAdapterManager.UpdateOrder = Management.ManageMentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // passBindingNavigator
            // 
            this.passBindingNavigator.AddNewItem = null;
            this.passBindingNavigator.BindingSource = this.passBindingSource;
            this.passBindingNavigator.CountItem = null;
            this.passBindingNavigator.DeleteItem = null;
            this.passBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passBindingNavigatorSaveItem});
            this.passBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.passBindingNavigator.MoveFirstItem = null;
            this.passBindingNavigator.MoveLastItem = null;
            this.passBindingNavigator.MoveNextItem = null;
            this.passBindingNavigator.MovePreviousItem = null;
            this.passBindingNavigator.Name = "passBindingNavigator";
            this.passBindingNavigator.PositionItem = null;
            this.passBindingNavigator.Size = new System.Drawing.Size(271, 25);
            this.passBindingNavigator.TabIndex = 0;
            this.passBindingNavigator.Text = "bindingNavigator1";
            // 
            // passBindingNavigatorSaveItem
            // 
            this.passBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.passBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("passBindingNavigatorSaveItem.Image")));
            this.passBindingNavigatorSaveItem.Name = "passBindingNavigatorSaveItem";
            this.passBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.passBindingNavigatorSaveItem.Text = "Save Data";
            this.passBindingNavigatorSaveItem.Click += new System.EventHandler(this.passBindingNavigatorSaveItem_Click);
            // 
            // passDataGridView
            // 
            this.passDataGridView.AllowUserToAddRows = false;
            this.passDataGridView.AllowUserToDeleteRows = false;
            this.passDataGridView.AutoGenerateColumns = false;
            this.passDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.passDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.passDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.passDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.passDataGridView.DataSource = this.passBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.passDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.passDataGridView.Location = new System.Drawing.Point(0, 82);
            this.passDataGridView.Name = "passDataGridView";
            this.passDataGridView.ReadOnly = true;
            this.passDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passDataGridView.Size = new System.Drawing.Size(271, 132);
            this.passDataGridView.TabIndex = 1;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passLabel.Location = new System.Drawing.Point(193, 36);
            passLabel.Name = "passLabel";
            passLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            passLabel.Size = new System.Drawing.Size(66, 31);
            passLabel.TabIndex = 2;
            passLabel.Text = "رمز :";
            passLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passBindingSource, "Pass", true));
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(12, 43);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(175, 26);
            this.passTextBox.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Pass";
            this.dataGridViewTextBoxColumn1.HeaderText = "رمز";
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
            // 
            // Passw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(271, 214);
            this.Controls.Add(passLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.passDataGridView);
            this.Controls.Add(this.passBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Passw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passw";
            this.Load += new System.EventHandler(this.Passw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageMentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBindingNavigator)).EndInit();
            this.passBindingNavigator.ResumeLayout(false);
            this.passBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ManageMentDataSet manageMentDataSet;
        private System.Windows.Forms.BindingSource passBindingSource;
        private ManageMentDataSetTableAdapters.PassTableAdapter passTableAdapter;
        private ManageMentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator passBindingNavigator;
        private System.Windows.Forms.ToolStripButton passBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView passDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox passTextBox;
    }
}