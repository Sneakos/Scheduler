namespace Scheduler
{
    partial class HomePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTodaysTasks = new System.Windows.Forms.Label();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            this.cmsTaskActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAlex = new Scheduler.CheckBoxCustom();
            this.cbSeth = new Scheduler.CheckBoxCustom();
            this.cbJessica = new Scheduler.CheckBoxCustom();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.cmsTaskActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1481, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // lblTodaysTasks
            // 
            this.lblTodaysTasks.AutoSize = true;
            this.lblTodaysTasks.Font = new System.Drawing.Font("Broadway", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysTasks.ForeColor = System.Drawing.Color.Navy;
            this.lblTodaysTasks.Location = new System.Drawing.Point(499, 9);
            this.lblTodaysTasks.Name = "lblTodaysTasks";
            this.lblTodaysTasks.Size = new System.Drawing.Size(756, 109);
            this.lblTodaysTasks.TabIndex = 1;
            this.lblTodaysTasks.Text = "Today\'s Tasks";
            // 
            // gridTasks
            // 
            this.gridTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridTasks.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTasks.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTasks.Location = new System.Drawing.Point(12, 143);
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTasks.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridTasks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridTasks.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTasks.Size = new System.Drawing.Size(1457, 448);
            this.gridTasks.TabIndex = 6;
            this.gridTasks.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridTasks_CellContextMenuStripNeeded);
            // 
            // cmsTaskActions
            // 
            this.cmsTaskActions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTaskActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemComplete,
            this.toolStripMenuItemEdit});
            this.cmsTaskActions.Name = "cmsTaskActions";
            this.cmsTaskActions.Size = new System.Drawing.Size(176, 72);
            // 
            // toolStripMenuItemComplete
            // 
            this.toolStripMenuItemComplete.Name = "toolStripMenuItemComplete";
            this.toolStripMenuItemComplete.Size = new System.Drawing.Size(175, 34);
            this.toolStripMenuItemComplete.Text = "Complete";
            this.toolStripMenuItemComplete.Click += new System.EventHandler(this.toolStripMenuItemComplete_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(175, 34);
            this.toolStripMenuItemEdit.Text = "Edit";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // cbAlex
            // 
            this.cbAlex.Checked = true;
            this.cbAlex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlex.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlex.ForeColor = System.Drawing.Color.Blue;
            this.cbAlex.Location = new System.Drawing.Point(12, 62);
            this.cbAlex.Name = "cbAlex";
            this.cbAlex.Size = new System.Drawing.Size(129, 42);
            this.cbAlex.TabIndex = 5;
            this.cbAlex.Text = "Alex";
            this.cbAlex.UseVisualStyleBackColor = true;
            this.cbAlex.CheckedChanged += new System.EventHandler(this.cbOwner_CheckedChanged);
            // 
            // cbSeth
            // 
            this.cbSeth.Checked = true;
            this.cbSeth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSeth.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.cbSeth.ForeColor = System.Drawing.Color.Black;
            this.cbSeth.Location = new System.Drawing.Point(320, 62);
            this.cbSeth.Name = "cbSeth";
            this.cbSeth.Size = new System.Drawing.Size(129, 42);
            this.cbSeth.TabIndex = 4;
            this.cbSeth.Text = "Seth";
            this.cbSeth.UseVisualStyleBackColor = true;
            this.cbSeth.CheckedChanged += new System.EventHandler(this.cbOwner_CheckedChanged);
            // 
            // cbJessica
            // 
            this.cbJessica.Checked = true;
            this.cbJessica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJessica.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.cbJessica.ForeColor = System.Drawing.Color.Magenta;
            this.cbJessica.Location = new System.Drawing.Point(147, 62);
            this.cbJessica.Name = "cbJessica";
            this.cbJessica.Size = new System.Drawing.Size(167, 42);
            this.cbJessica.TabIndex = 3;
            this.cbJessica.Text = "Jessica";
            this.cbJessica.UseVisualStyleBackColor = true;
            this.cbJessica.CheckedChanged += new System.EventHandler(this.cbOwner_CheckedChanged);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 603);
            this.Controls.Add(this.gridTasks);
            this.Controls.Add(this.cbAlex);
            this.Controls.Add(this.cbSeth);
            this.Controls.Add(this.cbJessica);
            this.Controls.Add(this.lblTodaysTasks);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "Tasks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.Resize += new System.EventHandler(this.HomePage_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.cmsTaskActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Label lblTodaysTasks;
        private CheckBoxCustom cbJessica;
        private CheckBoxCustom cbSeth;
        private CheckBoxCustom cbAlex;
        private System.Windows.Forms.DataGridView gridTasks;
        private System.Windows.Forms.ContextMenuStrip cmsTaskActions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemComplete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
    }
}

