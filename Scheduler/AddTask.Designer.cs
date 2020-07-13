namespace Scheduler
{
    partial class AddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblDaysBetween = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.cbRecurring = new Scheduler.CheckBoxCustom();
            this.numericDaysBetween = new System.Windows.Forms.NumericUpDown();
            this.cbAlternate = new Scheduler.CheckBoxCustom();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.lblOwner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericDaysBetween)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskTitle.Location = new System.Drawing.Point(17, 42);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(621, 35);
            this.txtTaskTitle.TabIndex = 0;
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(97, 30);
            this.lblTaskTitle.TabIndex = 1;
            this.lblTaskTitle.Text = "Task Title";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblDueDate.Location = new System.Drawing.Point(639, 8);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(101, 30);
            this.lblDueDate.TabIndex = 2;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblDaysBetween
            // 
            this.lblDaysBetween.AutoSize = true;
            this.lblDaysBetween.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblDaysBetween.Location = new System.Drawing.Point(989, 92);
            this.lblDaysBetween.Name = "lblDaysBetween";
            this.lblDaysBetween.Size = new System.Drawing.Size(197, 30);
            this.lblDaysBetween.TabIndex = 5;
            this.lblDaysBetween.Text = "Days Between Tasks";
            this.lblDaysBetween.Visible = false;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.dtpDueDate.Location = new System.Drawing.Point(644, 42);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(344, 35);
            this.dtpDueDate.TabIndex = 1;
            // 
            // cbRecurring
            // 
            this.cbRecurring.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.cbRecurring.Location = new System.Drawing.Point(644, 93);
            this.cbRecurring.Name = "cbRecurring";
            this.cbRecurring.Size = new System.Drawing.Size(131, 31);
            this.cbRecurring.TabIndex = 3;
            this.cbRecurring.Text = "Recurring";
            this.cbRecurring.UseVisualStyleBackColor = true;
            this.cbRecurring.CheckedChanged += new System.EventHandler(this.cbRecurring_CheckedChanged);
            // 
            // numericDaysBetween
            // 
            this.numericDaysBetween.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.numericDaysBetween.Location = new System.Drawing.Point(1192, 93);
            this.numericDaysBetween.Name = "numericDaysBetween";
            this.numericDaysBetween.Size = new System.Drawing.Size(55, 30);
            this.numericDaysBetween.TabIndex = 5;
            this.numericDaysBetween.Visible = false;
            // 
            // cbAlternate
            // 
            this.cbAlternate.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.cbAlternate.Location = new System.Drawing.Point(781, 93);
            this.cbAlternate.Name = "cbAlternate";
            this.cbAlternate.Size = new System.Drawing.Size(203, 30);
            this.cbAlternate.TabIndex = 4;
            this.cbAlternate.Text = "Alternate Owners";
            this.cbAlternate.UseVisualStyleBackColor = true;
            this.cbAlternate.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1142, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbOwner
            // 
            this.cmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOwner.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(994, 42);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(142, 33);
            this.cmbOwner.TabIndex = 2;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblOwner.Location = new System.Drawing.Point(989, 8);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(74, 30);
            this.lblOwner.TabIndex = 12;
            this.lblOwner.Text = "Owner";
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 147);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.cmbOwner);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbAlternate);
            this.Controls.Add(this.numericDaysBetween);
            this.Controls.Add(this.cbRecurring);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.lblDaysBetween);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblTaskTitle);
            this.Controls.Add(this.txtTaskTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            ((System.ComponentModel.ISupportInitialize)(this.numericDaysBetween)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblDaysBetween;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private CheckBoxCustom cbRecurring;
        private System.Windows.Forms.NumericUpDown numericDaysBetween;
        private CheckBoxCustom cbAlternate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.Label lblOwner;
    }
}